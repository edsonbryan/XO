using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.SOLID.LSP
{
    public abstract class Customer
    {
        public int CustomerType { get; set; }

        public virtual decimal GetDiscount(decimal totalSales)
        {
            return totalSales;
        }

        public abstract void Add();
    }
}
