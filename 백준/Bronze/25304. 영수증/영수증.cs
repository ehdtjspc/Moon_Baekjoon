using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CODE
{
    internal class Program{
    static void Main(string[] args){

        
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int sum = 0;
       
        for(int i = 0; i<b; i++)
        {
              string[] a1 = Console.ReadLine().Split(" ");
              int c = int.Parse(a1[0]);
              int d = int.Parse(a1[1]);

              sum += c*d;
        }
        if(sum==a){
        Console.WriteLine("Yes");
        }
        else{
            Console.WriteLine("No");
        }

}
    }
        }