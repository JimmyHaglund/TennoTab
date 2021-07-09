export interface Collectible {
   name: string,
   category: string,
   detailsLink: string,
   mastered: boolean,
   obtained: boolean
};

export const collectibleCategories = {
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
}