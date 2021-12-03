import { stringify } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { CollectibleService } from 'src/app/_services';
import { collectibleCategories, Collectible } from '../../../_interfaces';

@Component({
  selector: 'app-modify-collectible',
  templateUrl: './modify-collectible.component.html',
  styleUrls: ['./modify-collectible.component.scss']
})
export class ModifyCollectibleComponent implements OnInit {
  public existingNameControl = new FormControl('');
  public newNameControl = new FormControl('');
  public categoryControl = new FormControl('');
  public categories: string[] = [];

  constructor(private _collectibleService: CollectibleService) { }

  ngOnInit(): void {
    for (const category in collectibleCategories) {
      this.categories.push(category);
    }
    this.categoryControl.setValue(this.categories[0]);
  }

  public submit(): void {
    var oldName = this.existingNameControl.value;
    var newName = this.newNameControl.value;
    if (newName == null || newName == '') newName = oldName;
    var collectible: Collectible = {
      name: newName,
      category: this.categoryControl.value,
      obtained: false,
      mastered: false,
      onWishlist: false
    };
    this._collectibleService.modifyCollectible(oldName, collectible);
  }

}
