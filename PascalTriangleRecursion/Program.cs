using PascalTriangleRecursion;
using PascalTriangleRecursion.Models;

int treeBranches = 12;
var tree = new PascalTriangleTree();
var node = new Node
{
    Id = 0,
    FirstParent = null,
    NextSibling = null,
    Value = 1
};
tree.NodesList.Add(node);

var PascalTriangle = new PascalTriangle();

PascalTriangle.RecursionFunction(tree, null, node, treeBranches);
PascalTriangle.PrintTree(tree);
