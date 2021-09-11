import { Component, OnInit, Input } from '@angular/core';
import { Collectible } from '../../_interfaces';
import { CollectibleService } from '../../_services';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { BlueprintService, IBlueprintResource, IResource, ISource } from 'src/app/_services';

interface BlueprintComponent {
  source: ISource[];
  resource: IBlueprintResource;
  cost: IResource[];
}

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.scss']
})
export class DetailsComponent implements OnInit {
  public collectible!: Collectible;
  public blueprint: BlueprintComponent[] = [];
  public cost: IResource[] = [];
  public initialisedCollectible = false;

  private get name(): string { return String(this.route.snapshot.paramMap.get('name')); }
  private get category(): string { return String(this.route.snapshot.paramMap.get('category')); }
  
  constructor(
    private route: ActivatedRoute,
    private location: Location,
    private collectibleService: CollectibleService,
    private blueprintService: BlueprintService
  ) { }

  ngOnInit(): void {
    this.getCollectible();
    this.getComponents();
    this.getCost();
  }

  public get statusText(): string {
    if (this.collectible == null) return "";
    return this.collectible.mastered ? "Mastered" :
      this.collectible.obtained ? "Obtained" : "Not obtained";
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

  public addToWishlist(): void {
    this.collectible.onWishlist = true;
    this.updateCollectible();
  }

  public removeFromWishlist(): void {
    this.collectible.onWishlist = false;
    this.updateCollectible();
  }

  public toggleWishlist():void {
    let onWishlist = this.collectible.onWishlist;
    if (onWishlist) this.removeFromWishlist();
    else this.addToWishlist();
  }

  public get wishlistText(): string {
    return this.collectible.onWishlist ? "Yes" : "No";
  }

  private getCollectible(): void {
    const category = this.category;
    const name = this.name;

    this.collectibleService.getCollectible(category, name)
      .subscribe(collectible => {
        this.collectible = collectible;
        this.initialisedCollectible = true;
      });
  }

  private getComponents(): void {
    const name = this.name;
    this.blueprintService.getBlueprintsWithResult(name)
      .subscribe(blueprint => {
        this.blueprint = blueprint
        .map<BlueprintComponent>(component => {
          return { resource: component, cost: [], source: []};
        });
        this.blueprint.forEach(component => {
          this.getCostOfComponent(component);
          this.getComponentSource(component);
        });
      });
  }

  private getCost(): void {
    const name = this.name;
    this.blueprintService.getTotalResourceCost(name)
      .subscribe(cost => this.cost = cost);
  }

  private getCostOfComponent(component: BlueprintComponent):void {
    this.blueprintService
      .getTotalResourceCost(component.resource.componentName)
      .subscribe(cost => component.cost = cost);
  }

  private getComponentSource(component: BlueprintComponent) {
    this.blueprintService
      .getSource(component.resource.componentName + " Blueprint")
      .subscribe(source => component.source = source);
  }

  private updateCollectible(): void {
    this.collectibleService.updateCollectible(this.collectible)
    .subscribe(()=>{});
  }
}
