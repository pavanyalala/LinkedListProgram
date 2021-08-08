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
            list.Add(40);
            list.Add(70);
            list.DeleteParticularElement(40);
            list.Display();
            int finalSize = list.Size();
            Console.WriteLine("Size of List : " + finalSize);
        }
    }    
}

