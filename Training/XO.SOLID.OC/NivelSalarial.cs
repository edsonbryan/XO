using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.SOLID.OC
{
    public abstract class NivelSalarial
    {
        public virtual bool SabeIngles { get; set; }

        public abstract decimal CalcularSueldo();
    }
}
