import { Component, OnInit } from '@angular/core';
import { Gun } from '../gun';
import { GunService } from '../gun.service';

@Component({
  selector: 'app-primary-weapons-list',
  templateUrl: './primary-weapons-list.component.html',
  styleUrls: ['./primary-weapons-list.component.scss']
})
export class PrimaryWeaponsListComponent implements OnInit {
  weapons: Gun[] = [];

  constructor(private gunService: GunService) { }

  ngOnInit(): void {
    this.loadWeapons();
  }

  private loadWeapons(): void {
    this.gunService.getGuns()
      .subscribe(guns => this.weapons = guns.filter(gun => gun.primary));
  }
}