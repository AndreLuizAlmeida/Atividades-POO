using System;
using System.Collections.Generic;

namespace CadastroVacinas
{
    class Funcionario
    {
        public string Nome { get; }
        public string Matricula { get; }
        public string CnpjPrestadora { get; }

        public Funcionario(string nome, string matricula, string cnpjPrestadora)
        {
            Nome = nome;
            Matricula = matricula;
            CnpjPrestadora = cnpjPrestadora;
        }
    }
}
