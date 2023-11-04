using System;
using System.Collections.Generic;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashSet no acepta elementos repetidos
            Console.WriteLine("HashSet");
            Console.ForegroundColor = ConsoleColor.Yellow;
            HashSet<string> hash1 = new HashSet<string>();
            hash1.Add("Hola");
            hash1.Add("Buenos");
            hash1.Add("Buenos");
            hash1.Add("Buenos");
            hash1.Add("Dias");
            hash1.Add("Dani");

            foreach (var item in hash1)
            {
                Console.WriteLine($"item: {item}");
            }

            //SortedSet organiza una lista ascendentemente
            Console.WriteLine("SortedSet");
            Console.ForegroundColor = ConsoleColor.Gray;

            SortedSet<string> sort1 = new SortedSet<string>();
            sort1.Add("Hola");
            sort1.Add("Buenos");
            sort1.Add("Buenos");
            sort1.Add("Buenos");
            sort1.Add("Dias");
            sort1.Add("Dani");

            foreach (var item in sort1)
            {
                Console.WriteLine(item);
            }


            //Dictionary es una list de llaves / valor
            Console.WriteLine("Dictionary");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Dictionary<string, double> fruitCost = new Dictionary<string, double>();
            fruitCost.Add("Pera", 9000);
            fruitCost.Add("Manzana", 4000);
            fruitCost.Add("Pinha", 6000);
            fruitCost.Add("Aguacate", 8000);
            fruitCost.Add("Sandia", 5000);

            foreach (KeyValuePair<string, double> item in fruitCost)
            {
                Console.WriteLine($"La fruta {item.Key} cuesta {item.Value}");
            }
            Console.ForegroundColor = ConsoleColor.blue;

            SortedList<string, double> fruitCostSorted = new SortedDictionary<string, double>();
            fruitCostSorted.Add("Pera", 9000);
            fruitCostSorted.Add("Manzana", 4000);
            fruitCostSorted.Add("Pinha", 6000);
            fruitCostSorted.Add("Aguacate", 8000);
            fruitCostSorted.Add("Sandia", 5000);

            foreach (var item in fruitCost)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}