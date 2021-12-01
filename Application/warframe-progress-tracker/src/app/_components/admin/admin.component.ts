import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '../../_services';
import { UserInfo } from '../../_interfaces';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.scss']
})
export class AdminComponent implements OnInit {
  private _userInfos: UserInfo[] = [];

  public get UserInfos(): UserInfo[] { return this._userInfos }

  constructor(private _authenticationService: AuthenticationService) { }

  ngOnInit(): void {
    this.FetchUserInfos();
  }

  public toggleAdmin(userName: string): void {
    console.log("Toggling admin for",userName);
    
    let targetUser = this.GetUser(userName);
    if (targetUser.name == "") return;
    targetUser.isAdmin = !targetUser.isAdmin;
    this._authenticationService.set(targetUser)
      .subscribe(user => this.SetUser(user));
  }

  private SetUser(user: UserInfo): void {
    var userName = user.name;
    for (let n = 0; n < this._userInfos.length; n++) {
      if (this._userInfos[n].name == userName) {
        this.UserInfos[n] = user;
        return;
      }
    }
  }

  private GetUser(userName: string): UserInfo {
    for (let n = 0; n < this._userInfos.length; n++) {
      let user = this._userInfos[n];
      if (user.name == userName) return user;
    }
    return { name: "", isAdmin: false };
  }

  private FetchUserInfos(): void {
    this._authenticationService.getAllUsers()
      .subscribe(userInfos => this._userInfos = userInfos);
  }
}