using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < args.length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
