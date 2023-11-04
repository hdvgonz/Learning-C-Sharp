using System;

namespace SampleClassImplicitHeritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass sc = new SampleClass();
            Console.WriteLine(sc.ToString());
            Console.ReadLine();
        }

        public class SampleClass
        {

        }
    }
}