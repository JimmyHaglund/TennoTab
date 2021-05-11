export interface MeleeWeapon {
   id: number;
   name: string;
   masteryRequired: number;
   type: string;

   attackSpeed: number;
   rangeMetres: number;
   comboSeconds: number;
   blockDegrees: number;
   followThrough: number;
   disposition: number;

   attacks: object[];

   augments: number[];
   polarities: string;
   stancePolarity: string;
   stances: number[];
}