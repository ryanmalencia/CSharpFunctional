using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighOrder
{
    class Currency
    {
        public string Symbol { get; }

        public Currency(string symbol)
        {
            this.Symbol = !string.IsNullOrWhiteSpace(symbol)
                ? symbol
                : throw new ArgumentException();
        }
    }
}
