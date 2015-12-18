using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03GoTo
{
    class Program
    {
        static void Main(string[] args)
        {
        /* 1. goto语句
         *    可以把CPU牵引到另外的1个地方开始执行.
         *    
         * 2. 步骤.
         *    a. 先起1个地名. 名字随意.
         *    b. 在需要牵引的地方 写上 goto 地名
         *       在执行到goto这句代码的时候,CPU就会跳到那个地名开始执行,
         * 
         * 3. 尽量的减少goto语句的使用,在十分安全的情况下 建议使用.
         *    
         * 
         */

            int i = 0;
            loop:
            Console.WriteLine("我爱你");
            i++;
            if (i < 5)
            {
                goto loop;
            }



            //   itcast:
            //Console.WriteLine("A");
            //Console.WriteLine("B");
            //Console.WriteLine("C");
            //Console.WriteLine("D");
            //Console.WriteLine("E");
            //goto itcast;
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");





            Console.ReadKey();
        }
    }
}
