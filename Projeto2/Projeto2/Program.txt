using System;
using System.Globalization;


namespace Porjeto2
{
     class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine( $" {produto1}, cujo o preço é R$ { preco1}");
            Console.WriteLine( $"{ produto2}, cujo o preço é de R$ { preco2}" );
            Console.WriteLine();
            Console.WriteLine("Registro:");
            Console.WriteLine( $"  { idade}, anos de idade, código { codigo}, e gênero:{ genero}");
            Console.WriteLine();
            Console.WriteLine( "Medida com oito casas decimais:{0:F8}", medida);
            Console.WriteLine( "Arredondamento(Três casas decimais):{0:F3}", medida);
            Console.WriteLine( "Separador decimar invariant culture:" + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}