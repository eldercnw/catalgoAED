using Catalogo.models.vendedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.models.prestadorServicos
{
    abstract class Vendedor : Cliente
    {
        public List<Produto> produtos { get; set; }
        public bool entrega { get; set; }
    }
}
