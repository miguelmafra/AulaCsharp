using Modelos;
using System;

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
                        CadastrarCliente();
                        break;
                    case OpcoesMenuPrincipal.PesquisarCliente:
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

            //...Endereço

            return cli;

        }

        private static Cliente PesquisarCliente()
        {
            //TODO : Fazer depois
            return new Cliente();
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
   
    }
}
