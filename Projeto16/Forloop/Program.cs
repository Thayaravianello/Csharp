using System;



    namespace repeticao
{
    class Program{

        static void Main(string[] args)
        {


            Console.Write("Quantos números inteiros você vai digitar: ");
            int num1 = int.Parse(Console.ReadLine());

            int soma = 0; // inicie com o valor zero

            for (int i = 1; i <= num1; i++) // começamos com o valor um para começar por ela
            {
                Console.Write("Valor #{0}: ", i);// para aparecer automaticamente valor1, valor 2 etc vamos usar o i
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }

            Console.WriteLine("A soma é de: " + soma);

            // ele vai executar primeito o int i = 1

    }   }
}


