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

            float float_1 = 9.999f;
            float float_2 = 8.888f;

            Console.WriteLine($"{float_1}");
            Console.WriteLine($"{float_2}");

            bool bool_1 = true;
            bool bool_2 = false;

            Console.WriteLine($"{bool_1}");
            Console.WriteLine($"{bool_2}");

            
        }
    }
}
