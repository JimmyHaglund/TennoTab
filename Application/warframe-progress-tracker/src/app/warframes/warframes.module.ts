import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from '../app-routing.module';
import { FormsModule } from '@angular/forms';

import { FramesComponent } from './frames/frames.component';
import { FrameDetailComponent } from './frame-detail/frame-detail.component';
import { FrameSearchComponent } from './frame-search/frame-search.component';

@NgModule({
  imports: [
    CommonModule,
    AppRoutingModule,
    FormsModule
  ],
  declarations: [
    FrameSearchComponent,
    FramesComponent,
    FrameDetailComponent
  ],
  exports: [
    FrameSearchComponent,
    FramesComponent,
    FrameDetailComponent
  ]
})
export class WarframesModule { }
