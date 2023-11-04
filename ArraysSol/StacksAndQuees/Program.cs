using System;
using System.Collections;

namespace StacksAndQuees
{
    internal class Programws
    {
        static void Main(string[] args)
        {
            //Pilas / Stacks

            string word;
            int counter;
            Stack greetingStack;

            //Usando Push y POP
            Console.ForegroundColor = ConsoleColor.Green;
            greetingStack = new Stack();
            greetingStack.Push("Hola");
            greetingStack.Push("Dani");
            greetingStack.Push("Buenos");
            greetingStack.Push("Días");

            counter = greetingStack.Count;
            Console.WriteLine($"La pila tiene {counter} elementos");

            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingStack.Pop();
                Console.WriteLine($"Pop: {word}");
            }

            //Usando PEEK
            Console.ForegroundColor = ConsoleColor.Magenta;
            greetingStack.Push("Hola");
            greetingStack.Push("Dani");
            greetingStack.Push("Buenos");
            greetingStack.Push("Días");

            counter = greetingStack.Count;
            Console.WriteLine($"La pila tiene {counter} elementos");

            for (int i = 0; i < counter; i++)
            {
                word = (string?)greetingStack.Pop();
                Console.WriteLine($"Pop: {word}");

                if (greetingStack.Count > 0)
                {
                    word = (string?)greetingStack.Peek();
                    Console.WriteLine($"La siguiente palabra es: {word}");
                }
                else
                {
                    Console.WriteLine("No hay más elementos en la pila.");
                }


            }

            //Metodo Contains y Clear;
            Console.ForegroundColor = ConsoleColor.White;
            greetingStack.Push("Hola");
            greetingStack.Push("Dani");
            greetingStack.Push("Buenos");
            greetingStack.Push("Días");

            if (greetingStack.Contains("Días"))
            {
                greetingStack.Clear();
            }

            Console.WriteLine($"La pila greetingStack contiene {greetingStack.Count} ekementos luego de ejecutar el metodo Clear()");


            //Colas o Queue

            Console.ForegroundColor = ConsoleColor.Cyan;
            Queue greetingQueue = new Queue();

            greetingQueue.Enqueue("Dani");
            greetingQueue.Enqueue("Buenos");
            greetingQueue.Enqueue("Días");
            greetingQueue.Enqueue("Hola");

            counter = greetingQueue.Count;

            Console.WriteLine($"Hay {greetingQueue.Count} elementos en la cola");

            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingQueue.Peek();
                Console.WriteLine($"El siguiente valor en la cola es {word}");

                word = (string?)greetingQueue.Dequeue();
                Console.WriteLine($"Dequeue: {word}");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            greetingQueue.Enqueue("Dani");
            greetingQueue.Enqueue("Buenos");
            greetingQueue.Enqueue("Días");
            greetingQueue.Enqueue("Hola");

            if (greetingQueue.Contains("Días"))
            {
                greetingQueue.Clear();
            }

            Console.WriteLine($"La Cola greetingQueue contiene {greetingQueue.Count} ekementos luego de ejecutar el metodo Clear()");

            Console.ReadKey();
        }
    }
}