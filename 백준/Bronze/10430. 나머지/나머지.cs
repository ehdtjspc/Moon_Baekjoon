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
            string[] aa = Console.ReadLine().Split(' ');
            int a = int.Parse(aa[0]);
            int b = int.Parse(aa[1]);
            int c = int.Parse(aa[2]);

            Console.WriteLine("{0}", (a + b) % c);
            Console.WriteLine("{0}", ((a % c) + (b % c)) % c);
            Console.WriteLine("{0}", (a * b) % c);
            Console.WriteLine("{0}", ((a % c) * (b % c)) % c);

        }
    }
}