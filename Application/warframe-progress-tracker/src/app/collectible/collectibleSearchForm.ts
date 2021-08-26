export interface CollectibleSearchForm {
   includeFrames: boolean,
   includePrimaryWeapons: boolean,
   includeSecondaryWeapons: boolean,
   includeMeleeWeapons: boolean,
   includePets: boolean
   includeRoboWeapons: boolean,
   includeOperatorAmps: boolean,
   includeArchwings: boolean,
   includeArchGuns: boolean,
   includeArchMeleeWeapons: boolean,

   onlyOnWishlist: boolean,
   includeOwned: boolean,
   includeMastered: boolean,

   searchText: string
}