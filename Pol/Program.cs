using System;

namespace Pol
{
    class Program
    {
        public static int y;
        
        static void Main(string[] args)
        {
            string pols = Console.ReadLine();
            bool ispolindrome = false;
            y = pols.Length ;

            for (int i = 0; i < pols.Length; i++)
            {
                --y;
                if (pols[i] == pols[y])
                {
                    if (i == pols.Length-1)
                    {
                        ispolindrome = true;
                    }
                    continue;
                }
                else
                    break;
            }

            Console.WriteLine(ispolindrome);
        }
    }
}
