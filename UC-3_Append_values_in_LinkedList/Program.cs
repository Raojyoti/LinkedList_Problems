using System;

namespace UC_3_Append_values_in_LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Console.WriteLine("Add values in linklist are: ");
            Console.WriteLine("-----------------------------");
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            Console.Write("\n");
            Console.WriteLine("LinkedList Sequence:");
            Console.WriteLine("-----------------------------");
            linkedList.Display();
            Console.WriteLine("\n");
        }
    }
}
