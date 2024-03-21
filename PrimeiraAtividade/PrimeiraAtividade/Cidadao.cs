using System;

namespace PrimeiraAtividade
{
    public class Cidadao
    {
        public string Cpf { get; }
        public string Nome { get; }
        public int Idade { get; }
        public bool Vacinado { get; }

        public Cidadao(string cpf, string nome, int idade, bool vacinado)
        {
            Cpf = cpf;
            Nome = nome;
            Idade = idade;
            Vacinado = vacinado;
        }
    }
}
