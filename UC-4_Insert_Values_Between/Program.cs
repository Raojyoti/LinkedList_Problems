using System;

namespace UC_4_Insert_Values_Between
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList List = new LinkedList();
            Console.WriteLine("Add values in linklist are: ");
            Console.WriteLine("-----------------------------");
            List.Add(56);
            List.Add(70);
            Console.Write("\n");
            Console.WriteLine("LinkedList Sequence:");
            Console.WriteLine("-----------------------------");
            List.Display();
            int a = List.Search(56);
            Console.WriteLine("Index position of element 56 is: " + a);
            List.InsertAtParticularPosition(a+1, 30);
            Console.WriteLine("-----------------------------");
            List.Display();
            Console.WriteLine("\n");
            
        }
    }
}
