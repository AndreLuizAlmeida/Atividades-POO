using System;
using System.Collections.Generic;

namespace CadastroVacinas
{
    class Cidadao : Pessoa
    {
        public Cidadao(string nome, int idade, bool vacinado, string telefone, string email)
            : base(nome, idade, vacinado, telefone, email)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
