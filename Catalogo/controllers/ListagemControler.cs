using Catalogo.models.prestadorServicos;
using Catalogo.models.vendedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.controllers
{
    class ListagemControler
    {
        public static void ListarTodosClientes()
        {
            ListagemControler.ListarEncanadores();
            ListagemControler.ListarConfeiteiros();
            ListagemControler.ListarPipoqueiros();
            ListagemControler.ListarEletricistas();

        }

        public static void ListarEncanadores()
        {
            foreach (var item in Encanador.listaEncanador)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void ListarConfeiteiros()
        {
            foreach (var item in Confeiteiro.listaConfeiteiros)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void ListarPipoqueiros()
        {
            foreach (var item in Pipoqueiro.listaPipoqueiro)
            {
                Console.WriteLine(item.ToString());
            }

        }
        public static void ListarEletricistas()
        {
            foreach (var item in Eletricista.listaEletricista)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
