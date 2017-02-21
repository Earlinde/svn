using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_test
{
    class Program
    {
        static void Main(string[] args)
        {
            mygeneric1<int>.AddandPrint(100,200);//这里<int>就是具体类型

            mylist<string> Mylist = new mylist<string>("first");//这里开始是第二个的调用
            Mylist.Append("second");
            mylist<int> Mylist2 = new mylist<int>(12);
            Mylist2.Append(1234);
            Console.WriteLine(Mylist2.ToString());
            Console.ReadKey();
        }
        /// <summary>
        /// 这里就是泛型的应用一
        /// </summary>
        /// <typeparam name="T"></typeparam>
        class mygeneric1<T>//这里的<T>是个占位，到了实例的时候再决定类型
        {
            public static void AddandPrint(T t1, T t2)
            {
                Console.WriteLine(string.Format(" the value is {0}", t1.ToString() + " @ " + t2.ToString()));
            }
        }
        /// <summary>
        /// 这里是泛型的应用二
        /// </summary>
        /// <typeparam name="T"></typeparam>
        class mynode<T>
        {
            public mynode(T t)
            {
                this.Data = t;
            }
            public T Data { get; set; }//没懂
            public mynode<T> Next { get; set; }//没懂
            public override string ToString()
            {
                return Data.ToString();
            }
        }

        class mylist<T>
        {
            public mynode<T> head { get; set; }
            public mylist(T t)
            {
                head = new mynode<T>(t);
            }
            public void Append(T t)//向后添加新的node
            {
                mynode<T> temp = this.head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }//从这里出来的temp是最后一个node
                mynode<T> newnode = new mynode<T>(t);
                temp.Next = newnode;
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                mynode<T> temp = this.head;
                int index = 0;
                do
                {
                    sb.Append(string.Format("the {0} element is {1}",index,temp.Data.ToString() + "/"));
                    index++;
                    temp = temp.Next;
                }
                while (temp != null);
                return sb.ToString();
            }
        }
    }
}
