using Controllers;
using Modelos;
using System;
using System.Collections.Generic;

namespace ConsoleView
{
    class Program
    {

        enum OpcoesMenuPrincipal
        {
            CadastrarCliente = 1,
            PesquisarCliente = 2,
            EditarCliente = 3,
            ExluirCliente = 4,
            LimparTela = 5,
            Sair = 6
        }





        private static OpcoesMenuPrincipal Menu()
        {
            Console.WriteLine("Escolha sua opção");
            Console.WriteLine(" - Clientes - ");
            Console.WriteLine("1 - Cadastrar Novo ");
            Console.WriteLine("2 - Pesquisar Cliente ");
            Console.WriteLine("3 - Editar Cliente ");
            Console.WriteLine("4 - Exluir Cliente");

            Console.WriteLine(" - Geral - ");
            Console.WriteLine("5 - Limpar Tela");
            Console.WriteLine("6 - Sair ");


            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal)int.Parse(opcao);
            //     ------Caso for int-----
            //return Convert.ToInt32(Console.ReadLine());
            //return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            OpcoesMenuPrincipal opcaoDigitada = OpcoesMenuPrincipal.Sair;

            //     ------Caso for int-----
            //int opcaoDigitada = 5;
            do
            {
                opcaoDigitada = Menu();

                switch (opcaoDigitada)
                {
                    case OpcoesMenuPrincipal.CadastrarCliente:
                        Cliente cli = CadastrarCliente();
                        ExibirDadosDoCliente(cli);
                        break;
                    case OpcoesMenuPrincipal.PesquisarCliente:
                        PesquisarCliente();
                        break;
                    case OpcoesMenuPrincipal.EditarCliente:
                        break;
                    case OpcoesMenuPrincipal.ExluirCliente:
                        break;
                    case OpcoesMenuPrincipal.LimparTela:
                        LimparTela();
                        break;
                    case OpcoesMenuPrincipal.Sair:
                        break;
                    default:
                        break;
                }

            } while (opcaoDigitada != OpcoesMenuPrincipal.Sair);


        }

        //Metodo Cliente
        private static Cliente CadastrarCliente()
        {
            Cliente cli = new Cliente();
            cli._Endereco = new Endereco();

            Console.Write("Digite o nome: ");
            cli.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite o CPF:  ");
            cli.Cpf = Console.ReadLine();

            Console.Write("Digite o seu endereço: ");
            cli._Endereco.Rua = Console.ReadLine();

            Console.Write("Digite o complemento: ");
            cli._Endereco.Complemento = Console.ReadLine();

            Console.Write("Digite o número da sua casa: ");
            cli._Endereco.Numero = int.Parse(Console.ReadLine());


            return cli;

        }

        private static Cliente PesquisarCliente()
        {
            Console.WriteLine("Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine();

            ClienteController cc = new ClienteController();
            Cliente cli = cc.PesquisarPorNome(nomeCliente);

            if (cli != null)
                ExibirDadosDoCliente(cli);
            else
                Console.WriteLine(" * Cliente não encontrado");
        }

        private static Cliente EditarCliente()
        {
            return new Cliente();
        }
        private static Cliente ExcluirCliente()
        {
            return new Cliente();
        }
        private static void  LimparTela()
        {
            Console.Clear();
        }
        private static void ExibirDadosDoCliente(Cliente cliente)
        {
            Console.WriteLine();
            Console.WriteLine("--- DADOS CLIENTE --- ");
            Console.WriteLine("ID:" + cliente.PessoaID);
            Console.WriteLine("Nome: " + cliente.Nome);
            Console.WriteLine("Cpf: " + cliente.Cpf);

            Console.WriteLine("- Endereco -");
            Console.WriteLine("Rua: " + cliente._Endereco.Rua);
            Console.WriteLine("Num: " + cliente._Endereco.Numero);
            Console.WriteLine("Compl.: " + cliente._Endereco.Complemento);
            Console.WriteLine("-------------- ");
            Console.WriteLine();

        }

        private static void ListarTodosClientes()
        {
            Console.WriteLine();
            Console.WriteLine(" --- Clientes cadastrados --- ");

            ClienteController cc = new ClienteController();
            List<Cliente> lista = cc.ListarClientes();

            if (lista.Count == 0)
            {
                Console.WriteLine(" * Ainda nao existem clientes cadastrados");
            }
            else
            {
                foreach (Cliente cli in lista)
                {
                    ExibirDadosDoCliente(cli);
                }
            }
            Console.WriteLine();
        }
    }
}




