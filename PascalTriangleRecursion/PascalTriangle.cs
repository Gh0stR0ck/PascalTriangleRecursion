using PascalTriangleRecursion.Models;

namespace PascalTriangleRecursion
{
    public class PascalTriangle
    {
        private int id = 0;

        public (PascalTriangleTree, Node) RecursionFunction(PascalTriangleTree tree, Node? parent, Node? parentNextSibling, int counter)
        {
            id++;

            var currentNode = new Node
            {
                Id = id,
                FirstParent = parent,
                NextSibling = null,
                Value = CalculateValue(parent?.Value, parentNextSibling?.Value)
            };
            tree.NodesList.Add(currentNode);

            if (parentNextSibling == null) return (tree, currentNode);

            (tree, currentNode.NextSibling) = RecursionFunction(tree, parentNextSibling, parentNextSibling?.NextSibling, counter);

            if (parent == null && counter > 1)
            {
                counter--;
                RecursionFunction(tree, null, currentNode, counter);
            }

            return (tree, currentNode);
        }

        public void PrintTree(PascalTriangleTree tree)
        {
            foreach(var node in tree.NodesList)
            {
                Console.Write("   " + node.Value.ToString());
                if (node.NextSibling == null) Console.WriteLine("");
            }
        }

        private int CalculateValue(int? nodeOne, int? nodeTwo)
        {
            var valueOne = (nodeOne == null) ? 0 : nodeOne.Value;
            var valueTwo = (nodeTwo == null) ? 0 : nodeTwo.Value;
            return valueOne + valueTwo;
        }
    }
}
