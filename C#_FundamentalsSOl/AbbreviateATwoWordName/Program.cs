namespace AbbreviateATwoWordName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static string AbbrevName(string name)
        {
            string[] newName = name.Split(' ');

            return $"{newName[0].Substring(0,1).ToUpper()}.{newName[01].Substring(0, 1).ToUpper()}";
        }
    }
}

/** 
 Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

The output should be two capital letters with a dot separating them.

It should look like this:

Sam Harris => S.H

patrick feeney => P.F
 */