using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list program");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(70);
            Console.WriteLine("Inserted 30 between 56 and 70");
            linkedList.InsertAtParticularPosition(1, 30);
            linkedList.Display();
            Console.WriteLine("Delete first node ");
            linkedList.RemoveFirstNode();
            linkedList.Display();
        }
    }
}
