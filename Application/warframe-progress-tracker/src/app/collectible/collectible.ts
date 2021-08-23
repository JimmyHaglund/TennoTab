export interface Collectible {
   name: string,
   category: string,
   detailsLink: string,
   mastered: boolean,
   obtained: boolean
};

export interface ICollectibleCategories {
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

export const collectibleCategories: ICollectibleCategories = {
   Warframe: "Warframe",
   PrimaryWeapon: "Primary Weapon",
   SecondaryWeapon: "Secondary Weapon",
   MeleeWeapon: "Melee Weapon",
   Amp: "Amp Prism",
   Pet: "Pet",
   RoboGun: "Robo-Gun",
   Archwing: "Archwing",
   ArchGun: "Archgun",
   ArchMelee: "Arch-Melee"
};