using System;
using System.Runtime.CompilerServices;

namespace VariouTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int int_1 = 9;
            int int_2 = 8;

            Console.WriteLine($"{int_1}");
            Console.WriteLine($"{int_2}");

            char crown = '\u2655';
            char revolt = '\u262D';

            Console.WriteLine($"{crown}");
            Console.WriteLine($"{revolt}");
        }
    }
}
