import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
   private authenticateUrl = 'api/authenticate';
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

   public login(userName: string, password: string): any {
      console.log("Login attempt: ", userName, ", ", password);
      return this.http.post<any>(`${this.authenticateUrl}`, { userName, password })
         .pipe(map(user => {
            localStorage.setItem('currentUser', JSON.stringify(user));
            this.currentUserSubject.next(user);
            return user;
         }));
   }
}
