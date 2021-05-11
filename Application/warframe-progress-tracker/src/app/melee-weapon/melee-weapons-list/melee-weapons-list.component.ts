import { Component, OnInit } from '@angular/core';
import { MeleeWeapon } from '../melee-weapon';
import { MeleeService } from '../melee.service';

@Component({
   selector: 'app-melee-weapons-list',
   templateUrl: './melee-weapons-list.component.html',
   styleUrls: ['./melee-weapons-list.component.scss']
})
export class MeleeWeaponsListComponent implements OnInit {
   weapons: MeleeWeapon[] = [];

   constructor(private meleeService: MeleeService) { }

   ngOnInit(): void {
      this.loadWeapons();
   }

   private loadWeapons(): void {
      this.meleeService.getWeapons()
         .subscribe(weapons => this.weapons = weapons);
   }
}
