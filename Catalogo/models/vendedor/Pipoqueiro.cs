using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Pipoqueiro
{
    public string nome { get; set; }
    public string tiposDePipoca { get; set;}
    public float valorPipoca { get; set; }
    public string complementos { get; set; }



public Pipoqueiro(string nome, string tiposDePipoca, float valorPipoca, string complementos){
  this.nome = nome;
  this.tiposDePipoca = tiposDePipoca;
  this.valorPipoca = valorPipoca;
  this.complementos = complementos;
}

}
