import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PrimaryWeaponsListComponent } from './primary-weapons-list/primary-weapons-list.component';
import { SecondaryWeaponsListComponent } from './secondary-weapons-list/secondary-weapons-list.component';

@NgModule({
  declarations: [
    PrimaryWeaponsListComponent,
    SecondaryWeaponsListComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    PrimaryWeaponsListComponent,
    SecondaryWeaponsListComponent
  ]
})
export class GunsModule { }
