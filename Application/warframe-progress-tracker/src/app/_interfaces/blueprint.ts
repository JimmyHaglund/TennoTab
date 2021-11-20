export interface Blueprint {
   resultName: string;
   components: BlueprintComponentStack[];
}

export interface BlueprintComponentStack {
   name: string;
   componentCount: number;
}