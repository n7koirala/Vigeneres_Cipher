using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace Vigeneres
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("\n -------------- Vigeneres Cipher ---------------\n");
VigenereBreaking vb = new VigenereBreaking();
var key = vb.VigenereBreakingM();
Console.WriteLine("Generated key is : '" + key + "'");
Console.ReadKey();
}
}
}
