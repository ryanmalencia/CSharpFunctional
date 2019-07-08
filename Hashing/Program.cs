using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class Element<T>
    {
        public T Content { get; set; }
        public Element<T> Next { get; set; }
    }

    static class Hashing
    {
        public static int GetHashEntry<T>(this Element<T>[] set, T value)
        {
            if (ReferenceEquals(value, null))
                return 0;

            int code = value.GetHashCode();
            int entry = code % set.Length;
            if (entry < 0) entry += set.Length;
            return entry;
        }

        public static void Add<T>(this Element<T>[] set, T value)
        {
            var entry = set.GetHashEntry(value);
            Element<T> element = new Element<T>()
            {
                Content = value,
                Next = set[entry]
            };
            Console.WriteLine($"Adding {value} to set[{entry}]");

            set[entry] = element;
        }

        public static bool Contains<T>(this Element<T>[] set, T value)
        {
            int entry = set.GetHashEntry(value);
            if (entry < 0) entry += set.Length;
            Console.WriteLine($"Searching for {value} in set[{entry}]");

            for(Element<T> cur = set[entry]; cur != null; cur = cur.Next)
            {
                if (cur.Content.Equals(value))
                {
                    return true;
                }
            }

            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Element<int>[] set = new Element<int>[7];

            set.Add(22);
            set.Add(33);
            set.Add(54);

            if(set.Contains(54))
            {
                Console.WriteLine("Value found");
            }

            Console.ReadLine();
        }
    }
}
