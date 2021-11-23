import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { catchError } from 'rxjs/operators';
import { Blueprint, BlueprintComponentStack } from '../_interfaces';

@Injectable({
  providedIn: 'root'
})

export class BlueprintService {
  private _apiAddress: string = environment.apiUrl + 'blueprint/';
  private _endpoints = {
    get: 'get/',
    totalresourcecost: 'totalresourcecost/'
  };

  constructor(private http: HttpClient) { }

  getBlueprint(resultName: string): Observable<Blueprint> {
    let url = this.buildUrlGet(resultName);
    return this.http.get<Blueprint[]>(url)
      .pipe(catchError(this.handleError<Blueprint>('getBlueprint')));
  }

  getTotalResourceCost(resultName: string): Observable<BlueprintComponentStack[]> {
    let url = this.buildUrlTotalResourceCost(resultName);
    return this.http.get<BlueprintComponentStack[]>(url)
      .pipe(catchError(this.handleError<BlueprintComponentStack[]>('getTotalResourceCost')));
  }

  private buildUrlGet(resultName: string): string {
    let result = this._apiAddress + this._endpoints.get;
    result += resultName;
    return result;
  }

  private buildUrlTotalResourceCost(resultName: string): string {
    let result = this._apiAddress + this._endpoints.totalresourcecost;
    result += resultName;
    return result;
  }

  private handleError<T>(operation = 'operation', result?: T): any {
    return (error: any): Observable<T> => {
      console.error(error);
      this.log(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }

  private log(message: string): void {
    console.log(message);
  }
}
