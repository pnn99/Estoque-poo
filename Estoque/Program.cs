using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Refri", 8, 10);

            p.Nome = "Coquinha Gelada hmmm";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Price);
            Console.WriteLine(p.Amount);
        }
    }
}
