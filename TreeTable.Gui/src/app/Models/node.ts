export interface Stats {
    value: number;
}

export interface Node {
    nodeType: string; // Tag, Tag:Label,Tag, Tag:Label , Data (component)
    description: string;
    stats: Stats[];
    children: Node[];
    IsSelected:boolean;
}

export interface Tree {
    roots: Node[];
}
