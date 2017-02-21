using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Anominous1
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("传统代码：");
            FindListDelegate();
            Console.WriteLine("\n");
            Console.WriteLine("匿名函数：");
            FindListAnominous();
            Console.WriteLine("\n");
            Console.WriteLine("lambda表达式：");
            FindListLambda();
            
            //这里开始是对lambda表达式中Func<T>的练习
            ParameterExpression a = Expression.Parameter(typeof(int), "i");
            ParameterExpression b = Expression.Parameter(typeof(int), "j");
            BinaryExpression be0 = Expression.Multiply(a, b);
            ParameterExpression c = Expression.Parameter(typeof(int), "w");
            ParameterExpression d = Expression.Parameter(typeof(int), "x");
            BinaryExpression be1 = Expression.Multiply(c,d);
            BinaryExpression su = Expression.Add(be0,be1);
            //上面在把四个字母连接起来
            Expression<Func<int, int, int, int, int>> lambda_test = Expression.Lambda<Func<int, int, int, int, int>>(su, a, b, c, d);
            //Expression:表达式树
            Console.WriteLine(lambda_test + ".");
            Func<int,int,int,int,int> f = lambda_test.Compile();//这里是生成代码，可以理解为这里声明了函数,匿名的
            Console.WriteLine(f(1,1,1,1) + ".");//调用函数

            Console.ReadKey();
        }
        /// <summary>
        /// 一般的/传统的调用
        /// </summary>
        static void FindListDelegate()
        {
            List<string> list = new List<string>();
            list.AddRange(new string[] { "ASP.NET课程", "J2EE课程", "PHP课程", "DATESTRUCT课程" });
            Predicate<string> findpredicate = new Predicate<string>(IsBookCategory);
            List<string> bookCategory = list.FindAll(findpredicate);
            foreach (string str in bookCategory)
            {
                Console.Write("{0}\n",str);
            }
        }
        static bool IsBookCategory(string str)
        {
            return str.EndsWith("课程") ? true : false;
        }
        /// <summary>
        /// 匿名方法
        /// </summary>
        static void FindListAnominous()
        {
            List<string> list = new List<string>();
            list.AddRange(new string[] { "ASP.NET课程", "J2EE课程", "PHP课程", "DATESTRUCT课程" });
            List<string> bookCategory = list.FindAll(delegate (string str)//这里开始的匿名方法
            {                                                             //
                return str.EndsWith("课程") ? true : false;               //
            });                                                           //
            foreach (string str in bookCategory)
            {
                Console.Write("{0}\n", str);
            }
        }
        /// <summary>
        /// lambda表达式
        /// </summary>
        static void FindListLambda()
        {
            List<string> list = new List<string>();
            list.AddRange(new string[] { "ASP.NET课程", "J2EE课程", "PHP课程", "DATESTRUCT课程" });
            List<string> bookCategory = list.FindAll((string str) => str.EndsWith("课程"));//这里是lambda语句
            foreach (string str in bookCategory)                                           
            {                                                                              
                Console.Write("{0}\n", str);
            }
        }

        //这一段时用来测试svn的不要在意
    }
}
