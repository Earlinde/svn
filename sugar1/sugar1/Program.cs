using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sugar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program su = new Program();
            su.HowDo(new DoSome(su.DoIt),100);
            int x = 10;
            //这里使用匿名委托
            su.HowDo(delegate (int a)
            {
                Console.WriteLine(a + x);
            },10);
            //这里使用lambda表达式
            su.HowDo(a => Console.WriteLine(a + x),10);
            //效果是一样的
            Console.ReadKey();
        }
             
        public delegate void DoSome(int a);
          
        private void DoIt(int a )
        {
            Console.WriteLine(a);
        }

        private void HowDo(DoSome method,int a)
        {
            method(a);
        }
    }
}
