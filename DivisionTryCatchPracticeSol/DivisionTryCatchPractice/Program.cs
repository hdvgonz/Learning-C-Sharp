using System;

namespace DivisionTryCatchPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un Numero para dividir el 100: ");
            Divide(Console.ReadLine());
            Console.ReadKey();
        }

        static void Divide(string num)
        {
            try
            {
                int numero = int.Parse(num);
                int result = 100 / numero;
                Console.WriteLine($"{100} / {numero} = {result}");
            }
            catch (ApplicationException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new ApplicationException($"Se ha generado un error de tipo {ex.GetType().Name}, por favor revise el dato de entrada");
            }
        }
    }
}