﻿using System;
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
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to delete list is empty");

            }
            
            Node temp = this.Head;
            
            this.Head = this.Head.next;

            Console.WriteLine("Removed from linkedlist :" + temp.data);
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
