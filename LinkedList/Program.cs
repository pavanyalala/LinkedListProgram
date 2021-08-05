using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list program");
            LinkedList linkedList = new LinkedList();
            linkedList.Appendence(56);
            linkedList.Appendence(30);
            linkedList.Appendence(70);
            linkedList.Display();
        }
    }
}
