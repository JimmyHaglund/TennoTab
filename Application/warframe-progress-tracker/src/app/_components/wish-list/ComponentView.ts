import { Blueprint, BlueprintComponentStack } from '../../_interfaces/blueprint';
import { Collectible } from '../../_interfaces';
export interface ComponentView {
   collectible: Collectible,
   blueprint: Blueprint,
   cost: BlueprintComponentStack[]
};
