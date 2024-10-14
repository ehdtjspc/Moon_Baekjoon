using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;



namespace CODE
{
    internal class Program{
    static void Main(string[] args){

  

    while(true)
    {
        string a = Console.ReadLine();
        if(a==null) {break;}
        var aa = a.Split();
        int a1 = int.Parse(aa[0]);
        int a2 = int.Parse(aa[1]);
        Console.WriteLine(a1+a2);
    }
    
   }  
    
  }
 }