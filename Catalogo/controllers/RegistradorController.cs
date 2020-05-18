﻿using Catalogo.models;
using Catalogo.models.prestadorServicos;
using Catalogo.models.vendedor;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.controllers
{
    class RegistradorController
    {
        private static List<string> _clientes = new List<string> {
                "vendedor.confeiteiro",
                "prestadordeservicos.encanador",
                "vendedor.pipoqueiro",
                "prestadordeservicos.eletricista",
            };

        public static List<string> getClientes()
        {
            return _clientes;
        }
        public static void CarregarClientes()
        {
            List<string> clientes = getClientes();
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
                                if (!Confeiteiro.listaConfeiteiros.Exists(c => c.cpf == confeiteiro.cpf)) 
                                {
                                    Confeiteiro.listaConfeiteiros.Add(confeiteiro);
                                    ++Cliente.quantidadeCliente;
                                }
                                break;

                            case "encanador":
                                Encanador encanador = new Encanador();
                                JsonSerializer jsonEncanador = new JsonSerializer();
                                encanador = jsonEncanador.Deserialize<Encanador>(jsonreader);
                                if (!Encanador.listaEncanador.Exists(c => c.cpf == encanador.cpf))
                                {
                                    Encanador.listaEncanador.Add(encanador);
                                    ++Cliente.quantidadeCliente;
                                }
                                break;
                            case "pipoqueiro":
                                Pipoqueiro pipoqueiro = new Pipoqueiro();
                                JsonSerializer jsonPipoqueiro = new JsonSerializer();
                                pipoqueiro = jsonPipoqueiro.Deserialize<Pipoqueiro>(jsonreader);
                                if (!Pipoqueiro.listaPipoqueiro.Exists(c => c.cpf == pipoqueiro.cpf))
                                {
                                    Pipoqueiro.listaPipoqueiro.Add(pipoqueiro);
                                    ++Cliente.quantidadeCliente;
                                }
                                break;
                            case "eletricista":
                                Eletricista eletricista = new Eletricista();
                                JsonSerializer jsonEletricista = new JsonSerializer();
                                eletricista = jsonEletricista.Deserialize<Eletricista>(jsonreader);
                                if (!Eletricista.listaEletricista.Exists(c => c.cpf == eletricista.cpf))
                                {
                                    Eletricista.listaEletricista.Add(eletricista);
                                    ++Cliente.quantidadeCliente;
                                }
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


            try
            {
                if (!VerificarExistenciaCPF(tipo, cliente) && !(cliente.cpf == 0))
                {                  
                    String path = $"..\\..\\arquivos\\{subTipo}\\{tipo}.txt";
                    string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(cliente);
                    List<String> linhas = new List<string>();
                    linhas.Add(jsonString);
                    System.IO.File.AppendAllLines($@"{path}", linhas);
                    RegistradorController.CarregarClientes();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro ao adicionar novo cliente!!!");
            }

        }

        public static bool VerificarExistenciaCPF(string tipo, Cliente cliente)
        {
            bool existInList = false;
            switch (tipo)
            {
                case "confeiteiro":
                    existInList = Confeiteiro.listaConfeiteiros.Exists(c => c.cpf == cliente.cpf);
                    break;
                case "encanador":
                    existInList = Encanador.listaEncanador.Exists(c => c.cpf == cliente.cpf);
                    break;
                case "pipoqueiro":
                    existInList = Pipoqueiro.listaPipoqueiro.Exists(c => c.cpf == cliente.cpf);
                    break;
                case "eletricista":
                    existInList = Eletricista.listaEletricista.Exists(c => c.cpf == cliente.cpf);
                    break;
            }
            return existInList;
        }


    }
}
