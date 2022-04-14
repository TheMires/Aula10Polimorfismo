using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10V.src
{
    public class Sapo : Animais
    {
        public Sapo() { }

        public Sapo(string nome, string cor, string classificacao) : base(nome, cor, classificacao) { }

        public override void Comer(string comida) 
        { 
            Console.WriteLine($"{Nome} está comendo: {comida}"); 
        }
    }
}

                    new Animacao("Piratas do Caribe","130 min","14+","Inglês"),
                    new Animacao("Homem de ferro","124 min","12+","Inglês"),
                    new Animacao("Logan","125 min","14+","Inglês"),
                    new Acao("Homem-Aranha","130 min","12+","Inglês"),
                    new Acao("Guera mundial","110 min","14+","Ingles"),

