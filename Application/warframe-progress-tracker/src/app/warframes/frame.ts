export interface Frame {
    id: number,
    masteryRankRequired: number,
    name: string;
    health: number;
    shield: number;
    armor: number;
    energy: number;
    sprintSpeed: number;
    polarities: string;
    exilusPolarity: string;
    auraPolarity: string;
    subsumedAbility: number;
    howToGet: string;
    masteryRank: number,
    obtained: boolean
}

export interface UserFrame {
    frameId: number,
    masteryRank: number,
    obtained: boolean
}