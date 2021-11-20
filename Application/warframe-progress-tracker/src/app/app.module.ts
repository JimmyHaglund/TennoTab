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
import { CollectibleFilterComponent } from './_components/collectibles/collectible-filter/collectible-filter.component';
import { CollectibleSortComponent } from './_components/collectibles/collectible-sort/collectible-sort.component';
import { WishListCardComponent } from './_components/wish-list/wish-list-card/wish-list-card.component';

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
      DetailsComponent,
      CollectibleFilterComponent,
      CollectibleSortComponent,
      WishListCardComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      FormsModule,
      ReactiveFormsModule,
      HttpClientModule
   ],
   providers: [],
   bootstrap: [AppComponent]
})
export class AppModule { }
