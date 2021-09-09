import { Component, OnInit } from '@angular/core';
import { Collectible, collectibleCategories } from '../../_interfaces';
import { CollectibleSearchForm } from '../../_interfaces';
import { CollectibleService } from '../../_services';
import { startWith } from 'rxjs/operators';
import { Action } from '../../_tools';
import { CollectibleFilter } from './collectibleFilter';
import { CollectibleSorter } from './collectibleSorter';

@Component({
  selector: 'app-collectible',
  templateUrl: './collectibles.component.html',
  styleUrls: ['./collectibles.component.scss']
})
export class CollectiblesComponent implements OnInit {
  public collectibleFilter = new CollectibleFilter();
  public sorter:CollectibleSorter = new CollectibleSorter();
  public collectibles: Collectible[] = [];

  constructor(private collectibleService: CollectibleService) { }

  public get displayedCollectibles(): Collectible[] {
    let result = [];
    for (let n = 0; n < this.collectibles.length; n++) {
      const collectible = this.collectibles[n];
      if(!this.collectibleFilter.shouldShowCollectible(collectible)) continue;
      result.push(collectible);
    }
    this.sorter.sort(result);

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
}