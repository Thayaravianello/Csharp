using System;
using System.Globalization;

namespace ContaDoBanco
{
    class Program
    {

        //------DECLARAÇÃO DA CONTA BANCARIA CLASSE AQUI---------------------

    
        
        static void Main(string[] args)
        {

            ContaBanco conta;
            ContaBanco deposito;

            Console.Write("Entre com o número da conta:");
            int numero = int.Parse(Console.ReadLine());


            Console.Write( "Entre com o nome do Titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial: s/n: ");
            char resposta = char.Parse(Console.ReadLine());


            if (resposta == 's' || resposta == 'S' )
            {
                Console.Write("Entre com o valor do deposito inicial : ");

                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBanco(numero,titular,depositoInicial);

            } else {
                conta = new ContaBanco(numero, titular);

               
            }


            //**************************DATE ACCOUNT******************************************************************
            //--------------------------------------------------------------------------------------------------------

            Console.WriteLine("");

            Console.WriteLine("DADOS DA CONTA:");


            Console.WriteLine(conta);

            //**************************DATE ACCOUNT - DEPOSIT*********************************************************
            //--------------------------------------------------------------------------------------------------------

            Console.Write( "Entre com o valor para deposito: ");

            double quantia = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            
            

          
            Console.WriteLine();
            //**************************UPDATE ACCOUNT PLUS*****************************************************************
            //--------------------------------------------------------------------------------------------------------

            Console.WriteLine( "DADOS DA CONTA ATUALIZADOS: ");

            Console.WriteLine(conta);

            Console.WriteLine();

            //**************************DATE ACCOUNT MINUS******************************************************************
            //--------------------------------------------------------------------------------------------------------

            Console.Write("Entre com os dados para saque: ");

            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);




            Console.WriteLine(  );

            Console.WriteLine("DADOS DA CONTA ATUALIZADOS: ");

            Console.WriteLine(conta);


        }

    }
}