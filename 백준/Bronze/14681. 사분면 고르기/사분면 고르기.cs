using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE
{
    internal class Program{
    static void Main(string[] args){

        string a = Console.ReadLine();
        int x = int.Parse(a);
        string b = Console.ReadLine();
        int y = int.Parse(b);

        if(x>0 && y>0)
        {
            Console.WriteLine("1");
        }
        else if(x<0 && y>0)
        {
            Console.WriteLine("2");
        }
        else if(x<0 && y<0)
        {
            Console.WriteLine("3");
        }
        else if(x>0 && y<0)
        {
            Console.WriteLine("4");
        }
        
            
}
    }
        }