import { Component, Input } from '@angular/core'
import { Node } from "../../Models/node"

@Component({
  selector: 'tree-node',
  templateUrl: './tree-node.component.html',
  styleUrls: ['./tree-node.component.scss']
})
export class TreeNodeComponent {

  @Input() node!: Node
  @Input() parentNode?: Node

}
