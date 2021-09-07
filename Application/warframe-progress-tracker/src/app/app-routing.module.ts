import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './_components/login';
import { RegisterComponent } from './register';
import { CollectiblesComponent, WishListComponent, DetailsComponent } from './_components';

const routes: Routes = [
  { path: 'collectibles', component: CollectiblesComponent },
  { path: '', redirectTo: '/collectibles', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'wishlist', component: WishListComponent },
  { path: 'collectible/:category/:name', component: DetailsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }