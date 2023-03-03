using System;

namespace ArgInt2Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {

                int intArg;
                bool isInt = int.TryParse(args[i], out intArg);

                if(isInt == true)
                {
                    Console.WriteLine("{0} -> É inteiro, valor hexadecimal: {0:x}", intArg);
                }
                if(isInt == false)
                {
                    Console.WriteLine(@"{0} -> Não é inteiro", intArg);
                }
            }
        }
    }
}
