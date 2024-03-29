export interface CollectibleCategories {
   Warframe: string;
   PrimaryWeapon: string;
   SecondaryWeapon: string;
   MeleeWeapon: string;
   Amp: string;
   Pet: string;
   RoboGun: string;
   Archwing: string;
   ArchGun: string;
   ArchMelee: string;
   [key:string]: string;
}

export const collectibleCategories: CollectibleCategories = {
   Warframe: "Warframe",
   PrimaryWeapon: "PrimaryWeapon",
   SecondaryWeapon: "SecondaryWeapon",
   MeleeWeapon: "MeleeWeapon",
   Amp: "AmpPrism",
   Pet: "Companion",
   RoboGun: "RoboticWeapon",
   Archwing: "ArchWing",
   ArchGun: "ArchGun",
   ArchMelee: "ArchMelee"
};

export const collectibleCategoryKeys = {
   Warframe: "Warframe",
   PrimaryWeapon: "PrimaryWeapon",
   SecondaryWeapon: "SecondaryWeapon",
   MeleeWeapon: "MeleeWeapon",
   Amp: "Amp",
   Pet: "Pet",
   RoboGun: "RoboGun",
   Archwing: "Archwing",
   ArchGun: "ArchGun",
   ArchMelee: "ArchMelee"
};