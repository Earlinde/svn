using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            bc.sayHello();

            DriverdClass dc = new DriverdClass();
            dc.sayHello();

            BaseClass bc2 = new DriverdClass();//基类可以new一个DriverdClass，但是被覆盖的方法使用自己本身的
            bc2.sayHello();//这里的输出是BaseClass

            Test test = new Test();
            test.sayHello();

            BaseClass bc3 = new DriverdClass2();//基类可以new一个DriverdClass，但是被覆盖的方法使用自己本身的
            bc3.sayHello();//这里的输出是BaseClass

            //索引器
            IndexDemo id = new IndexDemo();
            id[0] = "chen";
            id[1] = "ke";
            id[2] = "jin";
            Console.WriteLine("{0}{1}{2}", id[0], id[1], id[2]);

            Test t = new Test();
            t.sayHello();
            t.X = 100;
            Console.WriteLine(t.X);
            //Test2 t2 = new Test2();//会报错，实例化抽象类。
            //t2.sayHello();
            //Console.WriteLine(t2.add());
            //Console.WriteLine(t2.add2());
            //t2.x = 10;
            //Console.WriteLine(t2.x);

            contact ct1 = new class1();
            contact ct2 = new class2();
            class2 sp = new class2();

            sp.prinf();
            ct1.prinf();
            ct2.prinf();

            Console.ReadKey();

            Console.ReadKey();
        }
        /// <summary>
        /// 接口
        /// </summary>
        public interface Mytest//接口里会给出方法这些，在被实现的Test里扩展开来
        {
            void sayHello();
            int X { get; set; }
        }

        public class Test : Mytest
        {
            private int _x;
            public int X
            {
                get
                {
                    return _x;
                    //throw new NotImplementedException();
                }
                set
                {
                    _x = value;
                    //throw new NotImplementedException();
                }
            }

            public void sayHello()
            {
                Console.WriteLine("say hello in Test!");
                //throw new NotImplementedException();//这里也会报错:未实现方法
            }
        }

        abstract class ATest
        {
            public int x;
            public abstract void sayHello();
            public int add() { return 1 + 2; }
            public virtual int add2() { return 2 + 3; }
        }

        abstract class Test2:ATest
        {
            public override void sayHello()//重写函数  重写virtual、abstract必须通过override
            {
                Console.WriteLine("say hello in test2");
                throw new NotImplementedException();
            }

            public override int add2()
            {
                return 3 + 4;
            }
        }

        public class BaseClass
        {
            public BaseClass()//构造器一：无参数的时候调用
            {
                Console.WriteLine("BaseClass!");
            }
            public BaseClass(string str)//构造器二：传入一个string参数的时候调用
            {
                Console.WriteLine("BaseClass!" + str);
            }
            public virtual void sayHello()//抽象类
            {
                Console.WriteLine("say hello in BaseClass!");
            }
        }

        class DriverdClass:BaseClass
        {
            //它是基于BaseClass的，所以构造器也继承了，所以在输出DriverdClass之前会有一个BaseClass输出
            public DriverdClass()
            {
                Console.WriteLine("DriverdClass!");
            }
            public new void sayHello()//有意掩藏基类的方法 new
            {
                Console.WriteLine("say hello in DriverdClass!");
            }
            public void drawLine()
            {

            }
        }

        class point
        {
            private int _x;
            public int X { get { return _x; } set { _x = value; } }
            private int _y;
            public int Y { get { return _y; } set { _y = value; } }
        }

        class DriverdClass2 : BaseClass
        {
            //这里没有自己的构造器
            public new void sayHello()//有意掩藏基类的方法 new
            {
                Console.WriteLine("say hello in DriverdClass2!");
            }
        }

        class IndexDemo//这是个索引器
        {
            protected ArrayList array = new ArrayList();
            public object this [int index]
            {
                get
                {
                    if (index > -1 && index < array.Count)
                    {
                        return array[index];
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    if (index > -1 && index < array.Count)
                    {
                        array[index] = value;
                    }
                    else if (index == array.Count)
                    {
                        array.Add(value);
                    }
                    else
                    {

                    }
                }
            }
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
