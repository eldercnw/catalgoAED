using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.models.prestadorServicos
{
    abstract class PrestadorDeServicos : Cliente
    {
        public int experiencia { get; set; }
        public double precoDeServico { get; set; }

    }
}
