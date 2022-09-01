using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class InsertNodeInBetween
    {
        public Node Head;
        public Node Tail;
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
        public void AddNewNode(int data, int addValue)
        {            
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node temp = Head;                
                while (temp.data != addValue)
                {                    
                    temp = temp.next;
                }               
                newNode.next = temp.next;               
                temp.next = newNode;

            }
            Console.WriteLine("Added  node: " + data);
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
