/*using System.Globalization;

namespace Projeto15
{

    //------------------------------------------------------------------------------------------------------------------------------
    //---------------ENCAPSULAMENTO------------------------------------------------------------------------------------------------
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        //------------------------------------------------------------------------------------------------------------------------------
        //***************GET E SET -- GET PARA PEGAR A CLASSE NOME, SET PARA DAR NOVO NOME--------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------


        public string GetNome() {  return _nome; }

        public void SetNome(string nome)
        {
            _nome = nome;
        }


        //------------------------------------------------------------------------------------------------------------------------------
        //***************CONSTRUTOR PRINCIPAL---->CRIAR O CONSTRUTOR + MESMO NOME DA CLASSE () E SE VAI RECEBER PARAMETRO
        //------------------------------------------------------------------------------------------------------------------------------

        public Produto()
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------]

        //FAZENDO SEGUNDO CONSTRUTOR

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0;// dispensavel pois ja inicia com o valor zero como explicado
        }


        //------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------
        public double ValorTotalEmEstoque()
        {
            return _quantidade * _preco;
        }
        public void AdicionarProdutos(int quantidade)// VOID POIS NAO VAI RETORNAR VALOR MAS SIM FAZER CALCULO INTERNO
        {
            _quantidade = _quantidade + quantidade; // vai receber a QUANTIDADE maiscula com a quantidade minuscula 
        }

        public void RemoverProdutos(int quantidade)// VOID POIS NAO VAI RETORNAR VALOR MAS SIM FAZER CALCULO INTERNO
        {
            _quantidade = _quantidade - quantidade; // vai receber a QUANTIDADE maiscula com a quantidade minuscula 
        }
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " , "
                + _quantidade + " Unidades , Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            // CRINAOD O OVERRIDE STRING TOSTRING ESTAMOS CRIANDO UMA MENIRA MAIS FACIL DE CONCATENAR
        }



    }
}*/