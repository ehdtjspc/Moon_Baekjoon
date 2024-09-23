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
        if(a1 >100 || a1<0){
            return;
        }

        if(89<a1)
        {
            Console.WriteLine("A");
        }
        else if(79<a1)
        {
            Console.WriteLine("B");
        }
        else if(69<a1)
        {
            Console.WriteLine("C");
        }
        else if(59<a1)
        {
            Console.WriteLine("D");
        }
        else if(59 >= a1)
        {
             Console.WriteLine("F");
        }


}
    }
        }