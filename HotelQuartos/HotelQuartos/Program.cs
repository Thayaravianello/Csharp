using System;
using System.Globalization;


namespace Aluguel
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Quantos quartos serão registrados: ");
            int quartos = int.Parse(Write.ReadLine());

            Cadastro[] vetor = new Cadastro[quartos];

            for (i = 0; i < quartos; i++)

            {
                Console.Write(" Digite o número do quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                Console.Write(" Digite o nome do estudante: ");
                string nome = Console.ReadLine();

                Console.Write(" Digite o E-mail do estudante: ");
                string email = Console.ReadLine();

                vetor[i] = new Cadastro { Name = nome, Email = email };

                switch (numeroQuarto)
                {
                    case 1:
                        numeroQuarto = 1;

                        Console.WriteLine("Quarto 1 reservado");
                        break;
                    case 2:
                        numeroQuarto = 2;

                        Console.WriteLine("Quarto 2 reservado");
                        break;

                    case 3:
                        numeroQuarto = 3;

                        Console.WriteLine("Quarto 3 reservado");
                        break;

                    case 4:
                        numeroQuarto = 4;

                        Console.WriteLine("Quarto 4 reservado");
                        break;

                    case 5:
                        numeroQuarto = 5;

                        Console.WriteLine("Quarto 5 reservado");
                        break;

                    case 6:
                        numeroQuarto = 6;

                        Console.WriteLine("Quarto 6 reservado");
                        break;

                    case 7:
                        numeroQuarto = 7;

                        Console.WriteLine("Quarto 7 reservado");
                        break;

                    case 8:
                        numeroQuarto = 8;

                        Console.WriteLine("Quarto 8 reservado");
                        break;

                    case 9:
                        numeroQuarto = 9;
                        Console.WriteLine("Quarto 9 reservado");
                        break;

                    case 10:
                        numeroQuarto = 10;
                        Console.WriteLine("Quarto 10 reservado");
                        break;


                }



            }

            Console.WriteLine("Quantos ocupados: ");

            for (i = 0; i < quartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");

                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }




        }
    }
}
