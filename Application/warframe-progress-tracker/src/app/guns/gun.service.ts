import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Gun } from './gun';
import { MessageService } from '../message.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';

@Injectable({
   providedIn: 'root'
})
export class GunService {
   httpOptions = {
      headers: new HttpHeaders({ 'Content-Type': 'application/json' })
   };
   private gunsUrl = 'api/guns';

   constructor(
      private http: HttpClient,
      private messageService: MessageService
   ) { }

   getGuns(): Observable<Gun[]> {
      return this.http.get<Gun[]>(this.gunsUrl).
      pipe(
         catchError(this.handleError<Gun[]>('getGuns', []))
      );
   }

   private handleError<T>(operation = 'operation', result?: T) {
      return (error: any): Observable<T> => {
   
      console.error(error);
      this.log(`${operation} failed: ${error.message}`);
      return of(result as T);
      };
   }

   private log(message: string) {
      this.messageService.add(`GunService: ${message}`);
   }
}