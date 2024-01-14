using System;

namespace Projeto11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um horário do dia entre 8,12 e 18");
            Console.WriteLine("Lembrando que 8 é Bom dia, 12 Boa tarde e 18 Boa noite");

            int x = int.Parse(Console.ReadLine());

            if (x == 8)
            {
                Console.WriteLine("Bom dia");

            }
            else if (x == 12)
            {

                Console.WriteLine("Boa tarde");

            }
            else if (x == 18) 
            {
                Console.WriteLine("Boa noite");
            }
            else
            {
                Console.WriteLine("O valor digitado não é valido");
            }

        }

    }
}

