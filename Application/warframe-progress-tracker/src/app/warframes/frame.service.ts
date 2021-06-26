import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Frame } from './frame';
import { MessageService } from '../message.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';

/*
From: https://angular.io/tutorial/toh-pt4
When you provide the service at the root level, Angular creates a single, 
shared instance of HeroService and injects into any class that asks for it. 
Registering the provider in the @Injectable metadata also allows Angular to 
optimize an application by removing the service if it turns out not to be used after all.
/**/
@Injectable({
   providedIn: 'root'
})

export class FrameService {
   httpOptions = {
      headers: new HttpHeaders({ 'Content-Type': 'application/json' })
   };
   private framesUrl = 'api/frames';  // URL to web api
   
   constructor(
      private http: HttpClient,
      private messageService: MessageService) { }

   getFrames(): Observable<Frame[]> {
      return this.http.get<Frame[]>(this.framesUrl).
      pipe(
         catchError(this.handleError<Frame[]>('getFrames', []))
      );
      
      // Using RxJs to get mock frames
      // const frames = of(FRAMES);
      // this.messageService.add('FrameService: Fetched frames');
      // return frames;
   }

   getFrame(id: number): Observable<Frame> {
      const url = `${this.framesUrl}/${id}`;
      return this.http.get<Frame>(url).pipe(
         tap(_ => this.log(`fetched frame: ${id}`)),
         catchError(this.handleError<Frame>(`getFrame id=${id}`))
      );
   }

   /** PUT: update the hero on the server */
   updateFrame(frame: Frame): Observable<any> {
      return this.http.put(this.framesUrl, frame, this.httpOptions).pipe(
      tap(_ => this.log(`updated frame ${frame.name}`)),
      catchError(this.handleError<any>('updateFrame'))
      );
   }

   /** POST: add a new hero to the server */
   addFrame(frame: Frame): Observable<Frame> {
      return this.http.post<Frame>(this.framesUrl, frame, this.httpOptions).pipe(
      tap((newFrame: Frame) => this.log(`added new frame:${newFrame.name}`)),
      catchError(this.handleError<Frame>('addFrame'))
      );
   }

   /** DELETE: delete the hero from the server */
   deleteFrame(name: string): Observable<Frame> {
      const url = `${this.framesUrl}/${name}`;
   
      return this.http.delete<Frame>(url, this.httpOptions).pipe(
      tap(_ => this.log(`deleted frame: ${name}`)),
      catchError(this.handleError<Frame>('deletFrame'))
      );
   }

   /* GET heroes whose name contains search term */
   searchFrames(term: string): Observable<Frame[]> {
      if (!term.trim()) {
      // if not search term, return empty hero array.
      return of([]);
      }
      return this.http.get<Frame[]>(`${this.framesUrl}/?name=${term}`).pipe(
      tap(x => x.length ?
         this.log(`found frames matching "${term}"`) :
         this.log(`no frames matching "${term}"`)),
      catchError(this.handleError<Frame[]>('searchFrames', []))
      );
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
