using System;
using System.Collections;
using System.Collections.Generic;

namespace StudentScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames = new string[] { "Daniel", "Juan", "Roberto", "Luis" };
            SortedList<string, int> sortedStudentScores = new SortedList<string, int>();

            int score;

            foreach (var item in  studentNames)
            {
                score = 0;

                while (score == 0)
                {
                    Console.WriteLine($"Digita la nota de {item}");
                    GetInteger(Console.ReadLine(), out score);
                }

                sortedStudentScores.Add(item, score);
            }

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (KeyValuePair<string, int> student in sortedStudentScores)
            {
                Console.WriteLine($"La nota final de {student.Key} es {student.Value}");
            }

            Console.ReadKey();
        }

        private static void GetInteger(string data, out int score)
        {
            if (!int.TryParse(data, out score))
            {
                Console.WriteLine("El dato debe ser entero");
            }
        }
    }
}