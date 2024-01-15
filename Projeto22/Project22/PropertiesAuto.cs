using System.Collections.Generic;
using System.Globalization;

namespace Projeto15
{

    //------------------------------------------------------------------------------------------------------------------------------
    //---------------PROPERTIES AUTO------------------------------------------------------------------------------------------------
    class Produto
    {
        public string _nome;// NO OUTRO CÓDIGO TEM O IF POR ISSO NÃO SERÁ ALTERADO AQUI, TODA VEZ  Q POSSUIR UMA CONDIÇÃO DEVE SER FEITO COMO NO EXEMPLOS ANTERIORES
        public int Preco { get; private set; }
        public double Quantidade { get; private set; }


        //ATALHO: PROMP TAB TAB MONTA JA A ESTRUTURA
        public int MyProperty { get; set; }

        //------------------------------------------------------------------------------------------------------------------------------
        // GET É PERMITIDO, VEM COMO PUBLIC E SET PRIVADO, SEM PODER ALTERAR-----------
        //------------------------------------------------------------------------------------------------------------------------------

        // public double preco { get; private set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {

                    _nome = value;
                }
            }
        }
    }
}