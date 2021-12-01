import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { environment } from '../../environments/environment';
import { Collectible, CollectibleSearchForm } from '../_interfaces';

@Injectable({
  providedIn: 'root'
})

export class CollectibleService {
  private _apiAddress = environment.apiUrl + 'collectible/'
  private _endpoints = {
    all: this._apiAddress + 'all/',
    get: this._apiAddress + 'get',
    put: this._apiAddress + 'put',
    create: this._apiAddress + 'create'
  };

  constructor(private http: HttpClient) { }

  getAllCollectibles(): Observable<Collectible[]> {
    let url = this._endpoints.all;
    return this.http.get<Collectible[]>(url, { withCredentials: true })
      .pipe(catchError(this.handleError<Collectible[]>('getAllCollectibles,', [])));
  }

  getCollectibles(searchForm: CollectibleSearchForm): Observable<Collectible[]> {
    let url = this._endpoints.get;
    let header = { withCredentials: true }
    return this.http.put<Collectible[]>(url, searchForm, header)
      .pipe(catchError(this.handleError<Collectible[]>('getCollectibles', [])));
  }

  getCollectible(collectibleName: string): Observable<Collectible> {
    let url = this.buildUrlGetSingle(collectibleName);
    let header = { withCredentials: true }
    return this.http.get<Collectible>(url, header)
      .pipe(catchError(this.handleError<Collectible>('getCollectible')));
  }

  updateCollectible(collectible: Collectible): Observable<Collectible> {
    let url = this._endpoints.put;
    let header = { withCredentials: true };
    return this.http.put<Collectible>(url, collectible, header)
      .pipe(tap(() =>
        this.log(`updated userCollectible:${collectible.name}`)),
        catchError(this.handleError<Collectible>('upgradeCollectibleRank')));
  }

  createCollectible(collectible: Collectible): void {
    let url = this._endpoints.create;
    let header = { withCredentials: true };
    this.http.post<void>(url, collectible, header)
    .pipe(tap(() => 
      this.log(`created collectible: ${collectible.name}.`)
    ))
    .subscribe();
  }

  private buildUrlGetSingle(collectibleName: string): string {
    return this._endpoints.get + '/' + collectibleName;
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      this.log(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }

  private log(message: string) {
    console.log(message)
  }
}
