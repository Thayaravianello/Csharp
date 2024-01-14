
using System.Globalization;

namespace Projeto15
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;


        //CRIAR O CONSTRUTOR + MESMO NOME DA CLASSE () E SE VAI RECEBER PARAMETRO

        public Produto(string nome, double preco, int quantidade)
        {
            Nome= nome;
            Preco= preco;
            Quantidade= quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos(int quantidade)// VOID POIS NAO VAI RETORNAR VALOR MAS SIM FAZER CALCULO INTERNO
        {
            Quantidade = Quantidade + quantidade; // vai receber a QUANTIDADE maiscula com a quantidade minuscula 
        }

        public void RemoverProdutos(int quantidade)// VOID POIS NAO VAI RETORNAR VALOR MAS SIM FAZER CALCULO INTERNO
        {
            Quantidade = Quantidade - quantidade; // vai receber a QUANTIDADE maiscula com a quantidade minuscula 
        }
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " , "
                + Quantidade + " Unidades , Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            // CRINAOD O OVERRIDE STRING TOSTRING ESTAMOS CRIANDO UMA MENIRA MAIS FACIL DE CONCATENAR
        }



    }
}