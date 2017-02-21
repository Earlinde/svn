using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal panda = new Animal("panda","sichuan");
            Animal cat = new Animal("cat","everywhere",20);
            Animal people1 = new people();//反过来不行,前父后子
            people people2 = new people();
            panda.introduce();
            cat.introduce();
            people1.introduce();
            people2.introduce();

            Console.ReadKey();
        }

        public interface AnimalAction//这里是接口，里面有动作
        {
            void introduce();
            
            //int X { get; set; }
        }

        public class Animal:AnimalAction{//这里是animal的
            string name;
            string local;
            int age;

            public Animal() { }

            public Animal(string name,string local)
            {
                this.name = name;
                this.local = local;
            }

            public Animal(string name, string local,int age)
            {
                this.name = name;
                this.local = local;
                this.age = age;
            }

            public void introduce()
            {
                if (age != 0)
                {
                    Console.WriteLine("the {0}'s location is {1} and their average,age is {2} \n", name, local,age);
                }
                else
                {
                    Console.WriteLine("the {0}'s location is {1}. \n", name, local);
                }
            }

        }

        public  class people:Animal
        {
            //私有成员其实已经被继承了，但是它们却不可以被访问
            public new void introduce()//重写了方法
            {
                Console.WriteLine("people locate in earth and their average age is 100 \n");
            }
        }
    }
}
