using System.Collections.Generic;

namespace hacker_rank_contacts
{
    public class Node
    {
        public Node()
        {
            Children = new Dictionary<char, Node>();
        }

        public Dictionary<char, Node> Children { get; set; }

        public int Size { get; set; }

        public bool IsCompleteWord { get; set; }
    }
}
