namespace SampleNestleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Container.Nested nestedInstance = new Container.Nested();
        }

        class Container
        {
            public class Nested
            {

            }
        }
    }
}