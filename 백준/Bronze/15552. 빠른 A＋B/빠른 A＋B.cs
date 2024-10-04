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
       
        StringBuilder aa = new StringBuilder();

        
       
        for(int i = 0; i<a; i++)
        {
             string[] b = Console.ReadLine().Split(" ");
             int b1 = int.Parse(b[0]);
             int b2 = int.Parse(b[1]);
             aa.Append(b1+b2 + "\n");     // 문자열 뒤에 덧붙이는 역할임, 새로운 메모리가 할당되는게 아니라 기존메모리에 뒤에 덧붙임 가변의 공간이
             
        }
        Console.WriteLine(aa.ToString());
       

}
    }
        }