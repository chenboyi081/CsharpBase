using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C06Do_While循环
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. do-while循环:
             *    仍然是循环. 仍然是将1段代码进行反复不停的执行的.
             *    
             * 2. 语法:
             *    do
             *    {
             *       循环体;
             *    }while(bool表达式);
             *    
             * 3. 执行步骤.
             *    1. 不管3721先执行1次循环体.
             *    2. 计算while后面的bool表达式的结果
             *       2.1 如果结果为true，就再执行循环体. 跳回到第2步继续执行.
             *       2.2 如果结果为false，就结束do-while循环.
             *       
             *    先不管循环条件是否成立,先执行1次. 要不要继续执行呢?这个时候才看条件.
             *    
             * 4. do-while循环与while循环.
             *    a. do-while 是先执行 再判断.  先斩后奏.
             *       while循环是先判断 再执行.  小心翼翼
             *    b. 在循环条件第1次都不成立的情况下.
             *       do-while循环会执行1次循环体.
             *       while循环1次也不会执行.
             *       
             * 5. do-while啥时候用?
             *    如果循环体无论如何都要执行1次的时候,那么就可以使用这个结构.
             * 
             * 6. break与continue都可以使用在do-while中.
             *    
             * 7. do-while循环 其实 使用while循环也是可以写的.
             *    while(true)
             *    {
             *       .......
             *       break
             *    }
             *    
             *    
             */



            //张三先唱一遍要表演的歌曲,老师觉得张三唱歌不过关,就让张三再唱一遍,
            //老师满意则张三可以下课,不然则需要再唱一遍,再问老师是否满意...
            //string ans = "";
            //do
            //{
            //    Console.WriteLine("张三在唱歌:  啦啦啦啦啦啦啦....");
            //    Console.WriteLine("老师,你满意不? y/n");
            //    ans = Console.ReadLine();
            //} while (ans != "y");



            //不断要求用户输入一个数字，当用户输入end的时候显示刚才输入的数字中的最大值
            //int max = int.MinValue;
            //do
            //{
            //    Console.WriteLine("请输入1个数:");
            //    string input = Console.ReadLine();//此时有肯那个输入 数值 "end"
            //    if (input == "end")
            //    {
            //        Console.WriteLine(max);
            //        break;
            //    }
            //    else
            //    {
            //        int num = Convert.ToInt32(input);
            //        if (num > max)
            //        {
            //            max = num;
            //        }
            //    }
            //} while (true);



            // 不断要求用户输入一个数字，然后打印这个数字的二倍，当用户输入q的时候程序退出。

            //do
            //{
            //    Console.WriteLine("请输入1个数:");
            //    string input = Console.ReadLine();
            //    if (input == "q")
            //    {
            //        break;
            //    }
            //    int num = int.Parse(input); 
            //    Console.WriteLine(num * 2);
            //} while (true);





            //不断要求用户输入学生姓名,输入q结束.
            //string name = "";
            //do
            //{
            //    Console.WriteLine("请输入学生的姓名:");
            //    name = Console.ReadLine();
            //}while(name!="q");
            //while (true)
            //{
            //    Console.WriteLine("请输入学生的姓名:");
            //    string name = Console.ReadLine();
            //    if (name == "q")
            //    {
            //        break;
            //    }
            //}



            //1.：计算1到100之间整数的和；

            //int sum = 0;
            //int i = 1;
            //while (i <= 100)
            //{
            //    sum += i++; 
            //}
            //Console.WriteLine(sum);



            //请用户输入用户名 只要不正确就再来.
            //string userName = "";
            //do
            //{
            //    Console.WriteLine("请输入用户名:");
            //    userName = Console.ReadLine(); 
            //} while (userName != "admin");



            //int i = 0;
            //do
            //{
            //    Console.WriteLine("我爱北京");
            //    i++;
            //} while (i > 10);





            Console.ReadKey();
        }
    }
}
