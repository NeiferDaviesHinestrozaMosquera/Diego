using System;

namespace DataStructs
{
    public class DoubleNode<T> : ListNode<T>
    {
        public Node<T> PreviousNode { get; set; }
        public DoubleNode(T value, int position)
                                : base(value, position)
        {

        }
    }
}
