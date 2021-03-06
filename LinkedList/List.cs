using System;

namespace LinkedList
{
    public class List
    {
        public Node<int> head;
        /// <summary>
        /// UC-1
        /// </summary>
        /// <param name="data"></param>
        public void Add(int data)
        {
            Node<int> node = new Node<int>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<int> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        /// <summary>
        /// Uc-2
        /// </summary>
        /// <param name="data"></param>
        public void AddInReverseOrder(int data)
        {
            Node<int> newNode = new Node<int>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<int> temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }   
        /// <summary>
        /// UC-3 Appendence
        /// </summary>
        /// <param name="data"></param>
        public void Appendence(int data)
        {
            Node<int> newNode = new Node<int>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<int> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        /// <summary>
        /// uc-4,UC-8
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node<int> InsertAtParticularPosition(int position, int data)
        {
            Node<int> newestNode = new Node<int>(data);
            if (this.head == null)
            {
                return newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return this.head;
            }
            Node<int> prev = null;
            Node<int> current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            return this.head;
        }
        /// <summary>
        /// uc-5 delete first node
        /// </summary>
        /// <returns></returns>
        public Node<int> RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        /// <summary>
        /// uc-6 Remove last node 
        /// </summary>
        /// <returns></returns>
        public Node<int> RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node<int> NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return head;
        }
        /// <summary>
        /// uc-7 search for node 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Search(int value)
        {
            Node<int> node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        /// <summary>
        /// uc-9 removes particluar element
        /// </summary>
        /// <param name="data"></param>
        public void DeleteParticularElement(int data)
        {
            Node<int> temp = head;
            Node<int> prev = null;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            if (temp != null && temp.data == data)
            {
                head = temp.next;
            }
            while (temp != null && temp.data != data)
            {
                prev = temp;
                temp = temp.next;
            }
            prev.next = temp.next;
        }
        /// <summary>
        /// size of list
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            Node<int> temp = this.head;
            int count = 0;
            if (temp == null)
            {
                return count;
            }
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            return count;
        }
        /// <summary>
        /// Displays Linked List
        /// </summary>
        public void Display()
        {
            Node<int> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
        

