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
            string a1 = Console.ReadLine();
            string a2 = Console.ReadLine();

            int aa1 = int.Parse(a1);
            int aa2 = int.Parse(a2);

            int aa = aa2 % 10;
            int a = aa1 * aa;
            aa2 /= 10;

            int bb = aa2 % 10;
            int b = aa1 * bb;
            aa2 /= 10;

            int cc = aa2 % 10;
            int c = aa1 * cc;

            int d = a + (b * 10) + (c * 100);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

        }
    }
}
