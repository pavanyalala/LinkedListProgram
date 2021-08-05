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
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
        }
        Console.WriteLine("Inserted values : " + node.data);
        }

        /// <summary>
        /// Uc-2
        /// </summary>
        /// <param name="data"></param>
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if(this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        /// <summary>
        /// Displays Linked List
        /// </summary>
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
            }
        }
    }
}
