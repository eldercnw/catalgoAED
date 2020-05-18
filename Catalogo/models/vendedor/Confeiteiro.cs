using Catalogo.models.prestadorServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.models.vendedor
{
    class Confeiteiro : Vendedor
    {
        public static List<Confeiteiro> listaConfeiteiros = new List<Confeiteiro>();

        public override string ToString()
        {
            return $"Categoria: Confeiteiro\nNome: {this.nome}\n CPF: {this.cpf}\n\n";
        }
    }
}
