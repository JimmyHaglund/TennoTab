import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { HttpClientInMemoryWebApiModule } from 'angular-in-memory-web-api';
import { InMemoryDataService } from './in-memory-data.service';

import { AppRoutingModule } from './app-routing.module';
import { WarframesModule } from './warframes/warframes.module';

import { AppComponent } from './app.component';
import { MessagesComponent } from './messages/messages.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { GunsModule } from './guns/guns.module';
import { MeleeWeaponModule} from './melee-weapon/melee-weapon.module';
import { LoginComponent } from './login/login.component';

@NgModule({
   declarations: [
      AppComponent,
      MessagesComponent,
      DashboardComponent,
      LoginComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      FormsModule,
      HttpClientModule,
      WarframesModule,
      GunsModule,
      MeleeWeaponModule,
      // The HttpClientInMemoryWebApiModule module intercepts HTTP requests
      // and returns simulated server responses.
      // Remove it when a real server is ready to receive requests.
      HttpClientInMemoryWebApiModule.forRoot(
         InMemoryDataService, { dataEncapsulation: false }
      )
   ],
   providers: [],
   bootstrap: [AppComponent]
})
export class AppModule { }
