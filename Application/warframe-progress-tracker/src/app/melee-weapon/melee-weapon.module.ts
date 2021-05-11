import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MeleeWeaponsListComponent } from './melee-weapons-list/melee-weapons-list.component';

@NgModule({
  declarations: [
    MeleeWeaponsListComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    MeleeWeaponsListComponent
  ]
})
export class MeleeWeaponModule { }
