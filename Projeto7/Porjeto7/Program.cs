using System;

namespace Porjeto7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número");

            int D = int.Parse(Console.ReadLine());

            int diferenca = ((A * B) - (C * D));

            Console.WriteLine($"A diferençã entre os valores de A*B - C*D é de: {diferenca}");
        }
    }
}
