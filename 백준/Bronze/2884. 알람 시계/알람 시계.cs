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
            string[] a = Console.ReadLine().Split();
            int h = int.Parse(a[0]); 
            int m = int.Parse(a[1]);

            if (m < 45)
            {
                m += 15;
                h = h > 0 ? h - 1 : 23;
            }
            else
                m -= 45;

            Console.WriteLine($"{h} {m}");

        }
    }
}
