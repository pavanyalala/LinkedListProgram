﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
        public class SortList<T> where T : IComparable<T>
        {
            public Node<T> head = null;
            public Node<T> tail = null;
            public void AddNode(T data)
            {
                Node<T> newNode = new Node<T>(data);
                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.next = newNode;
                    tail = newNode;
                }
            }
            public void SortOrderedList()
            {
                Node<T> current = head, index = null;
                T temp;

                if (head == null)
                {
                    return;
                }
                else
                {
                    while (current != null)
                    {
                        index = current.next;
                        while (index != null)
                        {
                            if (current.data.CompareTo(index.data) > 0)
                            {
                                temp = current.data;
                                current.data = index.data;
                                index.data = temp;
                            }
                            index = index.next;
                        }
                        current = current.next;
                    }
                }
            }
            public void DisplaySort()
            {
                Node<T> current = head;
                if (head == null)
                {
                    Console.WriteLine("LinkedList is Empty");
                    return;
                }
                while (current != null)
                {
                    Console.Write(current.data + " ");
                    current = current.next;
                }
                Console.WriteLine();
            }
        }
    }

