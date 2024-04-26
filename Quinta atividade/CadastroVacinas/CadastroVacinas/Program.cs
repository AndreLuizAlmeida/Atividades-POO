using System;
using System.Collections.Generic;

namespace CadastroVacinas
{
    class Program
    {
        static void Main(string[] args)
        {
            CadastroService cadastroService = new CadastroService();

            Console.WriteLine("Cadastro de Funcionários:");
            while (true)
            {
                Console.Write("CPF do Funcionário (ou digite 'sair' para finalizar): ");
                string cpf = Console.ReadLine();
                if (cpf.ToLower() == "sair")
                    break;

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("Vacinado (true/false): ");
                bool vacinado = bool.Parse(Console.ReadLine());

                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Matrícula: ");
                string matricula = Console.ReadLine();

                Console.Write("CNPJ da Prestadora de Serviço: ");
                string cnpjPrestadora = Console.ReadLine();

                Funcionario novoFuncionario = new Funcionario(cpf, nome, idade, vacinado, telefone, email, matricula, cnpjPrestadora);
                cadastroService.AdicionarFuncionario(novoFuncionario);
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

                Console.Write("Vacinado (true/false): ");
                bool vacinado = bool.Parse(Console.ReadLine());

                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Cidadao novoCidadao = new Cidadao(cpf, nome, idade, vacinado, telefone, email);
                cadastroService.AdicionarCidadao(novoCidadao);
            }

            Console.WriteLine("\nFuncionários cadastrados:");
            foreach (var funcionario in cadastroService.Funcionarios)
            {
                Console.WriteLine(funcionario);
            }

            Console.WriteLine("\nCidadãos cadastrados:");
            foreach (var cidadao in cadastroService.Cidadaos)
            {
                Console.WriteLine(cidadao);
            }

            Console.ReadLine();
        }
    }
}
