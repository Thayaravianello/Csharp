using System;

namespace Projeto14
{
    class Program
    {

        static void Main(string[] args)

        {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa :");
            Console.WriteLine("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade :");
            p1.Idade = int.Parse( Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa :");
            Console.WriteLine("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade :");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine(p1.Nome + " é  a(o) mais velha (o)");
            } else
            {
                Console.WriteLine(p2.Nome + " é  a(o) mais velha (o)");
            }

        }
    }
}
