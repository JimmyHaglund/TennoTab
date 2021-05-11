import { MeleeWeapon } from '../melee-weapon/melee-weapon';

export const MELEEWEAPONS: MeleeWeapon[] = [
   {
      id: 11,
      name: "Ripkas",
      masteryRequired: 5,
      type: "Claws",

      attackSpeed: 0.833,
      rangeMetres: 1.75,
      comboSeconds: 5,
      blockDegrees: 55,
      followThrough: 0.8,
      disposition: 1.38,

      attacks: [],

      augments: [],
      polarities: "V",
      stancePolarity: "V",
      stances: []
   },
   {
      id: 12,
      name: "Skana",
      masteryRequired: 0,
      type: "Sword",

      attackSpeed: 0.833,
      rangeMetres: 2.5,
      comboSeconds: 5,
      blockDegrees: 55,
      followThrough: 0.6,
      disposition: 1.30,

      attacks: [],

      augments: [],
      polarities: "",
      stancePolarity: "V",
      stances: []
   },
   {
      id: 13,
      name: "Ankyros",
      masteryRequired: 2,
      type: "Fist",

      attackSpeed: 1.17,
      rangeMetres: 1.25,
      comboSeconds: 5,
      blockDegrees: 50,
      followThrough: 0.9,
      disposition: 1.45,

      attacks: [],

      augments: [],
      polarities: "",
      stancePolarity: "D",
      stances: []
   },
   {
      id: 14,
      name: "Anku",
      masteryRequired: 3,
      type: "Scythe",

      attackSpeed: 1.08,
      rangeMetres: 2.80,
      comboSeconds: 5,
      blockDegrees: 60,
      followThrough: 0.6,
      disposition: 1.46,

      attacks: [],

      augments: [],
      polarities: "V",
      stancePolarity: "Z",
      stances: []
   }
]