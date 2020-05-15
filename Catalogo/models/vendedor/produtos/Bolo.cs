using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.models.vendedor.produtos
{
    class Bolo : Produto
    {
        public double peso { get; set; }
        public String tamanho { get; set; }
        public List<String> sabores { get; set; }
    }
}
