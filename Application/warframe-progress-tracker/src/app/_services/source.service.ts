import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { first } from 'rxjs/operators';
import { catchError, map, tap } from 'rxjs/operators';
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
  public build(sources: any): string[] {
    let result: any[] = [];
    this.AddAssassinationMissionSources(sources.assassinationMissionSources, result);
    this.AddBaroKiteerSources(sources.baroKiteerSources, result);
    this.AddEnemyDropSources(sources.enemyItemDropSources, result);
    return result;
  }

  private AddAssassinationMissionSources(sources: any[], result: any[]) {
    if (Blank(sources)) return;
    sources.forEach(source => {
      result.push(`<p>Rewarded from <b>${source.mission} assassination</b> (${source.dropChance}% chance)</p>`);
    });
  }

  private AddBaroKiteerSources(sources: any[], result: any[]) {
    if (Blank(sources)) return;
    sources.forEach(source => {
      let credits = source.creditsCost;
      let ducats = source.ducatsCost;
      let date:string = source.saleDate;
      date = date.split('T')[0];
      result.push(`<p>Could be bought from <b>Baro Ki'teer</b> at ${date}` +
        ` for <b>${credits}</b> credits and <b>${ducats}</b> ducats</p>`);
    });
  }

  private AddEnemyDropSources(sources: any[], result: string[]) {
    if (Blank(sources)) return;
    sources.forEach(source => {
      result.push(`<p>Drops from <b>${source.enemyName}</b> (${source.dropChance}% chance)</p>`);
    });
  }
 }
 
function Blank(value: any[]) {
  return value === undefined || value.length === 0;
}
