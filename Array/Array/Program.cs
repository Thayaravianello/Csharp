using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira quantas alturas você irá digitar:");
            int N = int.Parse(Console.ReadLine());


            //CRIAR O VETOR----------------------------------------------------------------
            //-----------------------------------------------------------------------------

            double[] vect = new double[N]; // dentro do [] é a quantidade de caixinhas do vetor

            //FAZER O LOPP PARA ARMAZENAR OS VALORES NAS CAIXINHAS---------------------------
            //------------------------------------------------------------------------------


            for (int i = 0; i < N; i++)
            {

                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            }

            //CRIAR O CALCULO DA MEDIA-------------------------------------------------------
            //--------------------------------------------------------------------------------

            double soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                soma += vect[i];

            }

            //------CRIANDO O CALCULO DA MEDIA APOS TER TIDO OS VALORES ARMAZENADOS-------------
            //---------------------------------------------------------------------------------

            double media = soma /N;

            Console.WriteLine("AVERAGE HEIGHT = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}