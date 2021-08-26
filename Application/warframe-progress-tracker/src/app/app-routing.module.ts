import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FramesComponent } from './warframes/frames/frames.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FrameDetailComponent } from './warframes/frame-detail/frame-detail.component';
import { PrimaryWeaponsListComponent } from './guns/primary-weapons-list/primary-weapons-list.component';
import { SecondaryWeaponsListComponent } from './guns/secondary-weapons-list/secondary-weapons-list.component';
import { MeleeWeaponsListComponent } from './melee-weapon/melee-weapons-list/melee-weapons-list.component';
import { LoginComponent } from './login';
import { RegisterComponent } from './register';
import { CollectibleComponent } from './collectible';
import { WishListComponent } from './collectible/wish-list/wish-list.component';

const routes: Routes = [
  { path: 'frames', component: FramesComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'frame-details/:id', component: FrameDetailComponent },
  { path: 'primary-weapons', component: PrimaryWeaponsListComponent },
  { path: 'secondary-weapons', component: SecondaryWeaponsListComponent },
  { path: 'melee-weapons', component: MeleeWeaponsListComponent },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'collectible', component: CollectibleComponent },
  { path: 'wishlist', component: WishListComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }