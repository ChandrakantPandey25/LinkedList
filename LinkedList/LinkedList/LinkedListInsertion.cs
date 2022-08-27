using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedListInsertion
    {
        public Node Head;
       
        public LinkedListInsertion()
        {
            this.Head = null;
        }
      
        public void insert(int data)
        {
           
            Node node = new Node(data);
            if (this.Head == null)
            {
                
                this.Head = node;
            }
            else
            {
                var temp = this.Head;
                var middle = this.Head;
                
                while (temp.next != null && temp.next.next != null)
                {
                    temp = temp.next.next;
                    middle = middle.next;
                }
                
                node.next = middle.next;
                middle.next = node;
            }
            //Console.WriteLine("Inserted the Node:" + data);
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

