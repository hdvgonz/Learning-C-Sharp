using System;

namespace StructureProgrammingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation;
            int firstData;
            int secondData;

            double firstDataD;
            double secondDataD;

            Console.WriteLine("Bienvenido a tu calculadora");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Salir");
            operation = GetIntegerDataFromUser("Proporcione la operación");

            switch (operation)
            {
                case 1:
                    //Suma
                    firstDataD = GetDoubleDataFromUser("Proporcione el primer operando");
                    secondDataD = GetDoubleDataFromUser("Proporciona el segundo operando");
                    Console.WriteLine($"La suma de {firstDataD} + {secondDataD} = {firstDataD + secondDataD}");
                    Console.ReadKey();
                    break;

                case 2:
                    //Resta
                    firstDataD = GetDoubleDataFromUser("Proporcione el primer operando");
                    secondDataD = GetDoubleDataFromUser("Proporciona el segundo operando");
                    Console.WriteLine($"La festa de {firstDataD} - {secondDataD} = {firstDataD - secondDataD}");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Saliendo del Programa");
                    break;
                default:
                    Console.WriteLine("La opción seleccionada no existe.");
                    break;

            }
            Console.WriteLine("Presiona cualquier tecla para Salir...");
            Console.ReadKey();
        }

        private static int GetIntegerDataFromUser(string message)
        {
            string userData;
            int data = 0;
            bool isDataValid = false;

            while (!isDataValid)
            {
                Console.WriteLine(message);
                userData = Console.ReadLine();
                if (!int.TryParse(userData, out data))
                {
                    Console.WriteLine("el dato que proporcionaste no es valido. Vuelve a intentarlo");
                }
                else
                {
                    isDataValid = true;

                }
            }

            return data;
        }

        private static double GetDoubleDataFromUser(string message)
        {
            string userData;
            double data = 0;
            bool isValidData = false;

            while (!isValidData)
            {
                Console.WriteLine(message);
                userData = Console.ReadLine();
                
                if ( !double.TryParse(userData, out data))
                {
                    Console.WriteLine("el dato que proporcionaste no es valido. Vuelve a intentarlo");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    isValidData = true;
                }
            }

            return data;
        }
    }
}