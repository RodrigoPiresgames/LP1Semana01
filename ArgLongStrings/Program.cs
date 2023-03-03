using System;

namespace ArgLongStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                if (arg.Length > 4)
                {
                    string bigger = arg.ToUpper();
                    Console.WriteLine(bigger);
                }

            }
        }
    }
}
