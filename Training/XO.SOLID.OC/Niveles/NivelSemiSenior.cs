using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.SOLID.OC.Niveles
{
    public class NivelSemiSenior : NivelSalarial
    {
        public override decimal CalcularSueldo()
        {
            return base.CalcularSueldo() + 3500;
        }
    }
}
