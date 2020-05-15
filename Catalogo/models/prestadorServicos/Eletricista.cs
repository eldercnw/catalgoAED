using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Eletricista
{
    public string nome { get; set; }
    public int idade { get; set; }
    public int crea { get; set; }
    public string experiencia { get; set; }
    public float valorCobrado { get; set; }
    public string descricaoServiço {get; set; }



public Eletricista(string nome, int idade, int crea, string experiencia, float valorCobrado, string descricaoServiço){
  this.nome = nome;
  this.idade = idade;
  this.crea = crea;
  this.experiencia = experiencia;
  this.valorCobrado = valorCobrado;
}

}
