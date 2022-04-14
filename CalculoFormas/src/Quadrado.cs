using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoFormas.src
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }
        public override double CalcularArea => this.Lado * this.Lado;
        
    }    
}
    

