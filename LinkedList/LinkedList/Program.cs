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
            Console.WriteLine("Enter 3 to create LinkListAppend_UC_3 linkedlist");


            switch(Convert.ToInt32(Console.ReadLine()))
            {
            case 1:
            Link56_70_30 link = new Link56_70_30();

                Node node2 = new Node(30);
                Node node1 = new Node(56);
                Node node3 = new Node(70);
                link.AddNode(node1);
                link.AddNode(node3);
                link.AddNode(node2);
                link.Display();
                break;
            case 2:
                    Link56_70_30 linkOne = new Link56_70_30();
                    Node node4 = new Node(70);
                    linkOne.AddNode(node4);
                    Node node5 = new Node(30);
                    linkOne.AddNode(node5);
                    Node node6 = new Node(56);                  
                    linkOne.AddNode(node6);
                    linkOne.Display();
                    break;
                case 3:
                    LinkListAppend_UC_3 linkTwo = new LinkListAppend_UC_3();                    
                    linkTwo.Append(70);
                    linkTwo.Append(30);
                    linkTwo.Append(56);                    
                    linkTwo.Display();
                    break;

            }
        }
    }
}
