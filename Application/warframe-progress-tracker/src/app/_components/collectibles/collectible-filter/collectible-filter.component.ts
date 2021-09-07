import { Component, Input, OnInit } from '@angular/core';
import { Action } from '../../../_tools';
import { collectibleCategories, obtainedState } from '../../../_interfaces';
import { CollectibleFilter } from '../collectibleFilter';
import { CollectibleFilterState } from '../collectibleFilterState';
import { DisplayedCategories } from '../displayedCategories';

@Component({
  selector: 'app-collectible-filter',
  templateUrl: './collectible-filter.component.html',
  styleUrls: ['./collectible-filter.component.scss']
})
export class CollectibleFilterComponent implements OnInit {
  @Input() public onUpdate!: Action;
  private _filterState: CollectibleFilterState = {
    filterText: "",
    allowedObtainedState: obtainedState.NotObtained,
    includedCategories: {}
  };

  constructor() { }

  public ngOnInit(): void {
    this.initialiseShownCategories();
  }

  public toggleShowCategory(categoryName: string): void {
    let shownCategories = this._filterState.includedCategories;
    shownCategories[categoryName] = !shownCategories[categoryName];
    this.update();
  }

  public setFilterText(value: string): void {
    this._filterState.filterText = value;
    this.update();
  }

  private update():void {
    
  }

  private initialiseShownCategories() {
    for (let key in collectibleCategories) {
      let category = collectibleCategories[key]
      this._filterState.includedCategories[category] = true;
    }
  }

}
