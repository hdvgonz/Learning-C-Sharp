using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPractica1
{
    public sealed class Book : Publication
    {
        public string ISBN { get; }
        public string Author { get; }

        public decimal Price { get; private set; }

        public string Currency { get; private set; }

        public Book(string title, string isbn, string author, string publisher) : base(title, publisher, PublicationType.Book)
        {
            if (!String.IsNullOrEmpty(isbn))
            {

                if (!(isbn.Length == 10 | isbn.Length == 13))
                {
                    throw new ArgumentException("El ISBN debe ser de 10 a 13");
                }
                ulong nISBN = 0;

                if (!UInt64.TryParse(isbn, out nISBN))
                {
                    throw new ArgumentException("El ISBN consiste de caracteres númericos solamente");
                }

            }

            ISBN = isbn;
            Author = author;



        }
    }
}