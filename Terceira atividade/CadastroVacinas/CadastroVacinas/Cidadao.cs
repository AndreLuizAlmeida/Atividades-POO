using System;
using System.Collections.Generic;

namespace CadastroVacinas
{
    class Cidadao
    {
        public string Cpf { get; }
        public string Nome { get; }
        public int Idade { get; }
        public bool Vacinado { get; }
        public string Telefone { get; }
        public string Email { get; }
        public DateTime? Agendamento { get; set; }

        public Cidadao(string cpf, string nome, int idade, bool vacinado, string telefone, string email)
        {
            Cpf = cpf;
            Nome = nome;
            Idade = idade;
            Vacinado = vacinado;
            Telefone = telefone;
            Email = email;
        }

        public void AgendarVacina(DateTime data)
        {
            Agendamento = data;
        }
    }
}
