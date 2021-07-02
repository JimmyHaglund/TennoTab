import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, pipe } from 'rxjs';
import { map, tap } from 'rxjs/operators';
import { environment } from '../../environments/environment';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
   public currentUser: any;
   private authenticateUrl = environment.apiUrl + "/user";
   private currentUserSubject: any;
   private httpOptions:object = {
      headers: new HttpHeaders({
         'Content-Type': 'application/json',
         Authorization: ''
      })
   };

   constructor(private http: HttpClient) {
      let storedCurrentUser = localStorage.getItem('currentUser');
      if (storedCurrentUser != null) {
         let currentUser = new BehaviorSubject<any>(JSON.parse(storedCurrentUser));
         if (currentUser != null) this.currentUserSubject = currentUser;
         this.currentUser = this.currentUserSubject.asObservable();
      }
   }

   public login(userName: string, password: string): void {
      var url = environment.apiUrl + "/user/login";
      this.http.post(url, { userName, password }, {observe: 'response' })
      .subscribe(response => {
         console.log("Response");
         console.log(response);
         console.log("Headers via map")
         let keys = response.headers.keys();
         keys.map(key => console.log(`${key}: ${response.headers.get(key)}`));
         console.log("Headers get('set-cookie')");
         console.log(response.headers.get('Set-Cookie'));
      });
      /*
         .pipe(map(response => {
               console.log(`${response}`)
               console.log(response.headers);
            }
            )).subscribe(response => console.log(response));
            /*map(user => {
            console.log(user);
            localStorage.setItem('currentUser', JSON.stringify(user));
            this.currentUserSubject.next(user);
         }), tap(response => { 
            console.log(response.headers);
         }));/**/
   }

   public register(userName: string, password: string): Observable<any> {
      console.log("Registering", userName);
      var url = environment.apiUrl + "/user/register";
      return this.http.post<string>(url, {userName, password})
      .pipe(map(user => {
         console.log(user);
         localStorage.setItem('currentUser', JSON.stringify(user));
         this.currentUserSubject.next(user);
         return user;
      }));
   }
}
