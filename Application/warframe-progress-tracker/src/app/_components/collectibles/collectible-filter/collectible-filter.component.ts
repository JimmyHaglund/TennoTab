import { Component, Input, OnInit } from '@angular/core';
import { Action } from '../../../_tools';
import { collectibleCategories, obtainedState } from '../../../_interfaces';
import { CollectibleFilter, CollectibleFilterState } from '../collectibleFilter';
import { DisplayedCategories } from '../displayedCategories';

@Component({
  selector: 'app-collectible-filter',
  templateUrl: './collectible-filter.component.html',
  styleUrls: ['./collectible-filter.component.scss']
})
export class CollectibleFilterComponent implements OnInit {
  @Input() public onUpdate!: Action;
  @Input() public filter!: CollectibleFilter;

  private _filterState: CollectibleFilterState = {
    filterText: "",
    allowedObtainedState: obtainedState.NotObtained,
    includedCategories: {}
  };

  constructor() { }

  public ngOnInit(): void {
    this.initialiseShownCategories();
  }

  private update():void {
    this.filter.filter = this._filterState;
    // this.onUpdate.invoke(filter);
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

  private initialiseShownCategories() {
    for (let key in collectibleCategories) {
      let category = collectibleCategories[key]
      this._filterState.includedCategories[category] = true;
    }
    this.update();
  }

  public setObtainedFilterToAny(): void {
    this._filterState.allowedObtainedState = obtainedState.Any;
  }

  public setObtainedFilterToNonObtained(): void {
    this._filterState.allowedObtainedState = obtainedState.NotObtained;
  }

  public setObtainedFilterToObtained(): void {
    this._filterState.allowedObtainedState = obtainedState.Obtained;
  }

  public setObtainedFilterToMastered(): void {
    this._filterState.allowedObtainedState = obtainedState.Mastered;
  }
}