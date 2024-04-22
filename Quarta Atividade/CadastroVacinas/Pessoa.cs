using System;
using System.Collections.Generic;

namespace CadastroVacinas
{
    class Pessoa
    {
        public string Nome { get; }
        public int Idade { get; }
        public bool Vacinado { get; }
        public string Telefone { get; }
        public string Email { get; }

        public Pessoa(string nome, int idade, bool vacinado, string telefone, string email)
        {
            Nome = nome;
            Idade = idade;
            Vacinado = vacinado;
            Telefone = telefone;
            Email = email;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Vacinado: {(Vacinado ? "Sim" : "Não")}, Telefone: {Telefone}, Email: {Email}";
        }
    }
}
