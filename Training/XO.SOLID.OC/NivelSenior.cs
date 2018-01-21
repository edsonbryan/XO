using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.SOLID.OC
{
    public class NivelSenior : NivelSalarial
    {
        public override decimal CalcularSueldo()
        {
            return 3000;
        }
    }
}
