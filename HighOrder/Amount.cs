using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighOrder
{
    class Amount
    {
        public decimal Value { get; }
        public Currency Currency { get; }

        public Amount(decimal value, Currency currency)
        {
            this.Value = value;
            this.Currency = currency ?? throw new ArgumentNullException(nameof(currency));
        }

        public Amount Scale(decimal scale)
        {
            return new Amount(this.Value * scale, this.Currency);
        }

        public Amount Add(decimal val)
        {
            return new Amount(this.Value + val, this.Currency);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
