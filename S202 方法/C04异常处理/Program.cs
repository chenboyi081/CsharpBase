using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C04异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 错误: 指的我们书写的源代码不符合C#语法规范,导致编译的时候失败。 也就无法运行.
             *    解决方式:将我们的代码改成符合规范的.
             *    良好的写代码的习惯:
             *      发现红线立即消灭. 
             *      
             * 2. 异常:代码没有错误完全符合C#语法规范,可以编译并运行.
             *    只不过在运行的时候,当程序处于某种特定条件下的时候,运行就会出错.
             *    
             *    异常不是一定会发生的,只有处于某中特定的情况的时候才会发生.
             *    
             *    程序运行的时候如果发生异常,那么程序就会崩溃. 程序就会停止.
             *    从发生异常的那句代码 后面的代码不会执行.
             *    
             * 3. 处理异常:
             *    目的:  当程序发生异常的时候,不要崩溃.给用户1个友好的提示.
             *    a. 能够使用代码逻辑来出处理的,那么就使用代码逻辑来处理.   
             *    
             *    b. try-catch来处理异常.
             *       1). 首先使用try将有可能会发生异常的代码围起来.
             *       2). 在try的后面紧跟1个catch块.
             *       执行的步骤.
             *           当try块中的代码在执行的时候发生了异常,会立即跳转到catch块中执行代码.如果try后面还有代码不会执行
             *           执行完毕以后,继续往下执行. 特别注意的是:此时不会崩溃.
             *           如果try中没有发生异常,就跳过catch中的代码继续往下执行
             *           
             *   c.分门别类的处理异常.
             *        在try中有多个地方可能都会发生异常. 而我们想要在catch中知道到底是哪里发生了异常.
             *        第一种方式: 定义标识量, 根据标识量的值来确定在什么地方发生错误.
             *          a. 在catch的后面加1个小括弧 在小括弧中声明1个Exception类型的变量.
             *          b. 当try中的代码发生异常的时候.系统就会将发生异常的信息 赋值给 这个Exception类型的变量.
             *             异常的信息包括: 发生异常的地点. 发生的异常原因,  发生时间.
             *             直接将ex变量的值打印出来  就会把如上信息打印.
             *             
             *             ex.Message 取出异常发生的原因 描述的信息.
             *   
             *   d. 在catch后面还可以跟1个finally块.
             *      finally中的内容 无论try中是否发生异常 都会执行.
             * 
             * 
             * 4. 我们在try的时候,尽量只try有可能会发生异常的代码.  因为try-catch是比较消耗性能的.
             *    
             * 
             * 
             */


            //写1个程序,由用户输入班级的人数,然后输入每个人的成绩. 如果输入的成绩不是整数或者不在0-100的范围之内 要求重新输入.
            //输入完毕以后 求总成绩和平均成绩
            //再去掉1个最高分 去掉1个最低分的平均成绩.
            //将成绩从高到第的打印出来.
             
               

            //Console.WriteLine("请输入第1个数:");
            //try
            //{ 
            //    int numA = int.Parse(Console.ReadLine()); 
            //    Console.WriteLine("请输入第2个数:");
            //    int numB = int.Parse(Console.ReadLine()); 
            //    int res = numA / numB;
            //    Console.WriteLine(res);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally//最终.
            //{
            //    Console.WriteLine("我是finally");
            //} 
            //Console.WriteLine("哈哈哈哈哈哈哈哈哈,有人做俯卧撑了...");




            #region 使用标识两来分门别类的处理异常.
            //int i = 0;
            //try
            //{
            //    Console.WriteLine("请输入第1个数:");
            //    int numA = int.Parse(Console.ReadLine());
            //    i++;
            //    Console.WriteLine("请输入第2个数:");
            //    int numB = int.Parse(Console.ReadLine());
            //    i++;
            //    int res = numA / numB;
            //    Console.WriteLine(res);
            //}
            //catch
            //{
            //    if (i == 0)
            //    {
            //        Console.WriteLine("第1个数必须是整数");
            //    }
            //    else if (i == 1)
            //    {
            //        Console.WriteLine("第2个数必须是整数");
            //    }
            //    else if (i == 2)
            //    {
            //        Console.WriteLine("除数不能为零");
            //    }
            //}
            
            #endregion





            //请写1个程序,从控制台接受用户输入1个整数m,如果不是整数 重新输入 直到是1个整数为止. 
            //    Console.WriteLine("请输入1个整数:");
            //loop:
            //    try
            //    {
            //        int num = int.Parse(Console.ReadLine());
            //    }
            //    catch
            //    {
            //        Console.WriteLine("你输入的不是1个整数,请重新输入:");
            //        goto loop;
            //    }











            //Console.WriteLine("请输入你的年龄:"); 
            //try
            //{
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    if (age >= 18)
            //    {
            //        Console.WriteLine("成年");
            //    }
            //    else
            //    {
            //        Console.WriteLine("未成年");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("亲,年龄只能是1个整数.");

            //    //Console.WriteLine("哈哈哈,我是catch的小行家...");
            //}


            //Console.WriteLine("OVER");





            //Console.WriteLine("请输入第1个数:");
            //int numA = int.Parse(Console.ReadLine());

            //Console.WriteLine("请输入第2个数:");
            //int numB = int.Parse(Console.ReadLine());

            //if (numB == 0)
            //{
            //    Console.WriteLine("亲,除数不能为零哦...");
            //}
            //else
            //{
            //    int res = numA / numB;
            //    Console.WriteLine(res);
            //}


            //Console.WriteLine("我爱北京.....");


            Console.ReadKey();
        }
    }
}
