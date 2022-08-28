using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinklistSearchNode
    {
        public Node Head;
        public Node Tail;
        public LinklistSearchNode()
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
        public bool Search(int data)
        {           
            Node temp = this.Head;            
            while (temp != null)
            {               
                if (temp.data == data)
                {

                   
                    Console.WriteLine("Node found");
                    return true;
                }
                temp = temp.next;
            }
          
            Console.WriteLine("Node not found");
            return false;
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
            
        }
    }
}
