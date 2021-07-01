import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from '../../environments/environment';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {

   private authenticateUrl = environment.apiUrl + "/user";
   private currentUserSubject: any;
   public currentUser: any;

   constructor(private http: HttpClient) {
      let storedCurrentUser = localStorage.getItem('currentUser');
      if (storedCurrentUser != null) {
         let currentUser = new BehaviorSubject<any>(JSON.parse(storedCurrentUser));
         if (currentUser != null) this.currentUserSubject = currentUser;
         this.currentUser = this.currentUserSubject.asObservable();
      }
   }

   public login(userName: string, password: string): Observable<any> {
      var url = environment.apiUrl + "/user/login";
      return this.http.post<string>(url, { userName, password })
         .pipe(map(user => {
            console.log(user);
            localStorage.setItem('currentUser', JSON.stringify(user));
            this.currentUserSubject.next(user);
            return user;
         }));
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
