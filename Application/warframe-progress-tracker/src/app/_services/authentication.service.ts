import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, pipe } from 'rxjs';
import { map, tap } from 'rxjs/operators';
import { environment } from '../../environments/environment';
import { UserInfo } from '../_interfaces';

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

   public login(userName: string, password: string): Observable<UserInfo> {
      var url = environment.apiUrl + "user/login";
      return this.http.post<UserInfo>(url, { userName, password }, {withCredentials: true})
      .pipe(map(user => {
         localStorage.setItem('currentUser', JSON.stringify(user));
         this.currentUserSubject.next(user);
         return user;
      }));
   }

   public register(userName: string, password: string): Observable<UserInfo> {
      console.log("Registering", userName);
      var url = environment.apiUrl + "user/register";
      return this.http.post<UserInfo>(url, {userName, password}, {withCredentials: true})
      .pipe(map(user => {
         localStorage.setItem('currentUser', JSON.stringify(user));
         this.currentUserSubject.next(user);
         return user;
      }));
   }

   public getAllUsers(): Observable<UserInfo[]> {
      var url = environment.apiUrl + 'user/getall';
      var headerSettings = { withCredentials: true };
      return this.http.get<UserInfo[]>(url, headerSettings);
   }

   public set(userInfo: UserInfo): Observable<UserInfo> {
      var url = environment.apiUrl + 'user/set';
      var headerSettings = { withCredentials: true };
      return this.http.post<UserInfo>(url, userInfo, headerSettings);
   }

   public getCurrentUser(): UserInfo {
      var userString = localStorage.getItem('currentUser') ?? '';
      if (userString == '') return { name: 'Null', isAdmin: false }
      return JSON.parse(userString) as UserInfo;
   }

   
}
