using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net1
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeNamespace mynamespace = new CodeNamespace("myapplication");

            Console.Out.WriteLine("\n--------- 以下是C#代码 ------------");
            CodeDomProvider csp = CodeDomProvider.CreateProvider("C#");
            csp.GenerateCodeFromNamespace(mynamespace,Console.Out,new CodeGeneratorOptions { BracingStyle = "C" });

            Console.Out.WriteLine("\n\n------ - 以下是VB.NET代码---------- -");
            CodeDomProvider vbp = CodeDomProvider.CreateProvider("VB");
            vbp.GenerateCodeFromNamespace(mynamespace,Console.Out,new CodeGeneratorOptions());

            Console.ReadKey();

            DateTime dt = new DateTime();
            var intArray = new int[] {
                1,2,3,4
            };
            Array.Sort(intArray, (a, b) =>
            {
                return a>=b?1:0;
            });

            
            
            
        }
    }
}
