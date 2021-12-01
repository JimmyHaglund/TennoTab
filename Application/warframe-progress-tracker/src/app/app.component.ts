import { Component } from '@angular/core';
import { AuthenticationService } from './_services';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  public title = 'Warframe Progress Tracker';

  constructor(private _authenticationService: AuthenticationService) {}
  
  getUserIsAdmin():boolean {
    return this._authenticationService.getCurrentUser().isAdmin;
  }

}
