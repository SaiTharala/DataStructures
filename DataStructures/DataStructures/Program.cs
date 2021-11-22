using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            ListStack stack = new ListStack();
            ListQueue queue = new ListQueue();
            Console.WriteLine("Welcome to Data Structures Programs...");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose an Option : \n 1.Create Simple Linked List \n 2.AddInReverse\n 3.InsertBetween\n 4.RemoveFirstElement\n 5.RemoveLastElement\n 6.Search\n 7.InsertAtParticularNode\n 8.DeleteAtParticularNode\n 9.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    case 2:
                        linkedList.AddInReverseOrder(70);
                        linkedList.AddInReverseOrder(30);
                        linkedList.AddInReverseOrder(56);
                        linkedList.Display();
                        break;
                    case 3:
                        linkedList.Add(56);
                        linkedList.Add(70);
                        linkedList.InsertAtParticularPosition(2, 99);
                        linkedList.Display();
                        break;
                    case 4:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveFirstNode();
                        Console.WriteLine("After removing the first node of Linked List : ");
                        linkedList.Display();
                        break;
                    case 5:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveLastNode();
                        Console.WriteLine("After removing the last node of Linked List : ");
                        linkedList.Display();
                        break;
                    case 6:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        int search = linkedList.Search(30);
                        Console.WriteLine("\n{0} is The position Of Entered Element\n", search);
                        break;
                    case 7:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        int position = linkedList.Search(30);
                        position++;
                        linkedList.InsertAtParticularPosition(position, 40);
                        linkedList.Display();
                        break;
                    case 8:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display();
                        int position1 = linkedList.Search(40);
                        linkedList.DeleteNodeAtParticularPosition(position1);
                        linkedList.Display();
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}