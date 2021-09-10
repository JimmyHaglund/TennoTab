import { Component, OnInit } from '@angular/core';
import { CollectibleService } from '../../_services';
import { Collectible, CollectibleSearchForm } from '../../_interfaces';
import { BlueprintService, } from 'src/app/_services';
import { Blueprint, BlueprintComponent, ResourceStack, BlueprintCost } from '../../_interfaces/blueprint';

@Component({
  selector: 'app-wish-list',
  templateUrl: './wish-list.component.html',
  styleUrls: ['./wish-list.component.scss']
})
export class WishListComponent implements OnInit {
  public collectibles: Collectible[] = [];
  public blueprints: Blueprint[] = [];
  public resourceCosts: BlueprintCost[] = [];

  private _searchForm: CollectibleSearchForm = {
    includeFrames: true,
    includePrimaryWeapons: true,
    includeSecondaryWeapons: true,
    includeMeleeWeapons: true,
    includePets: true,
    includeRoboWeapons: true,
    includeOperatorAmps: true,
    includeArchwings: true,
    includeArchGuns: true,
    includeArchMeleeWeapons: true,

    onlyOnWishlist: true,
    includeOwned: true,
    includeMastered: true,
    searchText: ""
  };
  constructor(
    private collectibleService: CollectibleService,
    private blueprintService: BlueprintService
  ) { 
    this.removeItem = this.removeItem.bind(this);
  }

  ngOnInit(): void {
    this.getCollectibles();
  }

  getBlueprintComponents(name: string): BlueprintComponent[] {
    let blueprint = this.blueprints.find(blueprint => blueprint.resultName === name);
    return blueprint === undefined ? [] : blueprint.components;
  }

  getBlueprint(resultName: string): Blueprint {
    let result = this.blueprints.find(blueprint => blueprint.resultName === resultName);
    return result === undefined ? {resultName: "Null", components: []} : result;
  }

  getBlueprintResourceCost(name: string): BlueprintCost {
    let cost = this.resourceCosts.find(cost => cost.name === name);
    return cost === undefined ? {name: name, cost: []} : cost;
  }

  removeItem(name: string): void {
    let index = this.collectibles.findIndex(collectible => collectible.name === name);
    if (index > -1) {
      this.collectibles.splice(index, 1);
    }
    index = this.resourceCosts.findIndex(stack => stack.name === name);
    if(index > -1) {
      this.resourceCosts.splice(index, 1);
    }
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

  hasResourceCost(): boolean {
    return this.getTotalCost().length > 0;
  }

  private getCollectibles() {
    this.collectibleService.getCollectibles(this._searchForm)
      .subscribe(collectibles => {
        this.collectibles = collectibles;
        this.getBlueprints();
        this.getCosts();
      });
  }

  private getBlueprints() {
    this.blueprints = [];
    this.collectibles.forEach(collectible => {
      this.blueprintService.getBlueprintsWithResult(collectible.name)
        .subscribe(components => {
          let blueprint = {
            resultName: collectible.name,
            components: components.map(component => {
              return {
                name: component.componentName,
                componentCount: component.componentCount
              }
            })
          };
          this.blueprints.push(blueprint);
        });
    });
  }

  private getCosts() {
    this.resourceCosts = [];
    this.collectibles.forEach(collectible => {
      this.blueprintService.getTotalResourceCost(collectible.name)
        .subscribe(costs => {
          let blueprintCost = {
            name: collectible.name,
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
    });
  }
}
