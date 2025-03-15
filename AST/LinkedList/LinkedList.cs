using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class LinkedList
    {
        public Node? First {  get; set; }
        public void InsertFirst(int data)
        {
            Node node = new Node()
            {
                Data = data,
                next = First,
            };
            First = node;
        }
        public Node DeleteFirst()
        {
            Node temp = First;
            First = First.next;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("Interating through list...");
            Node current = First;
            while (current != null)
            {
                current.DisplayNode();
                current = current.next;
            }
        }
        public void InsertLast(int data)
        {
            Node current = First;
            while(current.next != null)
            {
                current = current.next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.next = newNode;
        }
    }
}
