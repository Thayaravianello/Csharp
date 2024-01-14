//Operadores de atribuição  Crtl + K + D

using System;

namespace Projeto3
{

    class Program
    {
        static void Main(string[] args)
        {

            double a = 1.0;
            double b = -3.0;
            double c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a); // precisa dos parentenses para dar a precedência, primeiro ele vai calcular o delta e depois ele irá calcular 2*a e entao /
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);// raiz 2

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }

    }





}
