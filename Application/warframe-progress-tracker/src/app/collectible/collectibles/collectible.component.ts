import { Component, OnInit } from '@angular/core';
import { Collectible, CollectibleSearchForm, CollectibleService } from '..';

@Component({
  selector: 'app-collectible',
  templateUrl: './collectible.component.html',
  styleUrls: ['./collectible.component.scss']
})
export class CollectibleComponent implements OnInit {
  collectibles: Collectible[] = [];
  
  constructor(private collectibleService: CollectibleService) { }

  ngOnInit(): void {
    this.getCollectibles();
  }

  private getCollectibles() {
    this.collectibleService.getCollectibles()
      .subscribe(collectibles => this.collectibles = collectibles);
  }

  public collectedValue(collectible: Collectible ): string {
    return !collectible.obtained ? "Not obtained" :
      collectible.mastered ? "Mastered" : "Obtained";
  }

}