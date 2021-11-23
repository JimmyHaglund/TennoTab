import { Observable } from 'rxjs';
import { Component, OnInit, Input } from '@angular/core';
import { Collectible, Blueprint, BlueprintComponentStack } from '../../../_interfaces';
import { BlueprintService, CollectibleService} from '../../../_services';

@Component({
  selector: 'app-wish-list-card',
  templateUrl: './wish-list-card.component.html',
  styleUrls: ['./wish-list-card.component.scss']
})
export class WishListCardComponent implements OnInit {
  @Input() public collectible!: Collectible;
  @Input() public onDelete!: (name: string)=>void;

  public mainBlueprint: Blueprint = { resultName: "", components: [] };
  public totalBuildCost: BlueprintComponentStack[] = [];

  constructor(
    private _blueprintService: BlueprintService,
    private _collectibleService: CollectibleService
    ) { }

  ngOnInit(): void {
    this.loadBlueprint(this.collectible.name);
    this.getTotalCost(this.collectible.name);
  }

  public get statusText(): string {
    return this.collectible.mastered ? "mastered" : 
      this.collectible.obtained ? "obtained" : "not obtained";
  }

  public get components() {return this.mainBlueprint.components}

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

  public removeFromWishlist(): void {
    console.log("Removing collectible", this.collectible.name, " from wishlist");
    this.collectible.onWishlist = false;
    this.updateCollectible();
    if (this.onDelete !== undefined) this.onDelete(this.collectible.name);
  }

  private updateCollectible(): void {
    this._collectibleService.updateCollectible(this.collectible)
    .subscribe(()=>{});
  }

  private loadBlueprint(resultName: string): void {
    this._blueprintService.getBlueprint(resultName)
      .subscribe(blueprint => {
        this.mainBlueprint = blueprint;
      });
  }

  getTotalCost(resultName: string): void {
    this._blueprintService.getTotalResourceCost(resultName)
      .subscribe(cost => this.totalBuildCost = cost);
  }

}
