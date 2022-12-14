using System;
using System.Collections.Generic;
using System.Text;

namespace UC_6_Delete_last_element_in_LinkedList
{
    public class LinkedList
    {
        public Node head;
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
            Console.WriteLine("{0} is inserted in linked list", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
        }
       public Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;    
            }
            if(head.next==null)
            {
                return null;
            }
            Node NewNode= head;
            while(NewNode.next.next != null)
            { 
                NewNode = NewNode.next; 
            }
            NewNode.next = null;
            return head;
        }
    }
}
