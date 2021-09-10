import { Observable } from 'rxjs';
import { Component, OnInit, Input } from '@angular/core';
import { Collectible, Blueprint, BlueprintComponent, BlueprintCost, ResourceStack } from '../../../_interfaces';
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
  public componentBlueprints: Blueprint[] = [];
  public resourceCosts: BlueprintCost[] = [];

  constructor(
    private blueprintService: BlueprintService,
    private collectibleService: CollectibleService
    ) { }

  ngOnInit(): void {
    this.loadBlueprints();
  }

  public getComponentBlueprint(resultName: string): Blueprint {
    let result = this.componentBlueprints.find(blueprint => blueprint.resultName === resultName);
    return result === undefined ? { resultName: "Null", components: [] } : result;
  }

  public getBlueprintResourceCost(name: string): BlueprintCost {
    let cost = this.resourceCosts.find(cost => cost.name === name);
    return cost === undefined ? { name: name, cost: [] } : cost;
  }

  public get statusText(): string {
    return this.collectible.mastered ? "mastered" : 
      this.collectible.obtained ? "obtained" : "not obtained";
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

  public removeFromWishlist(): void {
    console.log("Removing collectible", this.collectible.name, " from wishlist");
    this.collectible.onWishlist = false;
    this.updateCollectible();
    if (this.onDelete !== undefined) this.onDelete(this.collectible.name);
  }

  private updateCollectible(): void {
    this.collectibleService.updateCollectible(this.collectible)
    .subscribe(()=>{});
  }

  private loadBlueprints() {
    this.loadBlueprint(this.collectible.name, (blueprint: Blueprint) => {
      if (blueprint === null || blueprint === undefined) return;
      this.mainBlueprint = blueprint;
      this.loadCosts(this.mainBlueprint.resultName);

      blueprint.components.forEach((component: BlueprintComponent) => {
        this.loadBlueprint(component.name, (componentBlueprint: Blueprint) => {
          if (componentBlueprint === null || componentBlueprint === undefined) return;
          this.componentBlueprints.push(componentBlueprint);
          this.loadCosts(componentBlueprint.resultName);
        });
      });

    });
  }

  private loadBlueprint(resultName: string, onResult: (bp: Blueprint) => void): void {
    this.blueprintService.getBlueprintsWithResult(resultName)
      .subscribe(components => {
        let blueprint = {
          resultName: resultName,
          components: components.map(component => {
            return {
              name: component.componentName,
              componentCount: component.componentCount
            }
          })
        };
        onResult(blueprint);
      });
  }

  private loadCosts(resultName: string) {
    this.blueprintService.getTotalResourceCost(resultName)
      .subscribe(costs => {
        let blueprintCost = {
          name: resultName,
          cost: costs.map(stack => {
            return {
              id: stack.id,
              name: stack.name,
              amount: stack.amount
            }
          })
        };
        this.resourceCosts.push(blueprintCost);
      });
  }

  getTotalCost(): ResourceStack[] {
    let result: ResourceStack[] = [];
    for(let n = 0; n < this.resourceCosts.length; n++) {
      for(let i = 0; i < this.resourceCosts[n].cost.length; i++) {
        let stack = this.resourceCosts[n].cost[i];
        let existingStack = result.findIndex(s => s.name === stack.name);
        if (existingStack > -1) {
          result[existingStack].amount += stack.amount;
        }
        else {
          result.push({id: stack.id, name: stack.name, amount: stack.amount});
        }
      }
    }
    let creditsIndex = result.findIndex(stack => stack.name === "Credits");
    if (creditsIndex > -1) {
      let credits = result[creditsIndex];
      result.splice(creditsIndex, 1);
      result.splice(0, 0, credits);
    }
    return result;
  }

}
