import { DisplayedCategories } from "./displayedCategories";

export interface CollectibleFilterState {
   filterText: string;
   allowedObtainedState: string;
   includedCategories: DisplayedCategories;
}