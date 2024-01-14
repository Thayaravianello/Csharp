using System;
using System.Globalization;


namespace Programa9
{
    class Program
    {

        static void Main(string[] args)
        {

            bool c = 2 > 3 && 1 != 5;
            Console.WriteLine(c);

            bool c1 = 3 == 4;
            Console.WriteLine(c1);

            Console.WriteLine("------------------");

            bool c3 = 10 < 5;
            Console.WriteLine(c3);
            bool c4 = c || c3 && c1; // ele primeiro vai calcular o && e depois o ||
            Console.WriteLine(c4);
        }
    }
}