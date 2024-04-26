using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVacinas
{
    class CadastroService
    {
        private List<Funcionario> funcionarios;
        private List<Cidadao> cidadaos;

        public CadastroService()
        {
            funcionarios = new List<Funcionario>();
            cidadaos = new List<Cidadao>();
        }

        public List<Funcionario> Funcionarios { get { return funcionarios; } }
        public List<Cidadao> Cidadaos { get { return cidadaos; } }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

        public void AdicionarCidadao(Cidadao cidadao)
        {
            cidadaos.Add(cidadao);
        }
    }
}
