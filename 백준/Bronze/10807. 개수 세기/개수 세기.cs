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

    string[] num = Console.ReadLine().Split();

    string b = Console.ReadLine();

    int result = Array.FindAll(num, x=> x == b).Length;  // => 람다식 x에 num배열이 있어 순차적으로 앞에서부터 돌리는데 거기서 b랑 같은게 몇개 있는지 출력 result에 저장해라

    Console.WriteLine(result);
    
   }  
    
  }
 }