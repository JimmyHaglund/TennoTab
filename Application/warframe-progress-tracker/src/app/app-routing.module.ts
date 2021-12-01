import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent, RegisterComponent } from './_components';
import { CollectiblesComponent, WishListComponent, DetailsComponent } from './_components';
import { AdminComponent, CreateCollectibleComponent, UsersComponent } from './_components/admin';

const routes: Routes = [
  { path: 'collectibles', component: CollectiblesComponent },
  { path: '', redirectTo: '/collectibles', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'wishlist', component: WishListComponent },
  { path: 'collectible/:name', component: DetailsComponent },
  { path: 'admin', component: AdminComponent },
  { path: 'admin/createcollectible', component: CreateCollectibleComponent },
  { path: 'admin/users', component: UsersComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }