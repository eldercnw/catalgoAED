using Catalogo.controllers;
using Catalogo.models;
using Catalogo.models.prestadorServicos;
using Catalogo.models.vendedor;
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
        static List<dynamic> listaClientes = new List<dynamic>();
        static void Main(string[] args)
        {
            IniciarCarga();
            bool sair = false;
            do {
                int opcao = 0;
                Console.WriteLine("Bem vindo ao sistema de catálogo de vendedores e prestadores de serviços: ");
                Console.WriteLine($"Que operação deseja executar?\n" +
                    $"1. Para inserir novo cliente\n" +
                    $"2. Para listar todos os clientes\n");

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Inserir novo cliente...");

                        break;
                    default:
                        sair = true;
                        break;                  
                }

            } while (sair == true);
            Console.ReadLine();
        }

        private static void IniciarCarga()
        {
            RegistradorController.CarregarClientes();


            Encanador conf1 = new Encanador();
            conf1.cpf = "152";
            RegistradorController.RegistrarCliente(conf1);

            Console.WriteLine(listaClientes.ToString());
            Console.ReadLine();
        }
    }
}
