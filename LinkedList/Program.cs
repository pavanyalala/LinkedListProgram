﻿using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList linkedList = new LinkedList();
            linkedList.AddInReverseOrder(70);
            linkedList.AddInReverseOrder(30);
            linkedList.AddInReverseOrder(56);
            linkedList.Display();

        }
    }
}
