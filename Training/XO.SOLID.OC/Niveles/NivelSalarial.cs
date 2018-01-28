using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.SOLID.OC.Niveles
{
    public abstract class NivelSalarial
    {
        public virtual bool SabeIngles { get; set; }

        public virtual decimal CalcularSueldo()
        {
            return SabeIngles ? 1000 : 0;
        }
    }
}
