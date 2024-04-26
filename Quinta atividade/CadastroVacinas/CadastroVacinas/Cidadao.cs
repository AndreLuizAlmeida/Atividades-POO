using System;
using System.Collections.Generic;

namespace CadastroVacinas
{
    class Cidadao : Pessoa
    {
        public Cidadao(string cpf, string nome, int idade, bool vacinado, string telefone, string email)
            : base(cpf, nome, idade, vacinado, telefone, email)
        {
        }

        public override void AgendarVacinação(DateTime data, Funcionario responsavel)
        {
            base.AgendarVacinação(data, responsavel);
        }

        public override void Vacinar(Funcionario responsavel)
        {
            base.Vacinar(responsavel);
        }
    }
}
