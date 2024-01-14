using System;

namespace Projeto6
{

    class Program
    {
        static void Main(string[] args)
        {

            double R;
            double A;
            double pi = 3.14159;

            Console.WriteLine("Digite o raio");
            R = double.Parse(Console.ReadLine());


            A = pi * R * R;

            Console.WriteLine($" A área do circulo é de:{A}");







        }

    }


}
