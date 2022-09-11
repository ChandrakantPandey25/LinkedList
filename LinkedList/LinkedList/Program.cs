using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");
            Console.WriteLine("Enter 1 to create simple linkedlist");
            Console.WriteLine("Enter 2 to create Link_56_30_70 linkedlist");

            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Link56_70_30 link = new Link56_70_30();

                        Node node2 = new Node(30);
                        Node node1 = new Node(56);
                        Node node3 = new Node(70);
                        link.AddNode(node3);
                        link.AddNode(node2);
                        link.AddNode(node1);
                        link.Display();
                        break;
                    case 2:
                        Link56_70_30 linkOne = new Link56_70_30();
                        Node node4 = new Node(70);
                        Node node5 = new Node(30);
                        Node node6 = new Node(56);
                        linkOne.AddNode(node4);
                        linkOne.AddNode(node5);
                        linkOne.AddNode(node6);
                        linkOne.Display();
                        break;
                }
            }
        }
    }
}
