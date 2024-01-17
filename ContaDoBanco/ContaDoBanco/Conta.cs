using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDoBanco
{


    //--------------------------------------------------------------------------------------------------------
    //-------------------------------------CLASSE CONTA BANCARIA-------------------------------------------
    internal class ContaBanco
    {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        //--------------------------------------------------------------------------------------------------------
        //-------------------------------------CONSTRUCTOR 2 PARÂMETRO-------------------------------------------
        public ContaBanco(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;

        }


        //--------------------------------------------------------------------------------------------------------
        //-------------------------------------CONSTRUCTOR 3 PARÂMETRO-------------------------------------------
        public ContaBanco(int numero, string titular, double saldo) : this(numero, titular)
        {

            Saldo = saldo;

        }


        //--------------------------------------------------------------------------------------------------------
        //-------------------------------------TO STRING-------------------------------------------

        public void Deposito(double quantia) // VOIDE NAO RETORNA VALOR SO ARMAZENA
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo-= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Numero + " , Titular: " + Titular + ", Saldo: $:  " + Saldo.ToString("F2" , CultureInfo.InvariantCulture);


            //--------FOI ESCRITO ENTRE "" OS NOMES QUE QUEREMOS IMPRESSOS---------------------
            //-----PERCEBA QUE PARA MONSTAR O TEXTO DO CODIGO CHAMAMOS AS VARIAVEIS DA CLASSE-------

        }
    }
}


