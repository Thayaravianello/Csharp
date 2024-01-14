using System;

namespace Projeto4
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o horário do dia");
            string frase = Console.ReadLine();

            Console.WriteLine("Digite uma cor");
            string x = Console.ReadLine();

            Console.WriteLine("Digite outra cor");
            string y = Console.ReadLine();

            Console.WriteLine("Digite uma terceira cor");
            string z = Console.ReadLine();

            Console.WriteLine("Digite três cores diferentes");
            string cor = Console.ReadLine(); // primeiro se cria a readline e depois criamos o SPLIT
            string[] v = cor.Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou o horário do dia como:" + frase + " , a primeira cor foi " + x + " , a 2º cor: " + y + " , a 3º cor: " + z + " ,as ultimas 3 cores são :" + cor);

            // outra forma de criar o Split vetor é ao inves de criar uma string console readline e depois o split vc pode criar junto
            // string[] v = Console.ReadLine.Split(' '); e depois cria as posições

        }
    }
}
