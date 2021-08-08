using System;

namespace LinkedList                
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list program");
            SortList<int> sortingList = new SortList<int>();
            sortingList.AddNode(56);
            sortingList.AddNode(30);
            sortingList.AddNode(40);
            sortingList.AddNode(70);
            Console.WriteLine("Original List: ");
            sortingList.DisplaySort();
            sortingList.SortOrderedList();
            Console.WriteLine("Final Sorted List: ");
            sortingList.DisplaySort();
        }
    }    
}

