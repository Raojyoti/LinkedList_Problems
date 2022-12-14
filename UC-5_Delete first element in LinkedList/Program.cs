using System;

namespace UC_5_Delete_first_element_in_LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList List = new LinkedList();
            Console.WriteLine("Add values in linklist are: ");
            Console.WriteLine("--------------------------------");
            List.Add(56);
            List.Add(30);
            List.Add(70);
            Console.Write("\n");
            Console.WriteLine("LinkedList Sequence:");
            Console.WriteLine("-----------------------------");
            List.Display();
            Console.WriteLine("\n");

            Console.WriteLine("After delete the first value and the LinkedList sequence are:");
            Console.WriteLine("------------------------------------------------------------------");
            List.RemoveFirstNode();
            List.Display();
            Console.WriteLine("\n");
           
        }
    }
}
