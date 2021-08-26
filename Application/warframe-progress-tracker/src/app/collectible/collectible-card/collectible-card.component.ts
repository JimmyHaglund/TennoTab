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

  constructor(private collectibleService: CollectibleService) { }

  ngOnInit(): void { 


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

  public increaseRank(): void {
    if (!this.collectible.obtained) {
      this.collectible.obtained = true;
    } else if (!this.collectible.mastered) {
      this.collectible.mastered = true;
    } else return;
    this.updateCollectible();
  }

  public reduceRank(): void {
    console.log("Reducing rank for collectible", this.collectible.name);
  }

  public addToWishlist(): void {
    console.log("Adding collectible", this.collectible.name, " to wishlist");
    this.collectible.onWishlist = true;
    this.updateCollectible();
  }

  public removeFromWishlist(): void {
    console.log("Removing collectible", this.collectible.name, " from wishlist");
    this.collectible.onWishlist = false;
    this.updateCollectible();
  }

  public toggleWishList(): void {
    if (this.collectible.onWishlist) this.removeFromWishlist();
    else this.addToWishlist();
  }

  public getWishListStyle(): string {
    return this.collectible.onWishlist ? "status-icon" : "hide";
  }

  public getRankIcon(): string {
    return this.collectible.mastered ? "fas fa-crown" :
      this.collectible.obtained ? "fas fa-check" : "hidden";
  }

  public getRankStyle(): string {
    return this.collectible.obtained ? "status-icon" : "hide";
  }

  private updateCollectible() {
    this.collectibleService.updateCollectible(this.collectible)
    .subscribe(()=>{});
  }
}
