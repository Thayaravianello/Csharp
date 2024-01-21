using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelQuartos
{
    class Cadastro
    {

        public string Name { get; set; }
        public string Email { get; set; }

        public Estudante (string nome, string email)
        {
            Name = nome;
            Email = email;
        }

        public override string Tostring()
        {
            return Name + " , " + Email;
        }


    }
}
