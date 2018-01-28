using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XO.SOLID.OC.Niveles;

namespace XO.SOLID.OC
{
    public class ManagerTrabajador
    {
        public static decimal CalcularSueldo(string nivel, bool hablaIngles)
        {
            var salario = 0;

            if (nivel.Equals("Junior"))
            {
                salario = 2500;
            }
            else if (nivel.Equals("SemiSenior"))
            {
                salario = 3500;
            }
            else if (nivel.Equals("Senior"))
            {
                salario = 5000;
            }
            else
            {
                throw new Exception("No se reconoce el nivel");
            }

            if (hablaIngles)
            {
                salario += 1000;
            }

            return salario;
        }

        public static decimal CalcularSueldo(NivelSalarial nivel)
        {
            return nivel.CalcularSueldo();
        }
    }
}
