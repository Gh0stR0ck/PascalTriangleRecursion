namespace PascalTriangleRecursion.Models
{
    /// <summary>
    /// Single node that containt information and 1 value of a PascalTriangle node.
    /// </summary>
    public class Node
    {
        public int Id { get; set; }
        public Node? Parent { get; set; }
        public Node? NextSibling { get; set; }
        public int Value { get; set; }

        /// <summary>
        /// Printing a nice line with all the node information.
        /// </summary>
        /// <returns> Clear string to write somewhere. </returns>
        public override string ToString() { 
            var idString = Id.ToString();
            var parentString = (Parent == null) ? "Null" : Parent.Id.ToString();
            var nextSiblingString = (NextSibling == null) ? "Null" : NextSibling.Id.ToString();
            var valueString = Value.ToString();

            return "id = " + idString + " | value = " + valueString + " | parent = " + parentString + " | sibling = " + nextSiblingString; 
        }
    }
}
