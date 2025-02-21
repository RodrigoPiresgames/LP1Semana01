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
        }
    }
}
