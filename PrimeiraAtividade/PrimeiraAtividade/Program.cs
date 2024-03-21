using System;
using System.Collections.Generic;

namespace PrimeiraAtividade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> cadastradores = new List<Funcionario>();
            List<Cidadao> cidadaos = new List<Cidadao>();

            Console.WriteLine("Cadastro de Funcionários:");
            while (true)
            {
                Console.Write("Nome do Funcionário (ou digite 'sair' para finalizar): ");
                string nome = Console.ReadLine();
                if (nome.ToLower() == "sair")
                    break;

                Console.Write("Matrícula: ");
                string matricula = Console.ReadLine();

                Console.Write("CNPJ da Prestadora de Serviço: ");
                string cnpjPrestadora = Console.ReadLine();

                Funcionario novoFuncionario = new Funcionario(nome, matricula, cnpjPrestadora);
                cadastradores.Add(novoFuncionario);
            }

            Console.WriteLine("\nCadastro de Cidadãos:");
            while (true)
            {
                Console.Write("CPF do Cidadão (ou digite 'sair' para finalizar): ");
                string cpf = Console.ReadLine();
                if (cpf.ToLower() == "sair")
                    break;

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("Indicação de que foi vacinado (true/false): ");
                bool vacinado = bool.Parse(Console.ReadLine());

                Cidadao novoCidadao = new Cidadao(cpf, nome, idade, vacinado);
                cidadaos.Add(novoCidadao);
            }

            Console.WriteLine("\nFuncionários cadastradores:");
            foreach (var funcionario in cadastradores)
            {
                Console.WriteLine($"Nome: {funcionario.Nome}, Matrícula: {funcionario.Matricula}, CNPJ da Prestadora: {funcionario.CnpjPrestadora}");
            }

            Console.WriteLine("\nCidadãos cadastrados:");
            foreach (var cidadao in cidadaos)
            {
                Console.WriteLine($"CPF: {cidadao.Cpf}, Nome: {cidadao.Nome}, Idade: {cidadao.Idade}, Vacinado: {(cidadao.Vacinado ? "Sim" : "Não")}");
            }

            Console.ReadLine();
        }
    }
}
