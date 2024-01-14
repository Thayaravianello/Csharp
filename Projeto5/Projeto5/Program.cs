using System;


namespace Projeto5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número:");
            int num1 = int.Parse( Console.ReadLine());

            Console.WriteLine("Digite um segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            Console.WriteLine($"A soma dos números é de:{soma}");
        }
    }
}