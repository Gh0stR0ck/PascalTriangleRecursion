namespace PascalTriangleRecursion.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Node
    {
        public int Id { get; set; }
        public Node? FirstParent { get; set; }
        public Node? NextSibling { get; set; }
        public int Value { get; set; }

        /// <summary>
        /// Printing a nice line with all the node information.
        /// </summary>
        /// <returns> Clear string to write somewhere. </returns>
        public override string ToString() { 
            var idString = Id.ToString();
            var firstParentString = (FirstParent == null) ? "Null" : FirstParent.Id.ToString();
            var nextSiblingString = (NextSibling == null) ? "Null" : NextSibling.Id.ToString();
            var valueString = Value.ToString();

            return "id = " + idString + " | value = " + valueString + " | first = " + firstParentString + " | next = " + nextSiblingString; 
        }
    }
}
