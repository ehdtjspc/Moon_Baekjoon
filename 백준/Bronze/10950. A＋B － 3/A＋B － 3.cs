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

        
        int b = int.Parse(Console.ReadLine());
       
        for(int i = 0; i<b; i++)
        {
             String[] a = Console.ReadLine().Split(" ");
             int a1 = int.Parse(a[0]);
             int a2 = int.Parse(a[1]);

             Console.WriteLine(a1+a2);
        }

}
    }
        }