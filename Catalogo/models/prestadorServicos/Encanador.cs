using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.models.prestadorServicos
{
    class Encanador : PrestadorDeServicos
    {
<<<<<<< HEAD
        public static List<Encanador> listaEncanadores = new List<Encanador>();

        public override string ToString()
        {
            return $"Categoria: {Cliente.GetTipo(this)}\nNome: {this.nome}\n CPF: {this.cpf}\n\n";
        }
=======
        public static List<Encanador> listaEncadores = new List<Encanador>();
>>>>>>> 7ee8ec4d064210f94df7f4f5c9a0b2f6501b803d
    }
}
