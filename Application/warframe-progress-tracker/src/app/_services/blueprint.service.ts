import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { MessageService } from '../message.service';
import { environment } from 'src/environments/environment';
import { catchError } from 'rxjs/operators';

export interface IBlueprintResource {
  resultName: string;
  resultCategory: string;
  componentName: string;
  componentCategory: string;
  componentCount: number;
}

export interface IResource {
  id: number;
  name: string;
  amount: number;
}

export interface ISource {
  id: number;
  itemName: string;
  itemCategory: string;
  sourceName: string;
  sourceType: string;
  value: string;
}

@Injectable({
  providedIn: 'root'
})

export class BlueprintService {
  private _apiAddress:string = environment.apiUrl + "/blueprint";

  constructor(
    private http: HttpClient,
    private messageService: MessageService) { }

  getSource(itemName: string): Observable<ISource[]> {
    let data =  { name: itemName };
    return this.http.put<ISource[]>(environment.apiUrl + "/collectible/getsource", data)
      .pipe(catchError(this.handleError<ISource[]>('getSource')));
  }
    
  getBlueprintsWithResult(resultName: string): Observable<IBlueprintResource[]> {
    let data = {ResultName: resultName};
    return this.http.put<IBlueprintResource[]>(this._apiAddress + "/components", data)
      .pipe(catchError(this.handleError<IBlueprintResource[]>('getBlueprintWithResult')));
    // results.subscribe((result => console.log(result)));
  }

  getTotalResourceCost(resultName: string): Observable<IResource[]> {
    let data = {ResultName: resultName};
    return this.http.put<IResource[]>(this._apiAddress + "/totalresourcecost", data)
      .pipe(catchError(this.handleError<IResource[]>('getTotalResourceCost')));
  }

  getComponents(resultName: string): Observable<IResource[]> {
    let data = {ResultName: resultName};
    return this.http.put<IResource[]>(this._apiAddress + "/componentcost", data)
      .pipe(catchError(this.handleError<IResource[]>('getComponents')));
  }

  private handleError<T>(operation = 'operation', result?: T): any {
    return (error: any): Observable<T> => {

      console.error(error); // log to console instead
      this.log(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }

  private log(message: string): void {
    this.messageService.add(`FrameService: ${message}`);
  }
}
