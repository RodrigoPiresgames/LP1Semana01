using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string funny = "Funny";
            string Simbol = "\u01A9";
            string Simbol_literal = @"\u01A9";
            string barras = "\\barra\\barra\\barra";

            Console.WriteLine(funny);
            Console.WriteLine(Simbol);
            Console.WriteLine(Simbol_literal);
            Console.WriteLine(barras);
        }
    }
}
