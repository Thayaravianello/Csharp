using System;
using System.Globalization;

namespace Statico
{
    class Program
    {

        //********** PI************************************************************************************
        static double Pi = 3.14; //FORA DO STATIC MAIN

        //***************************************************************************************************

        //********************CÓDIGO PRINCIPAL***************************************************************
        static void Main(string[] args) // IREMOS CRIAR AS FUNÇÕES PARA PI E PARA A CIRCUNFERÊNCIA

        {
            Console.WriteLine("Entre com o valor do raio: ");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = circunferencia(r);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Volume(r);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        //***************************************************************************************************


        //********************************FUNÇÕES ESTÁTICAS**************************************************

        static double circunferencia(double raio)
        {
            return raio * Pi * 2.0;
        } // AQUI FOI CRIADA A FUNÇÃO CIRCUNFERENCIA

        static double Volume(double r)
        {
            return 4.0/3.0 * Pi * Math.Pow(r, 3.0);
        }

        //****************************************************************************************************
    }
}


//2*pi*raio