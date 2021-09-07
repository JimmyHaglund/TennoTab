import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { MessagesComponent } from './_components/messages/messages.component';
import { LoginComponent } from './_components/login/login.component';
import { RegisterComponent } from './register/register.component';
import { CollectiblesComponent } from './_components';
import { CollectibleCardComponent } from './_components/collectibles/collectible-card/collectible-card.component';
import { WishListComponent } from './_components/wish-list/wish-list.component';
import { ItemCostCardComponent } from './_components/wish-list/item-cost-card/item-cost-card.component';
import { DetailsComponent } from './_components/details/details.component';

@NgModule({
   declarations: [
      AppComponent,
      MessagesComponent,
      LoginComponent,
      RegisterComponent,
      CollectiblesComponent,
      CollectibleCardComponent,
      WishListComponent,
      ItemCostCardComponent,
      DetailsComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      FormsModule,
      ReactiveFormsModule,
      HttpClientModule
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
