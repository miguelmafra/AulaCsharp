﻿using Controllers;
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
            ListarClientesCadastrados = 3,
            EditarCliente = 4,
            ExcluirCliente = 5,
            LimparTela = 6,
            Sair = 7
        }

        private static OpcoesMenuPrincipal Menu()
        {
            Console.WriteLine("Escolha sua opcao");
            Console.WriteLine("");

            Console.WriteLine(" - Clientes - ");
            Console.WriteLine("1 - Cadastrar Novo");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Listar Clientes Cadastrados");
            Console.WriteLine("4 - Editar Cliente");
            Console.WriteLine("5 - Excluir Cliente");

            Console.WriteLine(" - Geral -");
            Console.WriteLine("6 - Limpar Tela");
            Console.WriteLine("7 - Sair");

            //return Convert.ToInt32(Console.ReadLine());
            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal)int.Parse(opcao);
        }
        static void Main(string[] args)
        {
            OpcoesMenuPrincipal opcaoDigitada =
                OpcoesMenuPrincipal.Sair;

            do
            {
                opcaoDigitada = Menu();

                switch (opcaoDigitada)
                {
                    case OpcoesMenuPrincipal.CadastrarCliente:
                        Cliente c = CadastrarCliente();

                        ClienteController cc = new ClienteController();
                        cc.SalvarCliente(c);

                        ExibirDadosCliente(c);
                        break;
                    case OpcoesMenuPrincipal.PesquisarCliente:
                        PesquisarCliente();
                        break;

                    case OpcoesMenuPrincipal.ListarClientesCadastrados:
                        ListarTodosClientes();
                        break;
                    case OpcoesMenuPrincipal.EditarCliente:
                        break;
                    case OpcoesMenuPrincipal.ExcluirCliente:
                        ExcluirCliente();
                        break;
                    case OpcoesMenuPrincipal.LimparTela:
                        break;
                    case OpcoesMenuPrincipal.Sair:
                        break;
                    default:
                        break;
                }

            } while (opcaoDigitada != OpcoesMenuPrincipal.Sair);

        }

        private static void ExcluirCliente()
        {
            Console.WriteLine("Digite o id do cliente que deseja excluir: ");
            int idCliente = int.Parse(Console.ReadLine());

            ClienteController cc = new ClienteController();
            cc.ExcluirCliente(idCliente);
        }

        // Metodos Cliente
        private static Cliente CadastrarCliente()
        {
            Cliente cli = new Cliente();

            Console.Write("Digite o nome: ");
            cli.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite o cpf: ");
            cli.Cpf = Console.ReadLine();

            Endereco end = CadastrarEndereco();

            return cli;
        }

        private static Endereco CadastrarEndereco()
        {
            EnderecoController ec = new EnderecoController();
            Endereco end = new Endereco();

            Console.Write("Digite o nome da rua: ");
            end.Rua = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite o numero: ");
            end.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite o complemento: ");
            end.Complemento = Console.ReadLine();

            return end;

        }

        private static void PesquisarCliente()
        {
            Console.WriteLine("Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine();

            ClienteController cc = new ClienteController();
            Cliente cli = cc.PesquisarPorNome(nomeCliente);

            if (cli != null)
                ExibirDadosCliente(cli);
            else
                Console.WriteLine(" * Cliente não encontrado");
        }

        private static void ExibirDadosCliente(Cliente cliente)
        {
            Console.WriteLine();
            Console.WriteLine("--- DADOS CLIENTE --- ");
            Console.WriteLine("ID:" + cliente.PessoaId);
            Console.WriteLine("Nome: " + cliente.Nome);
            Console.WriteLine("Cpf: " + cliente.Cpf);

            ExibirDadosEndereco(cliente.EnderecoId);

        }

        private static void ExibirDadosEndereco (int id)
        {
            EnderecoController ec = new EnderecoController();
            Endereco e = ec.PesquisarPorID(id);

            Console.WriteLine("- Endereco -");
            Console.WriteLine("Rua: " + e.Rua);
            Console.WriteLine("Num: " + e.Numero);
            Console.WriteLine("Compl.: " + e.Complemento);
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
                    ExibirDadosCliente(cli);
                }
            }
            Console.WriteLine();
        }

        private static void EditarCliente()
        {
            Console.WriteLine("-- Editar Cliente --");
            ListarTodosClientes();

            Console.WriteLine("Digite o ID do cliente para ser editado");

            int idCliente = int.Parse(Console.ReadLine());
            ClienteController cc = new ClienteController();

            Cliente cli = cc.PesquisarPorID(idCliente);

            if (cli != null)
            {
                Console.WriteLine("Digite o nome do cliente: ");
                cli.Nome = Console.ReadLine();

                Console.WriteLine("Digite o cpf desejado: ");
                cli.Cpf = Console.ReadLine();

                Endereco e = AlterarEndereco(cli.EnderecoId);


            }
            else
            {
                Console.WriteLine("Cliente não encontrado");
            }

        }
        private static Endereco AlterarEndereco(int id)
        {
            EnderecoController ec = new EnderecoController();
            Endereco e = ec.PesquisarPorID(id);

            Console.WriteLine("Informe o nome da rua: ");
            e.Rua = Console.ReadLine();

            Console.WriteLine("Informe o número: ");
            e.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o complemento: ");
            e.Complemento = Console.ReadLine();

            return e;

        }
    }
}