import { Component, NgZone, OnInit } from '@angular/core'
import { TreeTableControllerService } from "../service/tree-table-controller.service"
import { Node } from '../Models/node'

@Component({
  selector: 'tree-view',
  templateUrl: './tree-view.component.html',
  styleUrls: ['./tree-view.component.scss']
})
export class TreeViewComponent implements OnInit {

  nodes: Node[] = []
  columns: string[] = []

  constructor(private service: TreeTableControllerService) {
  }

  ngOnInit(): void {
    this.service.getTreeTable()
      .then(tree => {
        this.nodes = tree.roots
        const nodesFlat = this.getAllTreeFlat()
        nodesFlat.forEach(n => n.expanded = true)
        this.columns = new Array(Math.max(...nodesFlat.map(n => n.stats.length + 1)))
          .fill(null)
          .map((_, i) => i == 0 ? 'Selection' : `Col ${i + 1}`)
      })
  }

  getAllTreeFlat() {
    const output: Node[] = []

    const addNode = (s: Node) => {
      output.push(s)
      if (s.children != null && s.children.length > 0) {
        s.children.forEach(subNode => {
          addNode(subNode)
        })
      }
    }

    this.nodes.forEach(n => addNode(n))

    return output
  }

  getNodeWithChildrenFlat(originalNode: Node): Node[] {
    const output: Node[] = []

    const addNode = (s: Node) => {
      output.push(s)
      if (s.children != null && s.children.length > 0) {
        s.children.forEach(subNode => {
          addNode(subNode)
        })
      }
    }

    addNode(originalNode)

    return output
  }

  toggleNode(node: Node) {
    node.expanded = !node.expanded
  }

  toggleNodeSelection(node: Node) {
    const allNodes = this.getNodeWithChildrenFlat(node)
    const isSelected = !node.isSelected
    allNodes.forEach(n => n.isSelected = isSelected)
  }

  getSignImage(expanded: boolean) {
    return expanded ? 'assets/icon-minus.png' : 'assets/icon-plus.png'
  }
}
