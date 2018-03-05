using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {
        private static int Menu()
        {
            Console.WriteLine("Escolha sua opção");
            Console.WriteLine(" - Clientes - ");
            Console.WriteLine("1 - Cadastrar Novo ");
            Console.WriteLine("2 - Pesquisar Cliente ");
            Console.WriteLine("3 - Editar Cliente ");

            Console.WriteLine(" - Geral - ");
            Console.WriteLine("4 - Limpar Tela");
            Console.WriteLine("5 - Sair ");

            //return Convert.ToInt32(Console.ReadLine());
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int opcaodigitada = Menu();

            switch (opcaodigitada)
            {
                case 1:

                    break;
                case 2:
                    break;

                case 3:
                    break;
                case 4:
                    break;
                case 5:

                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
