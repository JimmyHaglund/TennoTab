import { Component, OnInit } from '@angular/core';
import { Gun } from '../gun';
import { GunService } from '../gun.service';

@Component({
  selector: 'app-secondary-weapons-list',
  templateUrl: './secondary-weapons-list.component.html',
  styleUrls: ['./secondary-weapons-list.component.scss']
})
export class SecondaryWeaponsListComponent implements OnInit {
  weapons: Gun[] = [];

  constructor(private gunService: GunService) { }

  ngOnInit(): void {
    this.loadWeapons();
  }

  private loadWeapons(): void {
    this.gunService.getSecondaryWeapons()
      .subscribe(guns => this.weapons = guns);
  }
}