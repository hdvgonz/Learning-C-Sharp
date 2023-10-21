using System;

namespace TriangleAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseT, alturaT;
            bool flag;
            string userData;
            double result;


            Console.WriteLine("Cual es el area de este triangulo");

            Console.WriteLine(@"   /\ ");
            Console.WriteLine(@"  /  \");
            Console.WriteLine(@" /    \");
            Console.WriteLine(@"/______\");



            Console.WriteLine("Digite Base del triangulo en CM");
            userData = Console.ReadLine();
            flag = double.TryParse(userData, out baseT);

            Console.WriteLine("Digite Altura del triangulo en CM");
            userData = Console.ReadLine();
            flag =  double.TryParse(userData, out alturaT) && flag;

            if ( flag )
            {
                result = ( baseT *  alturaT ) / 2;

                Console.WriteLine($"El area del triangulo es {result}CM");
            }
            else
            {
                Console.WriteLine("Digite valores válidos, por favor");
            }



            Console.ReadKey();
        }
    }
}