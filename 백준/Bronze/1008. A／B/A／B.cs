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
            string[] a = Console.ReadLine().Split( );    //문자열 두개를 받아 Split를 통해 두개로 나눔

            Console.WriteLine(double.Parse(a[0]) / double.Parse(a[1]));

        }
    }
}
