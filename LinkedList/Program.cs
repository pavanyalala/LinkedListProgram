using System;

namespace LinkedList                
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list program");
            List list = new List();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            int nodePosition = list.Search(30);
            list.InsertAtParticularPosition(nodePosition + 1, 40);
            list.Display();
        }
        
}
}
