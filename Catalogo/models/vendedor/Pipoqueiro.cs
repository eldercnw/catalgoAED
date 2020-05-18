using Catalogo.models.prestadorServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.models.vendedor
{
    class Pipoqueiro : Vendedor
    {
        public static List<Pipoqueiro> listaPipoqueiros = new List<Pipoqueiro>();

        public override string ToString()
        {
            return $"Categoria: Pipoqueiro \nNome: {this.nome}\n CPF: {this.cpf}\n\n";
        }
    }
}
