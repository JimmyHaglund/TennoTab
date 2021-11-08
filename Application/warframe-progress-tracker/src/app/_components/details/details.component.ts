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
  category: string;
  detailsHtml: string;
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
    let me = this;
    this.blueprintService.getBlueprintsWithResult(name)
      .subscribe(blueprint => {
        this.blueprint = blueprint
        .map<BlueprintComponent>(component => {
          return { 
            resource: component, 
            cost: [], 
            source: [], 
            category: component.componentCategory,
            detailsHtml: ""
          };
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
      .subscribe(cost => this.summarizeCost(cost));
  }

  private summarizeCost(cost: IResource[]): void {
    let result: IResource[] = [];
    for(let n = 0; n < cost.length; n++) {
      let resource = cost[n];
      let matchFound = false;
      result.forEach(element => {
        if (element.id === resource.id) {
          element.amount += resource.amount;
          matchFound = true;
        }
      });
      if (matchFound) continue;
      result.push({id: cost[n].id, name: cost[n].name, amount: cost[n].amount});
    }
    this.cost = result;
  }

  private getCostOfComponent(component: BlueprintComponent):void {
    this.blueprintService
      .getComponents(component.resource.componentName)
      .subscribe(cost => {
        component.cost = cost;
        component.detailsHtml = this.getDetailsHtml(component);
      });
  }

  private getComponentSource(component: BlueprintComponent) {
    this.blueprintService
      .getSource(component.resource.componentName + " Blueprint")
      .subscribe(source => {
        component.source = source;
        component.detailsHtml = this.getDetailsHtml(component);
      });
  }

  private updateCollectible(): void {
    this.collectibleService.updateCollectible(this.collectible)
    .subscribe(()=>{});
  }

  public getDetailsHtml(component: BlueprintComponent): string {
    let title = component.resource.componentName;
    let result = "<h4>" + title;

    if (component.category == "Resource")  {
      let amount = component.resource.componentCount;
      return result + ` (${amount})` + "</h4>"
    }

    result += "</h4>";
    
    return result + this.getBuildCostHtml(component) + this.getSourceHtml(component);
  }

  private getBuildCostHtml(component: BlueprintComponent): string {
    if (component.cost.length == 0) return "";
    let result = "<div> <h5>Build Cost</h5>";

    let cost = component.cost.map<string>(resource => {
      let name = resource.name;
      let amount = resource.amount;
      return `${name} (${amount})`;
    });

    cost.forEach(costString => {
      result += `<div>${costString}</div>`;
    });
    
    return result + "</div>";
  }

  private getSourceHtml(component: BlueprintComponent): string {
    let sources = component.source.map(source => {
      return source.sourceName + "(" + source.sourceType + ", " + source.value + ")";
    });
    if (sources.length == 0) return "";
    let title = sources.length > 1 ? "Sources" : "Sources";
    let result = `<div> <h5>${title}</h5>`;
    sources.forEach(sourceHtml => {
      result += "<div>" + sourceHtml + "</div>";
    });
    return result + "</div>";
  }
}
