import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { first } from 'rxjs/operators';
import { catchError, map, filter, tap } from 'rxjs/operators';
import { environment } from '../../environments/environment';
import { Collectible, CollectibleSearchForm } from '../_interfaces';
/*
interface HtmlSnippable {
  htmlSnippet : string;
}

interface ISources {
  itemName: string,
  assassinationMissionSources: [],
  baroKiteerSources: [],
  bountySources: [],
  dailyTributeMilestoneSources: [],
  defectionMissionSources: [],
  defenseMissionSources: [],
  derelictCacheSources: [],
  disruptionMissionSources: [],
  enemyItemDropSources: [],
  exterminateMissionSources: [],
  exterminateMissionResourceCacheSources: [],
  granumVoidSources: [],

}
/**/

@Injectable({
  providedIn: 'root'
})
export class SourceService {
  private _apiAddress = environment.apiUrl + "itemsource/";
  private _snippetBuilder = new SnippetBuilder();

  constructor(private _http: HttpClient) { }

  getSources(itemName: string): Observable<string[]> {
    let url = this.getEndpoint(itemName);
    let header = { withCredentials: true };
    return this._http.get(url, header)
      .pipe(map((sources) => this._snippetBuilder.build(sources)))
      .pipe(first());
  }

  private getEndpoint(itemName: string): string {
    return this._apiAddress + itemName;
  }
}

class SnippetBuilder {
  private addSourceMethods = [
    this.AddAssassinationMissionSources,
    this.AddBaroKiteerSources,
    this.AddBountySources,
    this.AddDailyTributeMilestoneSources,
    this.AddDefectionMissionSources,
    this.AddDefenseMissionSources,
    this.AddDerelictCacheSources,
    this.AddDisruptionMissionSources,
    this.AddEnemyDropSources,
    this.AddExterminateMissionSources,
    this.AddExterminateResourceCacheSources,
    this.AddGranumVoidSources,
    this.AddInfestedSalvageMissionSources,
    this.AddInvasionSources,
    this.AddKuvaLichSources,
    this.AddMarketSources,
    this.AddNightwingSources,
    this.AddQuestSources,
    this.AddSabotageMissionSources,
    this.AddSanctuaryOnslaughtEliteSources,
    this.AddSanctuaryOnslaughtSources,
    this.AddSpyMissionSources,
    this.AddSurvivalMissionSources,
    this.AddSyndicateSources,
    this.AddVoidFissureMissionSources,
    this.AddVoidRelicSources
  ];

  public build(sources: any): string[] {
    let result: any[] = [];
    this.addSourceMethods.forEach((addSource) => {
      addSource(sources, result);
    });
    
    return result;
  }

  private AddAssassinationMissionSources(sourceData: any, result: any[]) {
    const sources: any[] = sourceData.assassinationMissionSources;
    if (Blank(sources)) return;
    sources.forEach(source => {
      result.push(`<p>Rewarded from <b>${source.mission} assassination</b> (${source.dropChance}% chance)</p>`);
    });
  }

  private AddBaroKiteerSources(sourceData: any, result: any[]) {
    const sources: any[] = sourceData.baroKiteerSources;
    if (Blank(sources)) return;
    sources.forEach(source => {
      let credits = source.creditsCost;
      let ducats = source.ducatsCost;
      let date: string = source.saleDate;
      date = date.split('T')[0];
      result.push(`<p>Could be bought from <b>Baro Ki'teer</b> at ${date}` +
        ` for <b>${credits}</b> credits and <b>${ducats}</b> ducats</p>`);
    });
  }

  private AddBountySources(sourceData: any, result: string[]) {
    const sources: any[] = sourceData.bountySources;
    
  }

  private AddDailyTributeMilestoneSources(sourceData: any, result: string[]) {
    const sources: any[] = sourceData.dailyTributeMilestoneSources;
    if (Blank(sources)) return;
    
  }

  private AddDefectionMissionSources(sourceData: any, result: string[]) {
    const sources: any[] = sourceData.defectionMissionSources;
    if (Blank(sources)) return;
  }

  private AddDefenseMissionSources(sourceData: any, result: string[]) {
    const sources: any[] = sourceData.defenseMissionSources;
    if (Blank(sources)) return;
  }

  private AddDerelictCacheSources(sourceData: any, result: string[]) {
    const sources: any[] = sourceData.dailyTributeMilestoneSources;
    if (Blank(sources)) return;
  }
  
  private AddDisruptionMissionSources(sources: any[], result: string[]) {
  }

  private AddEnemyDropSources(sourceData: any, result: string[]) {
    const sources: any[] = sourceData.enemyItemDropSources;
    if (Blank(sources)) return;
    if (Blank(sources)) return;
    sources.forEach(source => {
      result.push(`<p>Drops from <b>${source.enemyName}</b> (${source.dropChance}% chance)</p>`);
    });
  }

  private AddExterminateMissionSources(sourceData: any, result: string[]) {
    const sources: any[] = sourceData.exterminateMissionSources;
    if (Blank(sources)) return;
  }

  private AddExterminateResourceCacheSources(sourceData: any, result: string[]) {
    const sources: any[] = sourceData.exterminateMissionResourceCacheSources;
    if (Blank(sources)) return;
  }

  private AddGranumVoidSources(sourceData: any, result: string[]) {
    const sources: any[] = sourceData.granumVoidSources;
    if (Blank(sources)) return;
  }

  private AddInfestedSalvageMissionSources(sourceData: any, result: string[]) {
    const sources: any[] = sourceData.infestedSalvageMissionSources;
    if (Blank(sources)) return;
  }

  private AddInvasionSources(sourceData: any, result: string[]) {
    const sources: any[] = sourceData.invasionSources;
    if (Blank(sources)) return;
  }

  private AddKuvaLichSources(sourceData: any, result: string[]) {
    const sources: any[] = sourceData.kuvaSources;
    if (Blank(sources)) return;
  }

  private AddMarketSources(sourceData: any, result: string[]) {
  }

  private AddNightwingSources(sourceData: any, result: string[]) {
  }

  private AddQuestSources(sourceData: any, result: string[]) {
  }

  private AddSabotageMissionSources(sourceData: any, result: string[]) {
  }

  private AddSanctuaryOnslaughtEliteSources(sourceData: any, result: string[]) {
  }
  
  private AddSanctuaryOnslaughtSources(sourceData: any, result: string[]) {
  }
  
  private AddSpyMissionSources(sourceData: any, result: string[]) {
  }

  private AddSurvivalMissionSources(sourceData: any, result: string[]) {
  }

  private AddSyndicateSources(sourceData: any, result: string[]) {
  }

  private AddVoidFissureMissionSources(sourceData: any, result: string[]) {
  }
  
  private AddVoidRelicSources(sourceData: any, result: string[]) {
    const sources: any[] = sourceData.voidRelicSources;
    if (Blank(sources)) return;
    sources.forEach(source => {
      result.push(`<p>Drops from relic: <b>${source.relicName}</b> (${source.rarity})</p>`);
    });
  }
}

function Blank(value: any[]) {
  return value === undefined || value.length === 0;
}
