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

        
        int a = int.Parse(Console.ReadLine());
       
        for(int i =1; i<=a; i++)
        {
            for(int j=1; j<=a; j++)
            {
                if(j<=a-i)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
          }
            Console.WriteLine();  
         }
      }

    }
 }