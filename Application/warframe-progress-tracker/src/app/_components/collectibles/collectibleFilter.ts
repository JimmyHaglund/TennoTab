import { CollectibleFilterState } from './collectibleFilterState';
import { Collectible, collectibleCategories } from '../../_interfaces';
import {DisplayedCategories } from './displayedCategories';

export class CollectibleFilter {
   constructor(private _filter: CollectibleFilterState) { }

   public shouldShowCollectible(collectible: Collectible): boolean {
      const filter = this._filter;
      return this.shouldShowCategory(collectible.category, filter.includedCategories) 
         && this.passesObtainedFilter(collectible, filter.allowedObtainedState)
         && this.containsString(collectible, filter.filterText)
   }

   private shouldShowCategory(category: string, shownCategories: DisplayedCategories): boolean {
      return shownCategories[category];
   }

   private passesObtainedFilter(collectible: Collectible, obtainedState: string): boolean {
      return obtainedState === 'All' || 
        collectible.obtained && !collectible.mastered && obtainedState === 'NonMastered' ||
        !collectible.obtained && obtainedState === 'NonObtained' ||
        collectible.mastered && obtainedState === 'Mastered';
    }

    private containsString(collectible: Collectible, value: string): boolean {
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