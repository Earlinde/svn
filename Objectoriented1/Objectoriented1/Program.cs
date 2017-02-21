using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectoriented1
{
    class Program
    {
        static void Main(string[] args)
        {
            contact ct1 = new class1();
            contact ct2 = new class2();
            class2 sp = new class2();

            sp.prinf();
            ct1.prinf();
            ct2.prinf();

            Console.ReadKey();
        }

        abstract public class contact
        {
            public virtual void prinf()
            {
                Console.WriteLine("这是虚方法");
            }

        }

        public class class1 : contact
        {
            public override void prinf()
            {
                Console.WriteLine("这是个重写的新方法");
            }
        }

        public class class2 : contact
        {
            public new void prinf()
            {
                Console.WriteLine("这是另一个新的方法");
            }
        }
    }
}
