using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Störst(100, 101));
        }

        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }

            else if (tal1 < tal2)
            {
                return tal2;
            }

            else
            {
                return tal1;
            }
        }
    }
}