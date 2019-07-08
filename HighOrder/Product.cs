using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighOrder
{
    class Product
    {
        public string Name { get; }
        public Amount UnitPrice { get; }

        public Product(string name, Amount unitPrice)
        {
            this.Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentException(nameof(name));
            this.UnitPrice = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice));
        }
    }
}
