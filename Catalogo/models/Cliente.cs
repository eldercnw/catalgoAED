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
        public static int quantidadeCliente = 0;
        public string email { get; set; }
        public int idade { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string whatsapp { get; set; }

       
        public static string GetTipo(Cliente cliente)
        {
            string tipo = cliente.GetType().ToString().ToLower();
            if (tipo.Contains("vendedor"))
            {
                tipo = tipo.Remove(0, 9).ToLower();
            }
            if (tipo.Contains("prestadorservicos"))
            {
                tipo = tipo.Remove(0, 34).ToLower();
            }
            return tipo;
        }
    }
}
