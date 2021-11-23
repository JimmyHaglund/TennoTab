import { Component, OnInit, Input } from '@angular/core';
import { Collectible } from '../../_interfaces';
import { CollectibleService } from '../../_services';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { BlueprintService } from 'src/app/_services';
import {Blueprint, BlueprintComponentStack } from '../../_interfaces';
import { SourceService } from 'src/app/_services/source.service';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.scss']
})
export class DetailsComponent implements OnInit {
  public collectible!: Collectible;
  public blueprint!: Blueprint;
  public totalCost: BlueprintComponentStack[] = [];
  public componentBlueprints: Blueprint[] = [];
  public initialisedCollectible = false;

  private get name(): string { return String(this.route.snapshot.paramMap.get('name')); }
  private get category(): string { return String(this.route.snapshot.paramMap.get('category')); }
  
  constructor(
    private route: ActivatedRoute,
    private location: Location,
    private collectibleService: CollectibleService,
    private blueprintService: BlueprintService,
    private sourceService: SourceService
  ) { }

  ngOnInit(): void {
    this.getCollectible();
    this.getComponents();
    this.getCost(this.name);
  }

  public get statusText(): string {
    if (this.collectible == null) return "";
    return this.collectible.mastered ? "Mastered" :
      this.collectible.obtained ? "Obtained" : "Not obtained";
  }

  public get components() { return this.blueprint.components }


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
    const name = this.name;

    this.collectibleService.getCollectible(name)
      .subscribe(collectible => {
        this.collectible = collectible;
        this.initialisedCollectible = true;
      });
  }

  private getComponents(): void {
    const name = this.name;
    this.blueprintService.getBlueprint(name)
      .subscribe(blueprint => {
        this.blueprint = blueprint;
        this.blueprint.components.forEach(component => {
          this.getComponentBlueprint(component.componentName);
          this.getComponentSource(component.componentName);
        });
      });
  }

  private getComponentBlueprint(componentName: string) {
    this.blueprintService.getBlueprint(componentName)
      .subscribe(blueprint =>{ 
        if (blueprint == null) return;
        this.componentBlueprints.push(blueprint);
      });
  }

  private getComponentSource(componentName: string) {
    console.log("Get component source not implemented");
  }

  private getCost(resultName: string): void {
    this.blueprintService.getTotalResourceCost(resultName)
      .subscribe(cost => this.totalCost = cost);
  }

  private updateCollectible(): void {
    this.collectibleService.updateCollectible(this.collectible)
      .subscribe(()=>{});
  }

  public getDetailsHtml(component: BlueprintComponentStack): string {
    console.log(component);
    let title = component.componentName;
    let amount = component.componentCount;
    return "<h4>" + title + ` (${amount})` + "</h4>"
  }

  private getBuildCostHtml(blueprint: Blueprint): string {
    let result = "<div> <h5>Build Cost</h5>";
    blueprint.components.forEach(component => {
      let name = component.componentName;
      let amount = component.componentCount;
      let row = `<div>{name} ({amount})</div>`
      result += row;
    });
    return result;
  }

  private getSourceHtml(component: any): string {
    return "<p>Get Source not implemented</p>";
  }
}
