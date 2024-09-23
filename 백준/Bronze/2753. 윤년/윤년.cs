using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE
{
    internal class Program{
    static void Main(string[] args){

        string a = Console.ReadLine();
        int a1 = int.Parse(a);
        if(a1 % 4 ==0 && a1 % 100 !=0){
            Console.WriteLine("1");
        }
        else if(a1 % 400 ==0){
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
            
}
    }
        }