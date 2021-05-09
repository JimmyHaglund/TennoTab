import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FramesComponent } from './frames/frames.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FrameDetailComponent } from './frame-detail/frame-detail.component';

const routes: Routes = [
  { path: 'frames', component: FramesComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'frame-details/:id', component: FrameDetailComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }