using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.models.prestadorServicos
{
    class Encanador : PrestadorDeServicos
    {

        public static List<Encanador> listaEncanador = new List<Encanador>();

        public override string ToString()
        {
            return $"Categoria: {Cliente.GetTipo(this)}\nNome: {this.nome}\nCPF: {this.cpf}\n\n";
        }

    }
}
