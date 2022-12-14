using System;
using System.Collections.Generic;
using System.Text;

namespace UC_4_Insert_Values_Between
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
        public int Search(int value)
        {
            Node node =this.head;
            int count = 1;
            while (node != null)
            {
                if(node.data == value)
                {
                    return count;
                }
                node= node.next;
                count++;
            }
            return count;
        }
        public Node InsertAtParticularPosition(int position,int data) 
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if(position == 1)
            {
                var newNode= new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while(position-- !=0)
                {
                    if(position == 1)
                    {
                        Node node =new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if(position !=1)
                    Console.WriteLine("Position is out of range");
            }
            return head;
        }
    }
}
