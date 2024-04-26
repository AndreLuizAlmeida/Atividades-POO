using System;
using System.Collections.Generic;

namespace CadastroVacinas
{
    class Funcionario : Pessoa
    {
        public string Matricula { get; }
        public string CnpjPrestadora { get; }

        public Funcionario(string cpf, string nome, int idade, bool vacinado, string telefone, string email, string matricula, string cnpjPrestadora)
            : base(cpf, nome, idade, vacinado, telefone, email)
        {
            Matricula = matricula;
            CnpjPrestadora = cnpjPrestadora;
        }

        public override void AgendarVacinação(DateTime data, Funcionario responsavel)
        {
            base.AgendarVacinação(data, responsavel);
        }

        public override void Vacinar(Funcionario responsavel)
        {
            base.Vacinar(responsavel);
        }

        public override string ToString()
        {
            return base.ToString() + $", Matrícula: {Matricula}, CNPJ da Prestadora: {CnpjPrestadora}";
        }
    }
}
