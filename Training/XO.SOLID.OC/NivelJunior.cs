using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.SOLID.OC
{
    public class NivelJunior : NivelSalarial
    {
        public override decimal CalcularSueldo()
        {
            return 2000;
        }
    }
}
