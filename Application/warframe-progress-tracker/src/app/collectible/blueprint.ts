export interface BlueprintComponent {
   name: string;
   componentCount: number;
}

export interface Blueprint {
   resultName: string;
   components: BlueprintComponent[];
}

export interface ResourceStack {
   id: number;
   name: string;
   amount: number;
}

export interface BlueprintCost {
   name: string;
   cost: ResourceStack[];
}