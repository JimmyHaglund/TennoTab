import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { MessageService } from '../message.service';
import { environment } from 'src/environments/environment';
import { catchError } from 'rxjs/operators';

interface IBlueprintResource {
  resultName: string;
  resultCategory: string;
  componentName: string;
  componentCategory: string;
  componentCount: number;
}

interface IResource {
  id: number;
  name: string;
  amount: number;
}

@Injectable({
  providedIn: 'root'
})

export class BlueprintService {
  private _apiAddress:string = environment.apiUrl + "/blueprint";

  constructor(
    private http: HttpClient,
    private messageService: MessageService) { }

  
    
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

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      console.error(error); // log to console instead
      this.log(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }

  private log(message: string) {
    this.messageService.add(`FrameService: ${message}`);
  }
}
