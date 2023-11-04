using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            List<int> list1 = new List<int>();

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            list1.Add(45);

            ShowListContain(list1);

            Console.ForegroundColor = ConsoleColor.Green;

            if (list1.Contains(4))
            {
                list1.Remove(4);
                Console.WriteLine("Se removió el elemento 4");
            }

            ShowListContain(list1);

            Console.WriteLine("------------------");

            if (!list1.Contains(50))
            {
                list1.Insert(0, 50);
                Console.WriteLine("Se añadió el elemento 50 a la lista");
            }

            ShowListContain(list1);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------");

            List<int> list2 = new List<int>() { 81, 30, 25, 45, 77 };
            ShowListContain(list2);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Uniendo Listas");
            Console.WriteLine("------------------");
            list2.InsertRange(0, list1);

            ShowListContain(list2);

            Console.ReadKey();
        }

        private static void ShowListContain(List<int> list1)
        {
            list1.ForEach(item =>
            {
                Console.WriteLine(item);
            });
        }
    }
}