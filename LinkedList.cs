using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedList
    {
        internal Node head;
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
            Console.WriteLine("{0} Inserted into Linked List", node.data);
        }
        public void Append(int data)
        {
            Node node = new Node(data);
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
            Console.WriteLine(node.data + " Append data");
        }

        public int Search(int addedData)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == addedData)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        public Node InsertData(int position, int data)
        {
            Node node2 = new Node(data);
            if (this.head == null)
            {
                return node2;
            }
            if (position == 0)
            {
                node2.next = head;
                head = node2;
                return head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            node2.next = prev.next;
            prev.next = node2;
            return this.head;
        }
        public void DeleteFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("Link list is empty");
            }
            Node temp = this.head;
            this.head = this.head.next;
        }
        public Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            Console.WriteLine("Last Node Is Deleted SuccesFully ");
            return head;
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkList Is Empty");
                
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
