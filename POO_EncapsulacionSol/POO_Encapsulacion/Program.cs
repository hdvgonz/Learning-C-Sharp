namespace POO_Encapsulacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass sample =  new SampleClass();
            sample.firstName = "Daniel";
            sample.lastName = "Gonzalez";

            Console.WriteLine(sample.getFullName());

            Console.ReadKey();
        }

        public class SampleClass
        {
            private string _lastName;
            public string firstName { get; set; }
            public string lastName
            { get { return _lastName; } set { _lastName = value; } }
            
            public SampleClass()
            {
                firstName = "Sin nombre";
            }

            public SampleClass( string firstName, string lastName )
            {
                this.firstName = firstName;
                this._lastName = lastName;
            }

            public string getFullName()
            {
                return $"{firstName} {_lastName}";
            }

            //Limpia la instancia de la clase
            ~SampleClass()
            {
                Console.WriteLine("El finalizador se está ejecutando");
            }
        }
    }
}