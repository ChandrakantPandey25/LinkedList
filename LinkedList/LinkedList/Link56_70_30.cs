using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Link56_70_30
    {
        public Node Head;
        public Node Tail;

        public Link56_70_30()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if(Head==null && Tail==null)
            {
                Head = node;
                Tail = node;

            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        internal void Display()
        {
            Node temp = Head;
            if (temp == null)
                Console.WriteLine("LinkedList is empty");
            else
                Console.WriteLine("Linked List:");
            while(temp!=null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                    Console.Write("->");
                temp = temp.next;
            }
        }
    }
}
