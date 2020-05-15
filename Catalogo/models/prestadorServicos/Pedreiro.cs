using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Pedreiro
{
    public string nome { get; set; }
    public int idade { get; set; }
    public string experiencia { get; set; } 
    public float valorCobrado { get; set; }
    public string descricaoServico { get; set; }

public Pedreiro(string nome, int idade, string experiencia, float valorCobrado, string descricaoServico){
  this.nome = nome;
  this.idade = idade;
  this.experiencia = experiencia;
  this.valorCobrado = valorCobrado;
  this.descricaoServico = descricaoServico;
}

}
