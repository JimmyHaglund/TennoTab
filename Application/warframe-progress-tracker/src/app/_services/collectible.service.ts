import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { MessageService } from '../message.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import { environment } from '../../environments/environment';
import { Collectible, CollectibleSearchForm } from '../_interfaces';

@Injectable({
  providedIn: 'root'
})
export class CollectibleService {
  private apiUrl = environment.apiUrl;
  private collectibleApiUrlGet = environment.apiUrl + "/collectible/get";
  private collectibleApiGetWithName = environment.apiUrl + "/collectible/getwithname";
  private collectibleApiSet = environment.apiUrl + "/collectible/set";
  constructor(
    private http: HttpClient,
    private messageService: MessageService) { }
    private _defaultSearchForm: CollectibleSearchForm = {
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

      onlyOnWishlist: false,
      includeOwned: true,
      includeMastered: true,
      searchText: "" 
    };

  getCollectibles(searchForm: CollectibleSearchForm = this._defaultSearchForm
    ): Observable<Collectible[]> {
    return this.http.put<Collectible[]>(this.collectibleApiUrlGet, searchForm, { withCredentials: true })
      .pipe(catchError(this.handleError<Collectible[]>('getCollectibles,', [])));
  }

  getCollectible(category: string, name: string): Observable<Collectible> {
    let info = { category: category, name: name };
    return this.http.put<Collectible>(
      this.collectibleApiGetWithName,
      info, { withCredentials: true });
  }

  updateCollectible(collectible: Collectible): Observable<Collectible> {
    return this.http.put<Collectible>(
      this.collectibleApiSet, collectible, { withCredentials: true })
      .pipe(tap(() =>
        this.log(`updated userCollectible:${collectible.name}`)),
        catchError(this.handleError<Collectible>('upgradeCollectibleRank')));
  }

  addToWishlist(collectible: Collectible): Observable<Collectible> {
    throw "add to wish list not implemented";
  }

  removeFromWishlist(collectible: Collectible): Observable<Collectible> {
    throw "remove from wish list not implemented";
  }

  
  private log(message: string) {
    this.messageService.add(`FrameService: ${message}`);
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      console.error(error); // log to console instead
      this.log(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }
}
