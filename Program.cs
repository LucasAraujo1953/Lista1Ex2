using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Informe a aresta do quadrado: ");
            a=int.Parse(Console.ReadLine());

            b = a * a;
            Console.WriteLine("O valor da aresta do quadrado é {0}, com isso, sua área é igual a {1}", a, b);
        }
    }
}
