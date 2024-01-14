using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers2
{

    //********************************CALCULADORA CLASSE
    class Calculadora
    {

        public double Pi = 3.14;

        //************************CIRCUNFERÊNCIA***************************
        public double circunferencia(double raio)
        {
            return raio * Pi * 2.0;
        }


        //******************************VOLUME******************************

        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }

    }
}

