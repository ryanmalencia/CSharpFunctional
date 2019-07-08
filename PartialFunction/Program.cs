using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialFunction
{
    class Program
    {
        static void DoSomething(Func<int, int> scale) { }

        static void Main(string[] args)
        {
            int scale(int factor, int x) => factor * x;
            int @double(int x) => scale(2, x);

            DoSomething(@double);
        }
    }
}
