import { Component, OnInit } from '@angular/core';
import { Collectible, collectibleCategories } from '../../_interfaces';
import { CollectibleSearchForm } from '../../_interfaces';
import { CollectibleService } from '../../_services';
import { startWith } from 'rxjs/operators';
import { Action } from '../../_tools';
import { CollectibleFilter } from './collectibleFilter';

interface IDisplayedCategories {
  [key: string]: boolean;
}

@Component({
  selector: 'app-collectible',
  templateUrl: './collectibles.component.html',
  styleUrls: ['./collectibles.component.scss']
})
export class CollectiblesComponent implements OnInit {
  public collectibleFilter = new CollectibleFilter();
  public collectibles: Collectible[] = [];
  private _sortMethod: string = "CategoryDescending";

  constructor(private collectibleService: CollectibleService) { }

  public get displayedCollectibles(): Collectible[] {
    let result = [];
    for (let n = 0; n < this.collectibles.length; n++) {
      const collectible = this.collectibles[n];
      if(!this.collectibleFilter.shouldShowCollectible(collectible)) continue;
      result.push(collectible);
    }
    this.sortCollectibles(result);

    return result;
  }

  ngOnInit(): void {
    this.getCollectibles();
  }

  public collectedValue(collectible: Collectible): string {
    return !collectible.obtained ? "Not obtained" :
      collectible.mastered ? "Mastered" : "Obtained";
  }

  public collectedColor(collectible: Collectible): string {
    return !collectible.obtained ? "bg-dark" :
      collectible.mastered ? "bg-success" : "bg-light";
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

  private getCollectibles() {
    this.collectibleService.getCollectibles()
      .subscribe(collectibles => this.collectibles = collectibles);
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