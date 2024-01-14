using StaticMembers2;
using System;
using System.Globalization;

namespace Statico
{
    class ProgramClasse
    {

        //**************************VERSÃO COM CLASSE**************************************************************************


        static void Main(string[] args) //

        {
            Calculadora calc = new Calculadora();// ------------------>CHAMADA DA FUNÇÃO

            //---> AGORA TEMOS QUE CHAMAR A CALC DENTRO ABAIXO

            Console.WriteLine("Entre com o valor do raio: ");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.circunferencia(r);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = calc.Volume(r);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }



    }
}

