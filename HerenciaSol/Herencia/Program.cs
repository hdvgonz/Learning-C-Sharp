namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class A
        {
            public virtual void VirtualMethod()
            {
                //Codigo del metodo
            }
        }

        public class B: A
        {
            public override void VirtualMethod()
            {
               //Codigo que sustituye el codigo base 
            }
        }

        //Los metodos abstractos deben ser Reescritos, es decir las clases derivadas deben invalidarlos
        public abstract class C
        {
            public abstract void Method1();
        }

        public class D: C
        {
            public override void Method1()
            {
                Console.WriteLine("Hablame menor");
            }
        }
    }
}