using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinklistDeleteLastNode
    {

        public Node Head;
        public Node Tail;
        public LinklistDeleteLastNode()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(int data)
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
            Console.WriteLine("Added the Node:" + data);
        }
        public void DeleteLastNode()
        {            
            if (this.Head == null)
            {
                Console.WriteLine("Nothing To Delete");

            }            
            Node temp = this.Head;            
            while (temp.next.next != null)
            {               
                temp = temp.next;
            }          
            temp.next = null;
        }
        public void Display()
        {
            Node temp = Head;
            if (this.Head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                if (temp.next != null)
                {
                    Console.Write("->");
                }
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
