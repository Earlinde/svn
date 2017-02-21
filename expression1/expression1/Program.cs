using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace expression1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello             World!         .";//试试看消除空格
            string pattern = "\\s+";
            string replace = " ";
            Regex reg1 = new Regex(pattern);
            string result = reg1.Replace(input,replace);
            Console.WriteLine("初始字符串：{0}",input);
            Console.WriteLine("修改后字符串：{0}",result);

            string line = "addr = 1234 ; name = zhang ; phone = 6789;";//这里替换字符串
            Regex reg2 = new Regex("name = (.+);");
            string result2 = reg2.Replace(line,"name = wang;");
            Console.WriteLine("修改后字符串：{0}", result2);//这里的确是更改了，但是phone被删掉了



            Console.ReadKey();
        }


    }
}
