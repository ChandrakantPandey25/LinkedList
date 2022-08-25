using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Link56_30_70 link = new Link56_30_70();
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);
            link.AddNode(node1);
            link.AddNode(node2);
            link.AddNode(node3);
            link.Display();
        }
    }
}
