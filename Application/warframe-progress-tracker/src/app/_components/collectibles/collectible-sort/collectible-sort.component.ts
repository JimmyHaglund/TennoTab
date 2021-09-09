import { Component, Input, OnInit } from '@angular/core';
import { Collectible } from '../../../_interfaces';
import { CollectibleSorter } from '../collectibleSorter';

@Component({
  selector: 'app-collectible-sort',
  templateUrl: './collectible-sort.component.html',
  styleUrls: ['./collectible-sort.component.scss']
})
export class CollectibleSortComponent implements OnInit {
  @Input() public sorter!: CollectibleSorter;

  public sortingMethods = {
    nameAscending: "Name ascending",
    nameDescending: "Name descending",
    categoryAscending: "Category ascending",
    categoryDescending: "Category descending"
  };

  private _sortingMethod: string = this.sortingMethods.nameAscending;
  constructor() { }

  ngOnInit(): void {
    this.setSortingMethod(this._sortingMethod);
  }

  public setSortingMethod(method: string): void {
    if (this.sorter === undefined) return;
    this._sortingMethod = method;
    switch (method) {
      case this.sortingMethods.nameAscending:
        this.sorter.sortingMethod = this.sortByNameAscending;
        break;
      case this.sortingMethods.nameDescending:
        this.sorter.sortingMethod = this.sortByNameDescending;
        break;
      case this.sortingMethods.categoryDescending:
        this.sorter.sortingMethod = this.sortByCategoryDescending;
        break;
      default:
        this.sorter.sortingMethod = this.sortByCategoryAscending;
        break;
    };
  }

  public getSortingValue(method:string):boolean {
    return this._sortingMethod === method;
  }

  private sortByNameAscending(collectibles: Collectible[]): void {
    collectibles.sort((collectibleA, collectibleB) => {
      const nameA = collectibleA.name;
      const nameB = collectibleB.name;
      return nameA < nameB ? -1 : nameA > nameB ? 1 : 0;
    });
  }

  private sortByNameDescending(collectibles: Collectible[]): void {
    collectibles.sort((collectibleA, collectibleB) => {
      const nameA = collectibleA.name;
      const nameB = collectibleB.name;
      return nameA > nameB ? -1 : nameA < nameB ? 1 : 0;
    });
  }

  private sortByCategoryAscending(collectibles: Collectible[]): void {
    const charsOnlyUpperCase = this.charsOnlyUpperCase;
    collectibles.sort((collectibleA, collectibleB) => {
      const categoryA = charsOnlyUpperCase(collectibleA.category);
      const categoryB = charsOnlyUpperCase(collectibleB.category);
      const nameA = collectibleA.name;
      const nameB = collectibleB.name;
      return categoryA < categoryB ? -1 : categoryA > categoryB ? 1 :
        nameA < nameB ? -1 : nameA > nameB ? 1 : 0;
    });
  }

  private sortByCategoryDescending(collectibles: Collectible[]): void {
    const charsOnlyUpperCase = this.charsOnlyUpperCase;
    collectibles.sort((collectibleA, collectibleB) => {
      const categoryA = charsOnlyUpperCase(collectibleA.category);
      const categoryB = charsOnlyUpperCase(collectibleB.category);
      const nameA = collectibleA.name;
      const nameB = collectibleB.name;
      return categoryA > categoryB ? -1 : categoryA < categoryB ? 1 :
        nameA < nameB ? -1 : nameA > nameB ? 1 : 0;
    });
  }

  private charsOnlyUpperCase(value: string) : string {
    const nonAlphaNumeric = /\W/;
    let match = value.toUpperCase().replace(nonAlphaNumeric, '');

    return match === null ? "" : match;
  }
}