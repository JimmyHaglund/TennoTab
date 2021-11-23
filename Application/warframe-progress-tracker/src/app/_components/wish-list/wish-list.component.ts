import { Component, OnInit } from '@angular/core';
import { CollectibleService } from '../../_services';
import { Collectible, collectibleCategories, CollectibleSearchForm } from '../../_interfaces';
import { BlueprintService, } from 'src/app/_services';
import { Blueprint, BlueprintComponentStack } from '../../_interfaces/blueprint';
import { ComponentView } from './ComponentView';

@Component({
  selector: 'app-wish-list',
  templateUrl: './wish-list.component.html',
  styleUrls: ['./wish-list.component.scss']
})
export class WishListComponent implements OnInit {
  public componentViews: ComponentView[] = [];
  // public collectibles: Collectible[] = [];
  // public blueprints: { blueprint: Blueprint, cost:BlueprintComponentStack[] }[] = [];

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

  private getCollectibles() {
    this.collectibleService.getCollectibles(this._searchForm)
      .subscribe(collectibles => {
        this.componentViews = collectibles.map(collectible => { 
          let view: ComponentView = {
            collectible: collectible,
            blueprint: {resultName: '', components: []},
            cost: []
          }
          return view;
        });
        // this.collectibles = collectibles;
        this.getBlueprints();
      });
  }

  private getBlueprints() {
    this.componentViews.forEach(view => {
      this.blueprintService.getBlueprint(view.collectible.name)
        .subscribe(blueprint => {
          this.updateViewBlueprint(view.collectible, blueprint);
          this.blueprintService.getTotalResourceCost(blueprint.resultName)
            .subscribe(cost => this.updateViewCost(view.collectible, cost));
        });
    });
  }

  private updateViewBlueprint(collectible: Collectible, blueprint:Blueprint): void {
    let targetView: ComponentView = {
      collectible: collectible,
      blueprint: blueprint,
      cost: []
    };
    let itemName = collectible.name;
    this.componentViews.forEach(view => {
      if (view.collectible.name === itemName) targetView = view;
    });
    targetView.blueprint = blueprint;
  }

  private updateViewCost(collectible: Collectible, cost:BlueprintComponentStack[]): void {
    let targetView: ComponentView = {
      collectible: collectible,
      blueprint: {resultName: '', components: []},
      cost: cost
    };
    let itemName = collectible.name;
    this.componentViews.forEach(view => {
      if (view.collectible.name === itemName) targetView = view;
    });
    targetView.cost = cost;
  }

  getBlueprintComponents(resultName: string): BlueprintComponentStack[] {
    let blueprint = this.componentViews.find(view => view.blueprint.resultName === resultName)?.blueprint;
    return blueprint === undefined ? [] : blueprint.components;
  }

  getBlueprint(resultName: string): Blueprint {
    let blueprint = this.componentViews.find(view => view.blueprint.resultName === resultName)?.blueprint;
    return blueprint === undefined ? { resultName: "Null", components: [] } : blueprint;
  }

  removeItem(name: string): void {
    let index = this.componentViews.findIndex(view => view.collectible.name === name);
    if (index > -1) {
      this.componentViews.splice(index, 1);
    }
  }
}
