using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            
            Console.WriteLine("Insere 4 números reais entre 0 e 1:");

            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float num3 = float.Parse(Console.ReadLine());
            float num4 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{num1,8:p2}");
            Console.WriteLine($"{num2,8:p2}");
            Console.WriteLine($"{num3,8:p2}");
            Console.WriteLine($"{num4,8:p2}");
        }
    }
}
