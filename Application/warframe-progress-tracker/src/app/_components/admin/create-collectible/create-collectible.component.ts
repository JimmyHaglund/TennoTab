import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { CollectibleService } from 'src/app/_services';
import { collectibleCategories, Collectible } from '../../../_interfaces';

@Component({
  selector: 'app-create-collectible',
  templateUrl: './create-collectible.component.html',
  styleUrls: ['./create-collectible.component.scss']
})
export class CreateCollectibleComponent implements OnInit {
  public nameControl = new FormControl('');
  public categoryControl = new FormControl('');
  public categories: string[] = [];

  constructor(private _collectibleService: CollectibleService) { }

  ngOnInit(): void {
    for (const category in collectibleCategories) {
      this.categories.push(category);
    }
    console.log(this.categories);

  }

  public submit(): void {
    var collectible: Collectible = {
      name: this.nameControl.value,
      category: this.categoryControl.value,
      obtained: false,
      mastered: false,
      onWishlist: false
    };
    this._collectibleService.createCollectible(collectible);
  }
}
