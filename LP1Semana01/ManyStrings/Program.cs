using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string s = "Um tab\t e um copyright\u03A9";
            string d = "Um tab\t e um copyright\u03A9";

            Console.WriteLine($"{s}");
            Console.WriteLine($"{d}");

            string sd = s + d;
            string s2 = s + 2;

            Console.WriteLine($"{s} jhbcjhbjbh");
            Console.WriteLine($"{sd}");
            Console.WriteLine($"{s}");
            Console.WriteLine($"{s2}");
        }
    }
}
