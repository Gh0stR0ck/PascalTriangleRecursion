using PascalTriangleRecursion;
using PascalTriangleRecursion.Models;

// The total rows that the solution will create.
int treeBranches = 5;
var tree = new PascalTriangleTree();

// Creating the first node and add it to the tree.
// As the recursion function will not work for a note with no parent and next sibling
var node = new Node
{
    Id = 0,
    Parent = null,
    NextSibling = null,
    Value = 1
};
tree.NodesList.Add(node);

//Running it all.
var PascalTriangle = new PascalTriangle();
PascalTriangle.RecursionFunction(tree, null, node, treeBranches);
PascalTriangle.PrintTree(tree);
