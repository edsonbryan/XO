
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.SOLID.LSP.Sample01
{
    public class Enquiry : Customer
    {
        public override decimal GetDiscount(decimal totalSales)
        {
            return base.GetDiscount(totalSales) - 20;
        }

        public override void Add()
        {
            throw new NotImplementedException();
        }
    }
}
