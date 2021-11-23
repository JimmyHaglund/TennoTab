export interface Blueprint {
   resultName: string;
   components: BlueprintComponentStack[];
}

export interface BlueprintComponentStack {
   componentName: string;
   componentCount: number;
}