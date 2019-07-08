using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighOrder
{
    static class Tax
    {
        public static Amount DefaultTax(this Amount basePrice) =>
            basePrice.Scale(.20M);

        public static Amount RelativeTax(this Amount basePrice, decimal factor) =>
            basePrice.Scale(factor);

        public static Amount CalculateTax(this Product product, Amount basePrice) =>
            basePrice.DefaultTax();
    }
}
