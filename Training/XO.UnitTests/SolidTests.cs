using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XO.SOLID.DI.Log;
using XO.SOLID.LSP;
using XO.SOLID.LSP.Sample01;
using XO.SOLID.OC;
using XO.SOLID.OC.Niveles;

namespace XO.UnitTests
{
    [TestFixture]
    public class SolidTests
    {
        #region Open Close

        [Test]
        public void OpenCloseTest()
        {
            var salario = ManagerTrabajador.CalcularSueldo("Junior", false);

            Assert.AreEqual(2500, salario);

            var nivelJunior = new NivelJunior { SabeIngles = false };

            salario = ManagerTrabajador.CalcularSueldo(nivelJunior);

            Assert.AreEqual(2500, salario);

            nivelJunior.SabeIngles = true;

            salario = ManagerTrabajador.CalcularSueldo(nivelJunior);

            Assert.AreEqual(3500, salario);

            var nivelSenior = new NivelSenior { SabeIngles = true };

            salario = ManagerTrabajador.CalcularSueldo(nivelSenior);

            Assert.AreEqual(6000, salario);

            var nivelLead = new NivelLead { SabeIngles = false };

            salario = ManagerTrabajador.CalcularSueldo(nivelLead);

            Assert.AreEqual(7000, salario);
        }

        #endregion

        #region Liskov Substitution

        [Test]
        public void LiskovSubstitutionTest()
        {
            var golden = new Golden();
            var silver = new Silver();
            var enquiry = new Enquiry();

            var list = new List<Customer> { golden, silver, enquiry };

            foreach (var customer in list)
            {
                customer.Add();
            }
        }

        #endregion

        #region Dependency Injection

        [Test]
        public void DependencyInjectionTest()
        {
            var manager = new XO.SOLID.DI.Manager();

            manager.Run(new FileLog());
        }

        #endregion

    }

    public class NivelLead : NivelSalarial
    {
        public override decimal CalcularSueldo()
        {
            return base.CalcularSueldo() + 7000;
        }
    }
}
