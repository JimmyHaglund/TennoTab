import { Component, OnInit } from '@angular/core';
import { Collectible, collectibleCategories } from '../../_interfaces';
import { CollectibleSearchForm } from '../../_interfaces';
import { CollectibleService } from '../../_services';
import { startWith } from 'rxjs/operators';

interface IDisplayedCategories {
  [key: string]: boolean;
}

@Component({
  selector: 'app-collectible',
  templateUrl: './collectibles.component.html',
  styleUrls: ['./collectibles.component.scss']
})
export class CollectiblesComponent implements OnInit {
  public collectibles: Collectible[] = [];
  private _filterString: string = "";
  private _showCategories: IDisplayedCategories = {};
  private _sortMethod: string = "CategoryDescending";
  private _filterObtained = "NonObtained"; // All | NonMastered NonObtained

  constructor(private collectibleService: CollectibleService) { }

  public get displayedCollectibles(): Collectible[] {
    let result = [];
    for (let n = 0; n < this.collectibles.length; n++) {
      const collectible = this.collectibles[n];
      if (!this.showCollectible(collectible)) continue;
      if (!this.passesObtainedFilter(collectible)) continue;
      if (!this.containsString(collectible, this._filterString)) continue;
      result.push(collectible);
    }
    this.sortCollectibles(result);

    return result;
  }

  ngOnInit(): void {
    this.getCollectibles();
    this.initialiseShownCategories();
  }

  public setFilterText(value: string): void {
    this._filterString = value;
  }

  public collectedValue(collectible: Collectible): string {
    return !collectible.obtained ? "Not obtained" :
      collectible.mastered ? "Mastered" : "Obtained";
  }

  public collectedColor(collectible: Collectible): string {
    return !collectible.obtained ? "bg-dark" :
      collectible.mastered ? "bg-success" : "bg-light";
  }

  public toggleShowCategory(categoryName: string): void {
    this._showCategories[categoryName] = !this._showCategories[categoryName];
    // console.log(this._showCategories[categoryName])
  }

  public setObtainedFilter(filter:string): void {
    this._filterObtained = filter;
  }

  public setSortingMethod(method: string): void {
    this._sortMethod = method;
  }

  public collectibleIcon(collectible: Collectible): string {
    switch (collectible.category) {
      case collectibleCategories.Warframe: return "fas fa-meh-blank";
      case collectibleCategories.PrimaryWeapon: return "fas fa-sun";
      case collectibleCategories.SecondaryWeapon: return "fas fa-moon";
      case collectibleCategories.MeleeWeapon: return "fas fa-sign-language";
      case collectibleCategories.Amp: return "fas fa-disease";
      case collectibleCategories.Pet: return "fas fa-dog";
      case collectibleCategories.RoboGun: return "fas fa-cog";
      case collectibleCategories.Archwing: return "fa fa-fighter-jet";
      case collectibleCategories.ArchGun: return "fas fa-dragon";
      case collectibleCategories.ArchMelee: return "fas fa-cut";
      default: return "fa fa-question";
    }
  }

  private initialiseShownCategories() {
    let showCategories = this._showCategories;
    for (let key in collectibleCategories) {
      let category = collectibleCategories[key]
      showCategories[category] = true;
    }
  }

  private getCollectibles() {
    this.collectibleService.getCollectibles()
      .subscribe(collectibles => this.collectibles = collectibles);
  }

  private showCollectible(collectible: Collectible): boolean {
    return this._showCategories[collectible.category];
  }

  private passesObtainedFilter(collectible: Collectible): boolean {
    const filter = this._filterObtained;
    return filter === 'All' || 
      collectible.obtained && !collectible.mastered && filter === 'NonMastered' ||
      !collectible.obtained && filter === 'NonObtained' ||
      collectible.mastered && filter === 'Mastered';
  }

  private containsString(collectible: Collectible, value: string): boolean {
    let collectibleName = collectible.name.toLowerCase();
    let collectibleCategory = collectible.category.toLowerCase();
    let filter = value.toLowerCase().trim();
    const regularExpression = /,/
    let targetValues = filter.split(regularExpression);
    for (let n = 0; n < targetValues.length; n++) {
      targetValues[n] = targetValues[n].trim();
      let mustIncludes = targetValues[n].split(' ');
      let containsAll = true;
      for (let i = 0; i < mustIncludes.length; i++) {
        if (!collectibleName.includes(mustIncludes[i])
          && !collectibleCategory.includes(mustIncludes[i])) {
          containsAll = false;
          break;
        }
      }
      if (containsAll) return true;
    }
    return false;
  }

  private sortCollectibles(collectibles: Collectible[]): void {
    switch (this._sortMethod) {
      case 'NameAscending':
        this.sortByNameAscending(collectibles);
        break;
      case 'NameDescending':
        this.sortByNameDescending(collectibles);
        break;
      case 'CategoryDescending':
        this.sortByCategoryDescending(collectibles);
        break;
      default:
        this.sortByCategoryAscending(collectibles);
        break;
    };
  }

  private sortByNameAscending(collectibles: Collectible[]): void {
    const charsOnlyUpperCase = this.charsOnlyUpperCase;
    collectibles.sort((collectibleA, collectibleB) => {
      const nameA = collectibleA.name;
      const nameB = collectibleB.name;
      return nameA < nameB ? -1 : nameA > nameB ? 1 : 0;
    });
  }

  private sortByNameDescending(collectibles: Collectible[]): void {
    collectibles.sort((collectibleA, collectibleB) => {
      const nameA = collectibleA.name;
      const nameB = collectibleB.name;
      return nameA > nameB ? -1 : nameA < nameB ? 1 : 0;
    });
  }

  private sortByCategoryAscending(collectibles: Collectible[]): void {
    const charsOnlyUpperCase = this.charsOnlyUpperCase;
    collectibles.sort((collectibleA, collectibleB) => {
      const categoryA = charsOnlyUpperCase(collectibleA.category);
      const categoryB = charsOnlyUpperCase(collectibleB.category);
      const nameA = collectibleA.name;
      const nameB = collectibleB.name;
    return categoryA < categoryB ? -1 : categoryA > categoryB ? 1 : 
      nameA < nameB ? -1 : nameA > nameB ? 1 : 0;
    });
  }

  private sortByCategoryDescending(collectibles: Collectible[]): void {
    const charsOnlyUpperCase = this.charsOnlyUpperCase;
    collectibles.sort((collectibleA, collectibleB) => {
      const categoryA = charsOnlyUpperCase(collectibleA.category);
      const categoryB = charsOnlyUpperCase(collectibleB.category);
      const nameA = collectibleA.name;
      const nameB = collectibleB.name;
      return categoryA > categoryB ? -1 : categoryA < categoryB ? 1 : 
        nameA < nameB ? -1 : nameA > nameB ? 1 : 0;
    });
  }

  private charsOnlyUpperCase(value: string) : string {
    const nonAlphaNumeric = /\W/;
    let match = value.toUpperCase().replace(nonAlphaNumeric, '');

    return match === null ? "" : match;
  }
}