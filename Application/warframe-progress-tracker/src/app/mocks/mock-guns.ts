import { Gun } from '../guns/gun';

export const GUNS: Gun[] = [
  {
   id: 11,
   masteryRequired: 0,
   type: "Rifle",
   primary: true,
   name: "Burston",

   ammo: "Rifle",
   trigger: "Burst",
   noise: 20,
   roundsPerSecond: 7.83,
   accuracy: 25,
   magazine: 45,
   maxAmmo: 540,
   reloadSeconds: 2.0,
   disposition: 1.45,

   attacks: [],

   polarities: "V",
   exilusPolarity: "B"
},
{
  id: 12,
  masteryRequired: 6,
  type: "Rifle",
  primary: true,
  name: "Grinlock",
  trigger: "Semi",

  ammo: "Rifle",
  noise: 20,
  roundsPerSecond: 1.67,
  accuracy: 44.4,
  magazine: 9,
  maxAmmo: 540,
  reloadSeconds: 1.7,
  disposition: 1.3,

  
   attacks: [],

  polarities: "V",
  exilusPolarity: "V"
},
{
  id: 13,
  masteryRequired: 3,
  type: "Rifle",
  primary: true,
  name: "Gorgon",
  trigger: "Auto-Spool",

  ammo: "Rifle",
  noise: 20,
  roundsPerSecond: 12.5,
  accuracy: 12.5,
  magazine: 90,
  maxAmmo: 540,
  reloadSeconds: 4.2,
  disposition: 1.4,

 
  attacks: [],

  polarities: "",
  exilusPolarity: "B"
},
{
  id: 14,
  masteryRequired: 7,
  type: "Shotgun",
  primary: true,
  name: "Tigris",

  ammo: "Shotgun",
  trigger: "Duplex",
  noise: 20,
  roundsPerSecond: 2,
  accuracy: 9.1,
  magazine: 2,
  maxAmmo: 120,
  reloadSeconds: 1.8,
  disposition: 1.1,

  attacks: [],

  polarities: "",
  exilusPolarity: "B"
},
{
  id: 15,
  masteryRequired: 6,
  type: "Pistol",
  primary: false,
  name: "Azima",
  trigger: "Auto",

  ammo: "Pistol",
  noise: 20,
  roundsPerSecond: 10,
  accuracy: 22.2,
  magazine: 75,
  maxAmmo: 525,
  reloadSeconds: 1.4,
  disposition: 1.25,

  attacks: [],

  polarities: "BV",
  exilusPolarity: "V"
}
];