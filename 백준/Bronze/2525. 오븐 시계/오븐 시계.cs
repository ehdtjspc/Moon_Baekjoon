using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CODE
{
    internal class Program{
    static void Main(string[] args){

        string[] a = Console.ReadLine().Split(" ");
        int h = int.Parse(a[0]);
        int m = int.Parse(a[1]);
        string a1 = Console.ReadLine();
        int f = int.Parse(a1);

        int sum = m+f;
        while(sum>59)
        {
            h= h<23 ? h +1 : 0;
            sum = sum-60;
        }
        Console.WriteLine($"{h} {sum}");
  
}
    }
        }