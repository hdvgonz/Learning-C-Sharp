using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Array

            int[] array = new int[3];
            array[0] = 100;
            array[1] = 344;

            Console.WriteLine($"Array[0] = {array[0]}");
            Console.WriteLine($"Array[1] = {array[1]}");


            //Declaracion Array2
            Console.ForegroundColor = ConsoleColor.Cyan;
            int[] array2 = { 1, 2, 4, 6 };
            string[] array3 = { "Lunes", "martes", "miercoles" };

            double[] array4;
            array4 = new double[] { 1.0, 3.2, 2.4, 4.5 };


            foreach (int item in array4)
            {
                Console.WriteLine($"item: {item}");
            }


            Console.ForegroundColor = ConsoleColor.Magenta;

            int[][] array5 = new int[2][];
            array5[0] = new int[] { 1 };
            array5[1] = new int[] { 1, 2, 3 };

            foreach (int[] item in array5)
            {
                foreach (int subItem in item)
                {
                    Console.WriteLine(subItem);
                }
            }
            {
                Console.WriteLine($"El array tiene {array5.Length}");

                Console.WriteLine($"El array tiene {array5.Rank}");
            }

            //Arreglos de 2 dimensiones
            Console.ForegroundColor = ConsoleColor.Blue;
            int[,] studentsScores = new int[2, 2];
            studentsScores[0, 0] = 10;
            studentsScores[0, 1] = 9;
            studentsScores[1, 0] = 4;
            studentsScores[1, 1] = 8;

            Console.WriteLine($"El estudiante 1 del grupo 1 tiene una nota de {studentsScores[0, 0]}");
            Console.WriteLine($"El estudiante 2 del grupo 1 tiene una nota de {studentsScores[0, 1]}");
            Console.WriteLine($"El estudiante 3 del grupo 1 tiene una nota de {studentsScores[1, 0]}");
            Console.WriteLine($"El estudiante 1 del grupo 1 tiene una nota de {studentsScores[1, 1]}");

            Console.WriteLine($"Este array tiene {studentsScores.Rank} dimensiones");


            Console.ReadKey();






        }
    }
}