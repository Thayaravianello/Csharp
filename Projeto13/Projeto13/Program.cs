using Projeto13;
using System;
using System.Globalization;

namespace orientacaoObject
{

    class Program
    {

        static void Main(string[] args)
        {
            Triangulo  x, y;
            x = new Triangulo(); // PRECISA SER DECLARADA NEW E COLOCAR O PARENTESES
            y = new Triangulo();


            Console.WriteLine("Digite as medidas do triângulo X :");

             x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Digite as medidas do triângulo Y :");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /* double p = (x.A + x.B + x.C) / 2.0;
             double areax = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

             p = (y.A + y.B + y.C) / 2.0;
             double areay = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));*/ //MODO SEM METODO 

            double areaX = x.Area();
            double areaY = y.Area();

            //AQUI FIEMOS UMA VARIAVEL NOVA AREA X E DEPOIS CHAMAMOS O METODO CRIADO NA CLASSE

            Console.WriteLine("A área do triângulo X é de:" + areax.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A área do triângulo Y é de:" + areay.ToString("F2", CultureInfo.InvariantCulture));


            // calculo do perimetro  p= (a+b+c)/2  e area= raiz quadrada de p(p-a)(p-b)(p-c)

            if (areax > areay)
            {
                Console.WriteLine("Maior área é do triângulo X");

            }
            else Console.WriteLine("Maior área é do triângulo Y");
            {

            }
        }
    }
}