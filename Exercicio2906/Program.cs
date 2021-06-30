using Exercicio2906.Entities;
using Exercicio2906.Repositories;
using System;

namespace Exercicio2906
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n-------BANCO DE DADOS---------\n");
                Console.WriteLine("(1) Cadastrar Funcionario-----");
                Console.WriteLine("(2) Excluir   Funcionario-----");
                Console.WriteLine("(3) Consultar Funcionario-----");
                Console.WriteLine("(4) Atualizar Funcionario-----");
                Console.WriteLine("(5) Sair----------------------");
                Console.WriteLine("------------------------------\n");
                Console.Write("Digite o número desejado: ");
                var numero = int.Parse(Console.ReadLine());
                Console.Clear();

                if (numero == 1)
                {
                    var funcionario = new Funcionario();
                    var funcionarioRepository = new FuncionarioRepository();

                    Console.WriteLine("\n-------TELA DE CADASTRO---------\n");

                    Console.Write("Nome: ");
                    funcionario.Nome = Console.ReadLine();

                    Console.Write("Cpf: ");
                    funcionario.Cpf = Console.ReadLine();

                    Console.Write("Matricula: ");
                    funcionario.Matricula = Console.ReadLine();

                    Console.Write("DataAdmissao: ");
                    funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                    funcionarioRepository.Inserir(funcionario);

                    Console.WriteLine("\nCADASTRADO COM SUCESSO!!! \n");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                }
                else if (numero == 2)
                {
                    var funcionario = new Funcionario();
                    var funcionarioRepository = new FuncionarioRepository();

                    Console.WriteLine("\n-------TELA DE DELET---------\n");
                    Console.Write("Digite o CPF que deseja excluir : ");

                    funcionario.Cpf = Console.ReadLine();

                    funcionarioRepository.Excluir(funcionario);

                    Console.WriteLine("\nEXCLUIDO COM SUCESSO!!!! \n");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                }
                else if (numero == 3)
                {
                    Console.WriteLine("\n-------LISTA DE CLIENTE---------\n");
                    var funcionarioRepository = new FuncionarioRepository();
                    foreach (var item in funcionarioRepository.Consultar())
                    {
                        Console.WriteLine("Id do Funcionario: " + item.IdFuncionario);
                        Console.WriteLine("Nome: " + item.Nome);
                        Console.WriteLine("CPF: " + item.Cpf);
                        Console.WriteLine("Matricula: " + item.Matricula);
                        Console.WriteLine("Data de Admissao: " + item.DataAdmissao);
                        Console.WriteLine("________________________________________" +
                                          "__________________\n");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                }
                else if (numero == 4)
                {
                    var funcionarioRepository = new FuncionarioRepository();
                    var funcionario = new Funcionario();

                    Console.WriteLine("\n-------TELA DE ATUALIZAÇÃO---------\n");

                    Console.Write("Digite o ID do funcionario: ");
                    funcionario.IdFuncionario = Guid.Parse(Console.ReadLine());

                    Console.Write("Nome: ");
                    funcionario.Nome = Console.ReadLine();

                    Console.Write("Cpf: ");
                    funcionario.Cpf = Console.ReadLine();

                    Console.Write("Matricula: ");
                    funcionario.Matricula = Console.ReadLine();

                    Console.Write("DataAdmissao: ");
                    funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                    funcionarioRepository.Atualizar(funcionario);

                    Console.WriteLine("\nAtualizado com sucesso!!! \n");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                }
                else if (numero == 5)
                {
                    Console.WriteLine("\nAperte em qualquer tecla para finalizar o programa...\n");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nDIGITE UM NÚMERO VÁLIDO...\n");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }



        }
    }
}
