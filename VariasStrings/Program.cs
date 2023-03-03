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

            string conca1 = "Hello" + funny;
            string conca2 = "Hello " + 4;

            int x = 10;
            int z = 11;
            int y = 12;

            string xy = $"{x} plus {y} equals {x + y}";

            string mega = String.Format("Eu sou o {x} e o {z}", x, z);

            Console.WriteLine(conca1);
            Console.WriteLine(conca2);
            Console.WriteLine(xy);
            Console.WriteLine(mega);
            Console.WriteLine(@"funny {Simbol}", Simbol);

        }
    }
}
