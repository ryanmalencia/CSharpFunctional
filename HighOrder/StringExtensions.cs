using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighOrder
{
    static class StringExtensions
    {
        public static void WriteLine(this string str)
        {
            Console.WriteLine(str);
        }

        public static void WriteLine(this IEnumerable<string> strEnum)
        {
            foreach(var s in strEnum)
            {
                Console.Write(s);
            }
        }

        public static IEnumerable<string> Join(this IEnumerable<string> strEnum, string str)
        {
            List<string> returnList = new List<string>();
            foreach(var s in strEnum)
            {
                returnList.Add(s + str);
            }
            return returnList;
        }
    }
}
