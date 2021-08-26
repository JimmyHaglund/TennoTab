import { Component, OnInit } from '@angular/core';
import { CollectibleService } from '../collectible.service';
import { Collectible, CollectibleSearchForm } from '..';

@Component({
  selector: 'app-wish-list',
  templateUrl: './wish-list.component.html',
  styleUrls: ['./wish-list.component.scss']
})
export class WishListComponent implements OnInit {
  public collectibles: Collectible[] = [];
  
  private _searchForm: CollectibleSearchForm = {
    includeFrames: true,
    includePrimaryWeapons: true,
    includeSecondaryWeapons: true,
    includeMeleeWeapons: true,
    includePets: true,
    includeRoboWeapons: true,
    includeOperatorAmps: true,
    includeArchwings: true,
    includeArchGuns: true,
    includeArchMeleeWeapons: true,

    onlyOnWishlist: true,
    includeOwned: true,
    includeMastered: true,
    searchText: "" 
  };
  constructor(private collectibleService: CollectibleService) { }
  
  ngOnInit(): void {
    this.getCollectibles();
  }

  private getCollectibles() {
    this.collectibleService.getCollectibles(this._searchForm)
      .subscribe(collectibles => this.collectibles = collectibles);
  }

}
