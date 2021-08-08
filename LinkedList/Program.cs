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
            list.Add(70);
            list.Add(30);
            list.Display();
            int nodePosition = list.Search(30);
            Console.WriteLine("Position of node : " + nodePosition);
        }
        
}
}
