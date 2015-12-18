using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C08NULL值
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. null只能是引用类型的变量的值.不能是值类型变量的值.
             * 
             * 2. 如果1个引用类型的变量的值为null.代表这个引用类型的变量没有指向任何对象.
             * 
             * 3. 未将对象的引用设置到对象的实例:
             *    说明我们尝试通过1个引用类型的变量,去调用这个引用类型的变量所指向的对象的成员.
             *    但是这个引用类型的变量没有指向任何对象.
             * 
             * 
             * 
             */

            Person p = null;
            p.SayHi();


            p.wangCai = new Dog();
            p.wangCai.Shout();
           

         

          



            Console.ReadKey();
        }
    }
}
