import { Collectible, obtainedState } from '../../_interfaces';
import { DisplayedCategories } from './displayedCategories';

export interface CollectibleFilterState {
  filterText: string;
  allowedObtainedState: string;
  includedCategories: DisplayedCategories;
}

export class CollectibleFilter {
  private _filter: CollectibleFilterState = {
    filterText: "", allowedObtainedState: obtainedState.NotObtained, includedCategories: {}
  }

  public set filter(filter: CollectibleFilterState) { this._filter = filter }

  constructor() { }

  public shouldShowCollectible(collectible: Collectible): boolean {
    const filter = this._filter;
    return this.shouldShowCategory(collectible.category, filter.includedCategories)
      && this.passesObtainedFilter(collectible, filter.allowedObtainedState)
      && this.containsString(collectible, filter.filterText)

  }

  private shouldShowCategory(category: string, shownCategories: DisplayedCategories): boolean {
    return shownCategories[category];
  }

  private passesObtainedFilter(collectible: Collectible, allowedState: string): boolean {
    return allowedState === obtainedState.Any ||
      collectible.obtained && !collectible.mastered && allowedState === obtainedState.Obtained ||
      !collectible.obtained && allowedState === obtainedState.NotObtained ||
      collectible.mastered && allowedState === obtainedState.Mastered;
  }

  private containsString(collectible: Collectible, value: string): boolean {
    value = value.trim();
    if (value.length == 0) return true;
    let collectibleName = collectible.name.toLowerCase();
    let collectibleCategory = collectible.category.toLowerCase();
    let filter = value.toLowerCase().trim();
    const regularExpression = /,/
    let targetValues = filter.split(regularExpression);
    for (let n = 0; n < targetValues.length; n++) {
      targetValues[n] = targetValues[n].trim();
      let mustIncludes = targetValues[n].split(' ');
      let containsAll = true;
      for (let i = 0; i < mustIncludes.length; i++) {
        if (!collectibleName.includes(mustIncludes[i])
          && !collectibleCategory.includes(mustIncludes[i])) {
          containsAll = false;
          break;
        }
      }
      if (containsAll) return true;
    }
    return false;
  }
}