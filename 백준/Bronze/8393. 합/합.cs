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

        
        int b = int.Parse(Console.ReadLine());
        int sum = 0;
       
        for(int i = 1; i<=b; i++)
        {
              sum +=i;
        }

        Console.WriteLine(sum);


}
    }
        }