using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dongTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');

            Console.WriteLine(long.Parse(a[0]) + long.Parse(a[1]) + long.Parse(a[2]));

        }
    }
}
