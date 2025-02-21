using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Give num int");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give num float");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{num1 + num2}");

        }
    }
}
