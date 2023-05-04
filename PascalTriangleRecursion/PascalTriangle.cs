using PascalTriangleRecursion.Models;

namespace PascalTriangleRecursion
{
    /// <summary>
    /// The class that will create the PascalTriangle Solution and then print it.
    /// </summary>
    public class PascalTriangle
    {
        private int id = 0;

        /// <summary>
        /// The Recursive function that will create the solution.
        /// </summary>
        /// <param name="tree"> The tree to put the solution in. </param>
        /// <param name="parent"> The direct parent of the node. </param>
        /// <param name="parentNextSibling"> The next sibling of the parent. This is the second Value.</param>
        /// <param name="counter"> The counter for counting down the rows. </param>
        /// <returns></returns>
        public (PascalTriangleTree, Node) RecursionFunction(PascalTriangleTree tree, Node? parent, Node? parentNextSibling, int counter)
        {
            // Create the current node and add them too the tree.
            var currentNode = new Node
            {
                Id = id++,
                Parent = parent,
                NextSibling = null,
                Value = CalculateValue(parent?.Value, parentNextSibling?.Value)
            };
            tree.NodesList.Add(currentNode);

            // If we are at the end of the current row, go all the way back.
            if (parentNextSibling == null) return (tree, currentNode);

            // If we are NOT at the end of the current row, go to the next node in the row.
            // While returning, connection it too this node, so the next row knows with what parent sibling to get the second value from.
            (tree, currentNode.NextSibling) = RecursionFunction(tree, parentNextSibling, parentNextSibling?.NextSibling, counter);

            // If we are all the way back to the first node of the row, and if we still want to print more rows, start another row.
            if (parent == null && --counter > 1)
            {
                RecursionFunction(tree, null, currentNode, counter);
            }

            // If we don't want any more rows, lets go all the way back.
            return (tree, currentNode);
        }

        /// <summary>
        /// Printing the full solution of the PascalTriangle in rows.
        /// </summary>
        /// <param name="tree"> The tree with the full solution of PascalTriangle.</param>
        public void PrintTree(PascalTriangleTree tree)
        {
            foreach(var node in tree.NodesList)
            {
                Console.Write("   " + node.Value.ToString());
                if (node.NextSibling == null) Console.WriteLine("");
            }

            /*
            // The Debug print.
            foreach (var node in tree.NodesList)
            {
                Console.WriteLine("   " + node.ToString());
                if (node.NextSibling == null) Console.WriteLine("");
            }
            */
            
        }

        /// <summary>
        /// Calculate the value that is the sum of the 2 values.
        /// </summary>
        /// <param name="nodeOne"> The first value. </param>
        /// <param name="nodeTwo"> The second value. </param>
        /// <returns> The sum of the 2 values. </returns>
        private int CalculateValue(int? nodeOne, int? nodeTwo)
        {
            var valueOne = (nodeOne == null) ? 0 : nodeOne.Value;
            var valueTwo = (nodeTwo == null) ? 0 : nodeTwo.Value;
            return valueOne + valueTwo;
        }
    }
}
