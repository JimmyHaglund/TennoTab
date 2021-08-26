import { Component, OnInit } from '@angular/core';
import { CollectibleService } from '../collectible.service';
import { Collectible, CollectibleSearchForm } from '..';
import { BlueprintService, } from 'src/app/_services';
import { Blueprint, BlueprintComponent, ResourceStack, BlueprintCost } from '../blueprint';

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
  ) { }

  ngOnInit(): void {
    this.getCollectibles();
  }

  getBlueprintComponents(name: string): BlueprintComponent[] {
    let blueprint = this.blueprints.find(blueprint => blueprint.resultName === name);
    return blueprint === undefined ? [] : blueprint.components;
  }

  getBlueprintResourceCost(name: string): ResourceStack[] {
    let blueprint = this.resourceCosts.find(cost => cost.name === name);
    return blueprint === undefined ? [] : blueprint.cost;
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
