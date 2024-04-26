using System;
using System.Collections.Generic;

namespace CadastroVacinas
{
    class Pessoa
    {
        public string Cpf { get; }
        public string Nome { get; }
        public int Idade { get; }
        public bool Vacinado { get; private set; }
        public string Telefone { get; }
        public string Email { get; }
        public DateTime? Agendamento { get; set; }
        public Funcionario ResponsavelAgendamento { get; set; }
        public Funcionario ResponsavelVacinacao { get; set; }

        public Pessoa(string cpf, string nome, int idade, bool vacinado, string telefone, string email)
        {
            Cpf = cpf;
            Nome = nome;
            Idade = idade;
            Vacinado = vacinado;
            Telefone = telefone;
            Email = email;
        }

        public virtual void AgendarVacinação(DateTime data, Funcionario responsavel)
        {
            Agendamento = data;
            ResponsavelAgendamento = responsavel;
        }

        public virtual void Vacinar(Funcionario responsavel)
        {
            Vacinado = true;
            ResponsavelVacinacao = responsavel;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Vacinado: {(Vacinado ? "Sim" : "Não")}, Telefone: {Telefone}, Email: {Email}, Agendamento: {Agendamento}";
        }
    }
}
