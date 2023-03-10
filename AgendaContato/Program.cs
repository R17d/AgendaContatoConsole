using System;
using System.Collections.Generic;

namespace AgendaTelefonica
{
    class Program
    {
        static Dictionary<string, string> contatos = new Dictionary<string, string>();

        public static void Main()
        {
            bool sair = false;
            while (sair == false)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Adicionar contato");
                Console.WriteLine("2 - Listar contatos");
                Console.WriteLine("3 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("\nDigite o nome do contato: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o telefone do contato: ");
                    string telefone = Console.ReadLine();
                    adicionarContato(nome, telefone);
                }
                else if (opcao == 2)
                {
                    listarContatos();
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("\nEncerrando programa...");
                    sair = true;
                }
                else
                {
                    Console.WriteLine("\nOpção inválida. Digite novamente.");
                }
            }
        }

        public static void adicionarContato(string nome, string telefone)
        {
            contatos.Add(nome, telefone);
            Console.WriteLine("\nContato adicionado com sucesso!");
        }

        public static void listarContatos()
        {
            if (contatos.Count == 0)
            {
                Console.WriteLine("\nNão há contatos cadastrados.");
                return;
            }

            Console.WriteLine("\nLista de contatos:");

            SortedDictionary<string, string> listaOrdenada = new SortedDictionary<string, string>(contatos);
            foreach (KeyValuePair<string, string> contato in listaOrdenada)
            {
                Console.WriteLine($"{contato.Key}: {contato.Value}");
            }
        }
    }
}