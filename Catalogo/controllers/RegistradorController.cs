using Catalogo.models;
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
        public static void CarregarClientes()
        {
            List<string> clientes = new List<string> {
                "vendedor.confeiteiro",
                "prestadordeservicos.encanador",
            };

            foreach (var cliente in clientes)
            {
                string tipo = "";
                string subTipo = "";
                if (cliente.Contains("vendedor"))
                {
                    subTipo = "vendedor";
                    tipo = cliente.Remove(0, 9).ToLower();
                }
                if (cliente.Contains("prestadordeservicos"))
                {
                    subTipo = "prestadordeservicos";
                    tipo = cliente.Remove(0, 20).ToLower();
                }


                String path = $"..\\..\\arquivos\\{subTipo}\\{tipo}.txt";
                string[] lines = System.IO.File.ReadAllLines($@"{path}");
                if (lines.Length > 0)
                {
                    foreach (string line in lines)
                    {
                        JsonTextReader jsonreader = new JsonTextReader(new StringReader(line));
                        switch (tipo)
                        {
                            case "confeiteiro":
                                Confeiteiro confeiteiro = new Confeiteiro();
                                JsonSerializer jsonConfeiteiro = new JsonSerializer();
                                confeiteiro = jsonConfeiteiro.Deserialize<Confeiteiro>(jsonreader);
                                Confeiteiro.listaConfeiteiros.Add(confeiteiro);
                                break;

                            case "encanador":
                                Encanador encanador = new Encanador();
                                JsonSerializer jsonEncanador = new JsonSerializer();
                                encanador = jsonEncanador.Deserialize<Encanador>(jsonreader);
                                Encanador.listaEncanadores.Add(encanador);
                                break;
                        }
                    }
                }
           
            }

        }

       
        public static void RegistrarCliente(Cliente cliente)
        {
            string tipo = "";
            string subTipo = "";
            if (cliente.GetType().ToString().ToLower().Contains("vendedor"))
            {
                subTipo = "vendedor";
                tipo = cliente.GetType().ToString().Remove(0, 25).ToLower();
            }
            if (cliente.GetType().ToString().ToLower().Contains("prestadorservico"))
            {
                subTipo = "prestadordeservicos";
                tipo = cliente.GetType().ToString().Remove(0, 34).ToLower();
            }


            bool existInList = false;
            switch (tipo)
            {
                case "confeiteiro":
                    existInList = Confeiteiro.listaConfeiteiros.Exists(c => c.cpf == cliente.cpf);
                    break;
            }

            try
            {
                if (!existInList && !(cliente.cpf == ""))
                {
                    
                    String path = $"..\\..\\arquivos\\{subTipo}\\{tipo}.txt";
                    string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(cliente);
                    List<String> linhas = new List<string>();
                    linhas.Add(jsonString);
                    System.IO.File.AppendAllLines($@"{path}", linhas);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro ao adicionar novo cliente!!!");
            }

        }
    }
}
