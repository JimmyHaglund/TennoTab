import { Component, OnInit } from '@angular/core';
import {Collectible, collectibleCategories } from '../collectible';
import {CollectibleSearchForm} from '../collectibleSearchForm';
import {CollectibleService} from '../collectible.service';
import { FrameDetailComponent } from 'src/app/warframes/frame-detail/frame-detail.component';

@Component({
  selector: 'app-collectible',
  templateUrl: './collectible.component.html',
  styleUrls: ['./collectible.component.scss']
})
export class CollectibleComponent implements OnInit {
  collectibles: Collectible[] = [];
  constructor(private collectibleService: CollectibleService) { }

  ngOnInit(): void {
    this.getCollectibles();
  }

  private getCollectibles() {
    this.collectibleService.getCollectibles()
      .subscribe(collectibles => this.collectibles = collectibles);
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
    console.log(collectible.category);
    switch(collectible.category) {
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
}