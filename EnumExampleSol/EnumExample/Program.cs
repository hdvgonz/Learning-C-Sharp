﻿namespace EnumExample
{
    internal class Program
    {
        public enum Days
        {
            Monday,
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Days day = Days.Friday;

            if (day == Days.Friday)
            {
                Console.WriteLine("Se acabó la semana!");
            }

            Console.ReadKey();
        }
    }
}