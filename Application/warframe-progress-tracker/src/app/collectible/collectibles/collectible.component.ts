import { Component, OnInit } from '@angular/core';
import { Collectible, collectibleCategories } from '../collectible';
import { CollectibleSearchForm } from '../collectibleSearchForm';
import { CollectibleService } from '../collectible.service';
import { FrameDetailComponent } from 'src/app/warframes/frame-detail/frame-detail.component';

interface IDisplayedCategories {
  [key:string]:boolean;
}

@Component({
  selector: 'app-collectible',
  templateUrl: './collectible.component.html',
  styleUrls: ['./collectible.component.scss']
})
export class CollectibleComponent implements OnInit {
  public collectibles: Collectible[] = [];
  private _filterString: string = "Warframe Primary, Pet,  Gun  ";

  private _showCategories: IDisplayedCategories = {};

  constructor(private collectibleService: CollectibleService) { }

  public get displayedCollectibles(): Collectible[] {
    let result = [];
    for (let n = 0; n < this.collectibles.length; n++) {
      const collectible = this.collectibles[n];
      if (!this.showCollectible(collectible)) continue;
      if (!this.containsString(collectible, this._filterString)) continue;
      result.push(collectible);
    }
    return result;
  }

  ngOnInit(): void {
    this.getCollectibles();
    this.initialiseShownCategories();
  }

  public setFilterText(value:string):void {
    this._filterString=value;
  }

  public collectedValue(collectible: Collectible): string {
    return !collectible.obtained ? "Not obtained" :
      collectible.mastered ? "Mastered" : "Obtained";
  }

  public collectedColor(collectible: Collectible): string {
    return !collectible.obtained ? "bg-dark" :
      collectible.mastered ? "bg-success" : "bg-light";
  }

  public toggleShowCategory(categoryName:string): void {
    this._showCategories[categoryName] = !this._showCategories[categoryName];
    console.log(this._showCategories[categoryName])
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
    for(let key in collectibleCategories) {
      let category = collectibleCategories[key]
      showCategories[category] = true;
    }
    console.log(this._showCategories);
  }

  private getCollectibles() {
    this.collectibleService.getCollectibles()
      .subscribe(collectibles => this.collectibles = collectibles);
  }

  private showCollectible(collectible: Collectible): boolean {
    return this._showCategories[collectible.category];
  }

  private containsString(collectible: Collectible, value: string): boolean {
    let collectibleName = collectible.name.toLowerCase();
    let collectibleCategory = collectible.category.toLowerCase();
    let filter = value.toLowerCase().trim();
    const regularExpression = /,/
    let targetValues = filter.split(regularExpression);
    for(let n = 0; n < targetValues.length; n++) {
      targetValues[n] = targetValues[n].trim();
      let mustIncludes = targetValues[n].split(' ');
      let containsAll = true;
      for(let i = 0; i < mustIncludes.length; i++) {
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
}