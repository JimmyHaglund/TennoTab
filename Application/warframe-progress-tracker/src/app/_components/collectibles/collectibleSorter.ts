import {Collectible} from '../../_interfaces';

export class CollectibleSorter {
   
   public sortingMethod!: (collectibles:Collectible[])=>void;
   
   public sort(collectibles: Collectible[]):void {
      if (this.sortingMethod === undefined) return;
      this.sortingMethod(collectibles);
   }

   private charsOnlyUpperCase(value: string) : string {
      const nonAlphaNumeric = /\W/;
      let match = value.toUpperCase().replace(nonAlphaNumeric, '');
  
      return match === null ? "" : match;
    }
}