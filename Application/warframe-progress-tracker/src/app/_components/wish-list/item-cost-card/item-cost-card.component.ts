import { Component, Input, OnInit, Output } from '@angular/core';
import { Blueprint, BlueprintCost, BlueprintComponent, ResourceStack } from '../../../_interfaces/blueprint';
import { Collectible } from '../../../_interfaces';
import { CollectibleService } from '../../../_services';

@Component({
  selector: 'app-item-cost-card',
  templateUrl: './item-cost-card.component.html',
  styleUrls: ['./item-cost-card.component.scss']
})
export class ItemCostCardComponent implements OnInit {
  @Input() public blueprint!: Blueprint;
  @Input() public collectible!: Collectible;
  @Input() public cost!: BlueprintCost;
  @Input() public onDelete!: (name: string)=>void;

  constructor(private collectibleService: CollectibleService) { }

  ngOnInit(): void { }

  getBlueprintComponents(): BlueprintComponent[] {
    if (this.blueprint === undefined) return [];
    let blueprint = this.blueprint;
    return blueprint === undefined ? [] : blueprint.components;
  }

  getBlueprintResourceCost(): ResourceStack[] {
    if (this.cost === undefined) return [];
    return this.cost.cost;
  }

  getStatusText(): string {
    const collectible = this.collectible;
    return collectible.mastered ? "Mastered" : 
      collectible.obtained ? "Obtained" : "Not obtained";
  }

  hasResourceCost(): boolean {
    return this.getBlueprintResourceCost().length > 0;
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
    if (this.collectible.mastered) {
      this.collectible.mastered = false;
    } else if (this.collectible.obtained) {
      this.collectible.obtained = false;
    } else return;
    this.updateCollectible();
  }

  removeFromWishlist(): void {
    console.log("Removing collectible", this.collectible.name, " from wishlist");
    this.collectible.onWishlist = false;
    this.updateCollectible();
    if (this.onDelete !== undefined) this.onDelete(this.collectible.name);
  }

  private updateCollectible(): void {
    this.collectibleService.updateCollectible(this.collectible)
    .subscribe(()=>{});
  }
}
