import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Frame, UserFrame } from './frame';
import { MessageService } from '../message.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CollectibleService {

  private apiUrl = environment.apiUrl;
   private framesUrl = environment.apiUrl + "/frame";  // URL to web api


   constructor(
      private http: HttpClient,
      private messageService: MessageService) { }

  getCollectibles(): Observable<Collectible[]> {
    return null;
  }
}
