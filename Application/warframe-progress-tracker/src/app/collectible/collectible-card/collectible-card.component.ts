import { Component, Input, OnInit } from '@angular/core';
import { Collectible, collectibleCategories } from '../collectible';
import { CollectibleService } from '../collectible.service';

@Component({
  selector: 'app-collectible-card',
  templateUrl: './collectible-card.component.html',
  styleUrls: ['./collectible-card.component.scss']
})
export class CollectibleCardComponent implements OnInit {
  @Input() public collectible!: Collectible;

  private _isWishlisted = false;

  constructor(private collectibleService: CollectibleService) { }

  ngOnInit(): void { }

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

  public increaseRank(): void {
    if (!this.collectible.obtained) {
      this.collectible.obtained = true;
      console.log("Increasing rank for collectible", this.collectible.name, "obtained");
      return;
    }

    if (!this.collectible.mastered) {
      this.collectible.mastered = true;
      console.log("Increasing rank for collectible", this.collectible.name, "mastered");
      return;
    }
  }

  public reduceRank(): void {
    console.log("Reducing rank for collectible", this.collectible.name);
  }

  public addToWishlist(): void {
    console.log("Adding collectible", this.collectible.name, " to wishlist");
    this._isWishlisted = true;
  }

  public removeFromWishlist(): void {
    console.log("Removing collectible", this.collectible.name, " from wishlist");
    this._isWishlisted = false;
  }

  public toggleWishList(): void {
    this._isWishlisted = !this._isWishlisted;
  }

  public getWishListStyle(): string {
    return this._isWishlisted ? "status-icon" : "hide";
  }

  public getRankIcon(): string {
    return this.collectible.mastered ? "fas fa-crown" :
      this.collectible.obtained ? "fas fa-check" : "hidden";
  }

  public getRankStyle(): string {
    return this.collectible.obtained ? "status-icon" : "hide";
  }
}
