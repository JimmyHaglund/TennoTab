export interface Gun {
   id: number;
   masteryRequired: number;
   type: string;
   primary: boolean;
   name: string;

   ammo: string;
   trigger: string;
   noise: number;
   roundsPerSecond: number;
   accuracy: number;
   magazine: number;
   maxAmmo: number;
   reloadSeconds: number;
   disposition: number;

   attacks: object[];

   polarities: string;
   exilusPolarity: string;
}