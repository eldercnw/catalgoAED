using Catalogo.models.prestadorServicos;
using Catalogo.models.vendedor;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.controllers
{
    class RegistradorController
    {
        public static void CarregarConfeiteiros()
        {
            String path = "..\\..\\arquivos\\Confeiteiros.txt";
            string[] lines = System.IO.File.ReadAllLines($@"{path}");
            foreach(string line in lines)
            {
                JsonTextReader jsonreader = new JsonTextReader(new StringReader(line));
                Confeiteiro confeiteiro = new Confeiteiro();
                JsonSerializer jsonSerializer = new JsonSerializer();             
                confeiteiro = jsonSerializer.Deserialize<Confeiteiro>(jsonreader);             
            }
        }
    }
}
