using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XO.SOLID.OC.Niveles;

namespace XO.SOLID.OC
{
    public class Manager
    {
        public decimal CalcularSueldo(string nivel)
        {
            if (nivel.Equals("Junior"))
            {
                return 2500;
            }
            else if (nivel.Equals("Senior"))
            {
                return 4000;
            }
            else
            {
                return 6000;
            }
        }

        public decimal CalcularSueldo2(NivelSalarial nivel)
        {
            return nivel.CalcularSueldo();
        }
    }
}
