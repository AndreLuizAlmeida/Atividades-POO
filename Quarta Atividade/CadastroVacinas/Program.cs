using System;
using System.Collections.Generic;

namespace CadastroVacinas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> cadastradores = new List<Pessoa>();
            List<Pessoa> cidadaos = new List<Pessoa>();

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

                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Cidadao novoCidadao = new Cidadao(nome, idade, vacinado, telefone, email);
                cidadaos.Add(novoCidadao);
            }

            Console.WriteLine("\nFuncionários cadastradores:");
            foreach (var funcionario in cadastradores)
            {
                Console.WriteLine(funcionario);
            }

            Console.WriteLine("\nCidadãos cadastrados:");
            foreach (var cidadao in cidadaos)
            {
                Console.WriteLine(cidadao);
            }

            Console.ReadLine();
        }
    }
}
