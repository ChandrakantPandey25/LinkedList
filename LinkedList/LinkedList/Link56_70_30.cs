using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Link56_70_30
    {
        public Node Head;           
        public void AddNode(Node node)
        {
            if(Head==null )
            {
                Head = node;                

            }
            else
            {
                node.next = Head;
                Head = node;
            }
            Console.WriteLine("{0} Node added to linkedlist",node.data);
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
