using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XO.SOLID.DI.Log;
using XO.SOLID.LSP;

namespace XO.UnitTests
{
    [TestFixture]
    public class SolidTests
    {
        [Test]
        public void LiskokSubstitutionTest()
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

        [Test]
        public void DependencyInjectionTest()
        {
            var manager = new XO.SOLID.DI.Manager();

            manager.Run(new FileLog());
        }
    }
}
