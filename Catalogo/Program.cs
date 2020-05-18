using Catalogo.controllers;
using Catalogo.models;
using Catalogo.models.prestadorServicos;
using Catalogo.models.vendedor;
using Catalogo.models.vendedor.produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Program
    {
        static void Main(string[] args)
        {
            IniciarCarga();
            string sair = "0";
            do {
                int opcao = 0;
                Console.WriteLine("Bem vindo ao sistema de catálogo de vendedores e prestadores de serviços:\n" +
                    $"Atualmente o sistema tem {Cliente.quantidadeCliente} clientes");
                Console.WriteLine($"Que operação deseja executar?\n" +
                    $"1. Para inserir novo cliente\n" +
                    $"2. Para listar todos os clientes\n" +
                    $"3. Para Listar por categoria\n");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Inserir novo cliente...");
                        Console.WriteLine("Qual a categoria do cliente:\n" +
                            "1. Para Confeiteiro\n" +
                            "2. Para Encanador\n");
                        string categoria = Console.ReadLine();
                        switch (categoria)
                        {
                            case "1":
                                categoria = "confeiteiro";
                                Confeiteiro confeiteiro = new Confeiteiro();
                                Console.WriteLine("Qual o CPF do novo cliente? ");
                                confeiteiro.cpf = Convert.ToInt32(Console.ReadLine());
                                if (RegistradorController.VerificarExistenciaCPF(categoria, confeiteiro)) 
                                {
                                    Console.WriteLine("Cliente já registrado nessa categoria");
                                    break;
                                }
                                Console.WriteLine("Digite o nome do cliente: ");
                                confeiteiro.nome = Console.ReadLine();
                                Console.WriteLine("Digite a idade do cliente: ");
                                confeiteiro.idade = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Digite o whatsapp do cliente: ");
                                confeiteiro.whatsapp = Console.ReadLine();
                                Console.WriteLine("Digite o telefone do cliente: ");
                                confeiteiro.telefone = Console.ReadLine();
                                Console.WriteLine("Digite o email do cliente: ");
                                confeiteiro.email = Console.ReadLine();
                                Console.WriteLine("Caso o vendedor faça entregas digite 1: ");
                                string entrega = Console.ReadLine();
                                bool fazEntrega = entrega == "1" ? true : false;
                                confeiteiro.entrega = fazEntrega;
                                Console.WriteLine("Qual produto o cliente vende?\n" +
                                    "1. Para Bolo");
                                string produto = Console.ReadLine();
                                switch (produto)
                                {
                                    case "1":
                                        Bolo bolo = new Bolo();
                                        Console.WriteLine("Qual o preço do bolo");
                                        bolo.preco = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Qual o tamanho do bolo");
                                        bolo.tamanho = Console.ReadLine();
                                        Console.WriteLine("Qual o peso do bolo");
                                        bolo.peso = Convert.ToDouble(Console.ReadLine());
                                        confeiteiro.produtos.Add(bolo);
                                        break;
                                }
                                RegistradorController.RegistrarCliente(confeiteiro);
                                break;

                            case "2":
                                categoria = "encanador";
                                Encanador encanador = new Encanador();
                                Console.WriteLine("Qual o CPF do novo cliente? ");
                                encanador.cpf = Convert.ToInt32(Console.ReadLine());
                                if (RegistradorController.VerificarExistenciaCPF(categoria, encanador))
                                {
                                    Console.WriteLine("Cliente já registrado nessa categoria");
                                    break;
                                }
                                Console.WriteLine("Digite o nome do cliente: ");
                                encanador.nome = Console.ReadLine();
                                Console.WriteLine("Digite a idade do cliente: ");
                                encanador.idade = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Digite o whatsapp do cliente: ");
                                encanador.whatsapp = Console.ReadLine();
                                Console.WriteLine("Digite o telefone do cliente: ");
                                encanador.telefone = Console.ReadLine();
                                Console.WriteLine("Digite o email do cliente: ");
                                encanador.email = Console.ReadLine();
                                Console.WriteLine("Digite o tempo de experiência em meses do cliente: ");
                                encanador.experiencia = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Digite o preço de serviço do cliente: ");
                                encanador.precoDeServico = Convert.ToDouble(Console.ReadLine());
                                RegistradorController.RegistrarCliente(encanador);
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Listando todos os clientes...");
                        ListagemControler.ListarTodosClientes();
                        break;

                    case 3:
                        Console.WriteLine("Qual categoria deseja listar:");
                        Console.WriteLine($"1. Para Confeiteiro\n" +
                            $"2. Para Encanador\n");
                        string listarCategoria = Console.ReadLine();
                        switch (listarCategoria)
                        {
                            case "1":
                                ListagemControler.ListarConfeiteiros();
                                break;
                            case "2":
                                ListagemControler.ListarEncanadores();
                                break;
                            default:
                                Console.WriteLine("Comando invalido");
                                break;
                        }
                        break;
                    default:
                        sair = "0";
                        break;                  
                }
                Console.WriteLine("Caso deseja sair digite 1");
                sair = Console.ReadLine();
            } while (sair != "1");
        }

        private static void IniciarCarga()
        {
            RegistradorController.CarregarClientes();
        }
    }
}
