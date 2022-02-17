using System;
using System.Collections.Generic;
using System.Text;

namespace contagem_de_quatos
{
    public class Pousada

    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public void reserva(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }



        public overide string Tostring()
        {
            return "Quartos ocupados : " +
            Nome + Email
        }

    }

}
