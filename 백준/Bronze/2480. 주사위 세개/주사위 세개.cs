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

        String[] a = Console.ReadLine().Split();
        int a1 = int.Parse(a[0]);
        int a2 = int.Parse(a[1]);
        int a3 = int.Parse(a[2]);
        
        if(a1==a2 && a1==a3){
            int nub1 = 10000+a1*1000;
            Console.WriteLine($"{nub1}");
        }
        else if(a1==a2 || a1==a3){
            int nub2 = 1000+a1*100;
            Console.WriteLine($"{nub2}");

        }
        else if(a2==a3){
            int nub2 = 1000+a2*100;
            Console.WriteLine($"{nub2}");
        }
        else{
            int nub3 =  Math.Max(a1,Math.Max(a2,a3))*100;
            Console.WriteLine($"{nub3}");
        }

        
}
    }
        }