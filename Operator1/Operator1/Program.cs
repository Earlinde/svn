using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 9;
            //a ^= (b ^= (a ^= b));
            //0,2
            //a ^= b;
            //b ^= a;
            //a ^= b;
            //9,2
            Console.WriteLine("{0},{1}",a.ToString(),b.ToString());

            int i = 0;
            int j = (i++) + (i++);
            //2,1
            Console.WriteLine("{0},{1}", i.ToString(), j.ToString());

            Console.ReadKey();
        }
    }
}
