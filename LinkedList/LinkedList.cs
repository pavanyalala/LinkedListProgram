using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        public Node head;
        /// <summary>
        /// UC-1
        /// </summary>
        /// <param name="data"></param>
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Inserted values : " + node.data);
        }
    }
}
