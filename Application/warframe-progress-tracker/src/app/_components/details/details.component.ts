import { Component, OnInit, Input } from '@angular/core';
import { Collectible } from 'src/app/_interfaces';
import { CollectibleService } from 'src/app/_services';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { BlueprintService } from 'src/app/_services';
import { Blueprint, BlueprintComponentStack } from 'src/app/_interfaces';
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
  public sourceHtmlSnippets: string[] = [];
  private _sourceTemplates: any = {};

  private get _name(): string { return String(this._route.snapshot.paramMap.get('name')); }
  private get _category(): string { return String(this._route.snapshot.paramMap.get('category')); }
  
  constructor(
    private _route: ActivatedRoute,
    private _location: Location,
    private _collectibleService: CollectibleService,
    private _blueprintService: BlueprintService,
    private _sourceService: SourceService
  ) { }

  ngOnInit(): void {
    this.getCollectible();
    this.getComponents();
    this.getCost(this._name);
  }

  public get statusText(): string {
    if (this.collectible == null) return "";
    return this.collectible.mastered ? "Mastered" :
      this.collectible.obtained ? "Obtained" : "Not obtained";
  }

  public get components() { 
    return this.blueprint === undefined ?  undefined : this.blueprint.components 
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

  public toggleWishlist(): void {
    let onWishlist = this.collectible.onWishlist;
    if (onWishlist) this.removeFromWishlist();
    else this.addToWishlist();
  }

  public get wishlistText(): string {
    return this.collectible.onWishlist ? "Yes" : "No";
  }

  private getCollectible(): void {
    const name = this._name;

    this._collectibleService.getCollectible(name)
      .subscribe(collectible => {
        this.collectible = collectible;
        this.getComponentSources(name);
        this.initialisedCollectible = true;
      });
  }

  private getComponents(): void {
    const name = this._name;
    this._blueprintService.getBlueprint(name)
      .subscribe(blueprint => {
        if (blueprint === undefined) return;
        this.blueprint = blueprint;
        this.blueprint.components.forEach(component => {
          this.getComponentBlueprint(component.componentName);
          this.getComponentSources(component.componentName);
        });
      });
  }

  private getComponentBlueprint(componentName: string): void {
    this._blueprintService.getBlueprint(componentName)
      .subscribe(blueprint => {
        if (blueprint == null) return;
        this.componentBlueprints.push(blueprint);
      });
  }

  private getComponentSources(componentName: string): void {
    if (componentName === "Platinum") return;
    this._sourceService.getSources(componentName)
      .subscribe((sources) => {
        if (sources.length === 0) return;
        let sourceHtml = this.getSourceHtml(sources, componentName);
        this.sourceHtmlSnippets = this.sourceHtmlSnippets.concat(sourceHtml);
      });
  }

  private getCost(resultName: string): void {
    this._blueprintService.getTotalResourceCost(resultName)
      .subscribe(cost => this.totalCost = cost);
  }

  private updateCollectible(): void {
    this._collectibleService.updateCollectible(this.collectible)
      .subscribe(() => { });
  }

  public getDetailsHtml(component: BlueprintComponentStack): string {
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

  private getComponentSourceHtmlSnippets(): string[] {
    let result:string[] = [];
    
    this.components?.forEach((component) => {
      
    });
    
    return result;
  }

  private getSourceHtml(templates: string[], componentName: string): string[] {
    let result: string[] = [`<h4><b>${componentName}</b></h4>`];
    result = result.concat(templates);
    return result;
  }
}
