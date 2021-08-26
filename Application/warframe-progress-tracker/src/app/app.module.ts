import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
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
import { RegisterComponent } from './register/register.component';
import { CollectibleComponent } from './collectible';
import { CollectibleCardComponent } from './collectible/collectible-card/collectible-card.component';
import { WishListComponent } from './collectible/wish-list/wish-list.component';
import { ItemCostCardComponent } from './collectible/item-cost-card/item-cost-card.component';

@NgModule({
   declarations: [
      AppComponent,
      MessagesComponent,
      DashboardComponent,
      LoginComponent,
      RegisterComponent,
      CollectibleComponent,
      CollectibleCardComponent,
      WishListComponent,
      ItemCostCardComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      FormsModule,
      ReactiveFormsModule,
      HttpClientModule,
      WarframesModule,
      GunsModule,
      MeleeWeaponModule,
      // The HttpClientInMemoryWebApiModule module intercepts HTTP requests
      // and returns simulated server responses.
      // Remove it when a real server is ready to receive requests.
      /*
      HttpClientInMemoryWebApiModule.forRoot(
         InMemoryDataService, { dataEncapsulation: false }
      )*/
   ],
   providers: [],
   bootstrap: [AppComponent]
})
export class AppModule { }
