import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { MeleeWeapon } from './melee-weapon';
import { MessageService } from '../message.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

@Injectable({
   providedIn: 'root'
})
export class MeleeService {
   httpOptions = {
      headers: new HttpHeaders({ 'Content-Type': 'application/json' })
   };
   private apiUrl = environment.apiUrl;

   constructor(
      private http: HttpClient,
      private messageService: MessageService
   ) { }

   getWeapons(): Observable<MeleeWeapon[]> {
      return this.http.get<MeleeWeapon[]>(this.apiUrl + "/meleeweapon").
      pipe(
         catchError(this.handleError<MeleeWeapon[]>('getWeapons', []))
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
      this.messageService.add(`MeleeService: ${message}`);
   }
}
