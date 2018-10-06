using System;
using System.Collections.Generic;

namespace DataStructs
{
    public class SingleList<T>
    {
        public ListNode<T> Head { get; set; }
        public ListNode<T> Current { get; set; }
        

        private int _count;
        public int Count
        {
            get
            {
                return this._count;
            }
        }

        internal class Nodes
        {
            internal int data;
            internal Nodes next;

            /// Constructor to create a new node.Next is by default initialized as null
            public Nodes(int d)
            {
                data = d;
                next = null;
            }
        }

        public void AddNode(T value)
        {
            //La lista esta vacia
            if (this.Count == 0)
            {
                ListNode<T> newNode = new ListNode<T>(value, 0);
                this.Head = newNode;
                this.Current = newNode;
                this._count++;
            }
            else
            {
                int newPosition = this.Current.Position + 1;
                ListNode<T> newNode = new ListNode<T>(value, newPosition);
                newNode.Next = this.Current.Next;
                this.Current.Next = newNode;
                this.Current = newNode;
                this._count++;
                //Falta incrementar la posición de los siguientes
            }
        }

        public void AddNodeInicio(T value)
        {

            ListNode<T> newNode = new ListNode<T>(value, 0);
            newNode.Next = Head;
            Head = newNode;

            Current = Head.Next;
            while (Current != null)
            {
                Current.Position += 1;
                Current = Current.Next;
            }

        }

        public void AddNodeFinal(SingleList<T> singlyList, T value)
        {
            ListNode<T> newNode = new ListNode<T>(value, Head.Position);

            if (singlyList.Head == null)
            {
                this.Current = Head;
                this.Current.Next = Current;
                this.Head = newNode;

                this._count++;
                return;
            }
            ListNode<T> lastNode = GetLastNode(singlyList);

            lastNode.Next = newNode;
        }

        internal ListNode<T> GetLastNode(SingleList<T> singlyList)
        {
            ListNode<T> temp = singlyList.Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;

        }

        public void SearchNode(SingleList<int> singlyList, int value)
        {
            ListNode<int> temp = singlyList.Head;

            while (temp != null)
            {
                if (temp.Value == value)
                {
                    //Console.WriteLine("El elemento {0} está presente en la lista", value);
                    Console.WriteLine("El elemento {0} está presente en la lista en la posición {1}", value,temp.Position);
                    return;
                }

                temp = temp.Next;
            }
            Console.WriteLine("El elemento {0} NO está presente en la lista", value);
        }

        public void InvertirLista(SingleList<int> singlyList)
        {
            ListNode<int> prev = null;
            ListNode<int> current = singlyList.Head;
            ListNode<int> temp = null;

            while (current != null)
            {
                temp = current.Next;
                current.Next = prev;
                prev = current;
                current = temp;
            }
            singlyList.Head = prev;
        }

        public void ImprimirLista()
        {
            if (this.Count >= 0)
            {
                this.Current = this.Head;
                while (this.Current != null)
                {
                    Console.Write(this.Current.Value + " ");
                    this.Current = this.Current.Next;
                }
            }
        }
    }
}