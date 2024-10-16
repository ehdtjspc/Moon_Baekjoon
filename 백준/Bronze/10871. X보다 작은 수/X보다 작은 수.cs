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
using System.Xml;



namespace CODE
{
    internal class Program{
    static void Main(string[] args){

   string[] a = Console.ReadLine().Split();
   string[] b = Console.ReadLine().Split();

   StringBuilder aa = new StringBuilder();

   for(int i = 0; i<int.Parse(a[0]); i++)
   {
    if(int.Parse(a[1])>int.Parse(b[i]))
    {
        aa.Append(b[i]+" ");
    }
   
   }
    Console.WriteLine(aa.ToString());
    
   }  
    
  }
 }
     