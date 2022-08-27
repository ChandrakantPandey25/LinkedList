using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinklistDeletefirstNode
    {
        public Node Head;
        public Node Tail;
        public LinklistDeletefirstNode()
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
        public void DeleteNodeAtFirst()
        {
            //Check list is empty or not
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to delete list is empty");

            }
            //Put temp variable become head in list
            Node temp = this.Head;
            //Change head to next node to delete the previous node
            this.Head = this.Head.next;

            Console.WriteLine("Removed from linkedlist :" + temp.data);
        }
        public void Display()
        {
            //temp variable will head
            Node temp = Head;
            //Check wheather list is empty or not 
            if (this.Head == null)
            {
                Console.WriteLine("Linked list is empty");

            }
            while (temp != null)
            {
                //Check until temp will null
                Console.Write(temp.data + " ");
                if (temp.next != null)
                {
                    Console.Write("->");
                }
                //for traversing the node
                temp = temp.next;
            }
            Console.WriteLine();



        }
    }
}
