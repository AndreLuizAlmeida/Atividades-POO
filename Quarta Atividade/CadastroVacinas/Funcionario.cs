using System;
using System.Collections.Generic;

namespace CadastroVacinas
{
    class Funcionario : Pessoa
    {
        public string Matricula { get; }
        public string CnpjPrestadora { get; }

        public Funcionario(string nome, string matricula, string cnpjPrestadora)
            : base(nome, 0, false, "", "") 
        {
            Matricula = matricula;
            CnpjPrestadora = cnpjPrestadora;
        }

        public override string ToString()
        {
            return base.ToString() + $", Matrícula: {Matricula}, CNPJ da Prestadora: {CnpjPrestadora}";
        }
    }
}
