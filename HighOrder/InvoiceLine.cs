using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighOrder
{
    class InvoiceLine
    {
        public string Label { get; }
        public Amount BasePrice { get; }
        public Amount Tax { get; }
        public Amount TotalPrice => this.BasePrice.Add(this.Tax.Value);

        public InvoiceLine(string label, Amount basePrice, Amount tax)
        {
            Label = label;
            BasePrice = BasePrice;
            Tax = tax;
        }
    }
}
