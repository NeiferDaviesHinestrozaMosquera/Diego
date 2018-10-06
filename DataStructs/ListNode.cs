using System;

namespace DataStructs
{
    public class ListNode<T> : Node<T>
    {
        public int Position { get; set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T value, int position) : base(value)
        {
            this.Position = position;
        }
    }
}