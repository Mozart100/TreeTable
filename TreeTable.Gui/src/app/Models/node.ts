export interface Stats {
  value: number;
}

export interface Node {
  nodeType: string; // Tag, Tag:Label,Tag, Tag:Label , Data (component)
  description: string;
  stats: Stats[];
  isSelected: boolean
  children: Node[];
  expanded?: boolean
}

export interface Tree {
  roots: Node[];
}
