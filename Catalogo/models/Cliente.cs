using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.models
{
    abstract class Cliente
    {
        public String email { get; set; }
        public int idade { get; set; }
        public String senha { get; set; }
        public String nome { get; set; }
        public String cpf { get; set; }
        public String telefone { get; set; }
        public String whatsapp { get; set; }
        public String endereco { get; set; }

    }
}
