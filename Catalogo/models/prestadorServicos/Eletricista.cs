using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.models.prestadorServicos
{
    class Eletricista : PrestadorDeServicos
    {

        public static List<Eletricista> listaEletricista = new List<Eletricista>();

        public override string ToString()
        {
            return $"Categoria: {Cliente.GetTipo(this)}\nNome: {this.nome}\nCPF: {this.cpf}\n\n";
        }

    }
}
