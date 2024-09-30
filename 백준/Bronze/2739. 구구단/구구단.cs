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

        String a = Console.ReadLine();
        int a1 = int.Parse(a);

        for(int i = 1; i<10; i++)
        {
            Console.WriteLine($"{a1} * {i} = {a1*i}");
        }

}
    }
        }