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
            Console.WriteLine("Enter 4 to create LinkListInsertion linkedlist");
            Console.WriteLine("Enter 5 to create LinkListDeleteFirstNode linkedlist");
            Console.WriteLine("Enter 6 to create LinklistDeleteLastNode linkedlist");
            Console.WriteLine("Enter 7 to create LinkedlistSearchNode");
            Console.WriteLine("Enter 8 to create LinkedlistInsertNode");


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
                    linkTwo.Append(56);
                    linkTwo.Append(30);
                    linkTwo.Append(70);                    
                    linkTwo.Display();
                    break;
                case 4:
                    LinkedListInsertion linkThree = new LinkedListInsertion();
                    linkThree.insert(56);
                    linkThree.insert(70);
                    linkThree.insert(30);     

                    linkThree.Display();
                    break;
                case 5:
                    Console.WriteLine("Delete First Node");
                    LinklistDeletefirstNode list = new LinklistDeletefirstNode();
                    list.AddNode(56);
                    list.AddNode(30);
                    list.AddNode(70);
                    list.Display();
                    list.DeleteNodeAtFirst();
                    list.Display();
                    break;
                case 6:
                    Console.WriteLine("Delete Last Node");
                    LinklistDeleteLastNode deleteNode = new LinklistDeleteLastNode();
                    deleteNode.AddNode(56);
                    deleteNode.AddNode(30);
                    deleteNode.AddNode(70);
                    deleteNode.Display();
                    deleteNode.DeleteLastNode();
                    deleteNode.Display();
                    break;
                case 7:
                    Console.WriteLine("Search Node");
                    LinklistSearchNode search = new LinklistSearchNode();
                    search.AddNode(56);
                    search.AddNode(30);
                    search.AddNode(70);                    
                    search.Search(30);
                    search.Display();
                    break;
                case 8:                   
                    InsertNodeInBetween insert = new InsertNodeInBetween();                    
                    insert.Append(56);
                    insert.Append(30);
                    insert.Append(70);
                    insert.AddNewNode(40, 30);
                    insert.Display();
                    break;


            }
        }
    }
}
