using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkListAppend_UC_3
    {
        public Node Head;
        public Node Tail;
        public LinkListAppend_UC_3()
        {
            Head = null;
            Tail = null;
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
                
                Node temp = Head;

                while (temp.next != null)
                
                {
                    
                    temp = temp.next;
                }
                temp.next = node;
            }

            Console.WriteLine("Appended the Node:" + data);
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
