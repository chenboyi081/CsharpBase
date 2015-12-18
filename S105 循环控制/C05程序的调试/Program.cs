using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C05程序的调试
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 我们将代码交给CPU执行. 那么CPU会在很快的时间里 咻 一下把他们执行完毕.
             * 
             * 2. 我们希望CPU啊 你不要那么快 慢慢来.
             *    使用Visual Studio提供的调试功能,可以让CPU在执行代码的时候,
             *    一句一句的执行. 根据我们的指令1句1句的执行代码. 
             *    方便我们观测程序的执行过程.
             *    
             * 3. 断点:
             *    当我们以调试模式运行(按下F5或者按下启动按钮)这个程序的时候.
             *    当CPU执行到断点的这句代码的时候,CPU会暂停.
             *    
             *    当运行起来以后,执行到断点的那句代码的时候,CPU会暂停执行.
             *    并黄色高亮选中断点行的代码,
             *    表示CPU立即要执行这句代码,但是还没有执行.
             *    等待我们的指令.
             *    
             *    F10: 告诉CPU执行当前黄色高亮选中的代码. 并高亮选中下1次要执行的代码 等待我们的指令.
             *    
             * 4. 作用:
             *    自己检测老师有没有骗你.
             *    a. 在调试的过程中,监视变量的值 以排除程序的错误.
             *     
             *    程序运行的结果不是我们期待的那样 。
             *    
             */

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("我爱北京");
                i++;
            }




            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}



            //int i = 12;
            //if (i > 10)
            //{
            //    Console.WriteLine(" 哈哈哈哈.");
            //}
            //Console.WriteLine("OVER");



            //Console.WriteLine("今天真热啊,夏天来了.."); 
            //Console.WriteLine("我爱北京");
            //Console.WriteLine("我爱广州");
            //Console.WriteLine("哈哈哈哈");



            Console.ReadKey();


        }
    }
}
