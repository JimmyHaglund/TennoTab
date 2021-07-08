import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { MessageService } from '../message.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import { environment } from '../../environments/environment';
import { Collectible, CollectibleSearchForm } from '.';

@Injectable({
  providedIn: 'root'
})
export class CollectibleService {
  private apiUrl = environment.apiUrl;
  private collectibleApiUrl = environment.apiUrl + "/collectible";


   constructor(
      private http: HttpClient,
      private messageService: MessageService) { }

  getCollectibles(): Observable<Collectible[]> {
    var searchForm: CollectibleSearchForm = {
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

      includeOwned: true,
      includeMastered: true,

      searchText: ""
    };
    return this.http.put<Collectible[]>(this.collectibleApiUrl, searchForm, {withCredentials: true})
    .pipe(catchError(this.handleError<Collectible[]>('getCollectibles,', [])));
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
