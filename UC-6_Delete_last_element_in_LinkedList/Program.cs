using System;

namespace UC_6_Delete_last_element_in_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList List = new LinkedList();
            Console.WriteLine("Add values in linklist are: ");
            Console.WriteLine("-----------------------------");
            List.Add(56);
            List.Add(30);
            List.Add(70);
            Console.Write("\n");
            Console.WriteLine("LinkedList Sequence:");
            Console.WriteLine("-----------------------------");
            List.Display();
            Console.WriteLine("\n");

            List.RemoveLastNode();
            Console.WriteLine("After remove last node thenLinkedList Sequence are :");
            Console.WriteLine("--------------------------------------------------------");
            List.Display();
            Console.WriteLine("\n");
        }
    }
}
