using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkListAppend_UC_3
    {
        public Node Head;       
        public LinkListAppend_UC_3()
        {
            Head = null;           
        }

        public void Append(int data)
        {
           
            Node node = new Node(data);
            
            if (this.Head == null)
            {
                this.Head = node;
            }

            else
            {
                node.next = Head;
                Head = node;               
               
            }

            Console.WriteLine("Appended the Node:" + node.data);
        }
        internal void Display()
        {
            Node temp = Head;
            if (temp == null)
                Console.WriteLine("LinkedList is empty");
            else
                Console.WriteLine("Linked List:");
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                    Console.Write("->");
                temp = temp.next;
            }
        }
    }
}
