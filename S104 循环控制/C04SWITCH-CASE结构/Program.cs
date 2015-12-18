using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C04SWITCH_CASE结构
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. switch-case 选择结构.  if-else 判断结构.
             * 
             * 2. 语法.
             *    switch(表达式)
             *    {
             *      case 值1:
             *        执行代码1;
             *        break;
             *      case 值2:
             *         执行代码2;
             *         break;
             *      case 值3:
             *         执行代码3;
             *         break;
             *       default:
             *         执行代码;
             *         break;
             *    }
             *    
             * 3. 执行步骤.
             *    计算switch表达式的结果. 将这个结果从上到下的逐个的和每1个case块后面的值做相等判断.
             *    只要有1个值相等,那么就会执行其中的代码,执行完毕以后,结束整个结构.
             *    如果所有的case块后面的值,和表达式的结果都不相等 那么就执行default中的代码.
             *    
             * 4. 注意
             *    a. switch后面可以写1个表达式 也可以直接写1个数据.
             *    b. 每1个case块后面的break在绝大多数情况下必不可少.
             *    c. switch表达式的结果不能为 浮点型.
             *       可以为string char 整型(long int short byte) bool 
             *    d. case块后面的数据的类型 必须要与 switch表达式的结果的类型一致,因为是将switch表达式的而结果和case后面的数据做相等比较.
             *    e. case块可以有任意个,根据我们的具体情况来决定的.
             *    f. default是可以省略的,如果省略的话,那么就没有默认执行代码了.
             *    g. 如果多个case块的处理逻辑是相同的.那么可以使用简写的方式.
             *    h. case块后面可以写1个表达式,但是这个表达式不能有变量参与.
             *    
             * 5. 使用switch-case结构写的代码 我们使用if结构一定可以写.
             *    switch-case结构 只能做等值判断. 不能直接做范围判断.
             *    if结构 即可以做等值判断 也可以做范围判断.
             *    所以if结构的代码 使用switch-case不一定可以写出来.
             *  
             * 6. 如果是等值判断判断 就用switch结构.
             *    如果是范围判断 就用if结构.
             * 
             */


            //int i1 = 10; int i2 = 90; int i3 = 60;

            //if (i1 > i3)
            //{
                
            //}
            //else
            //{
            //    Console.WriteLine(i3);
            //}



            //输入星期天是 打出对应英文的星期天  1   2 



            //使用switch-case结构 实现如下功能
            //请用户输入年份 输入月份  2014 2
            //1 3 5 7 8 10 12 31天
            //4 6 9 11 30
            //2 闰年是29   平年28天.
            Console.WriteLine("请输入年份:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入月份:");
            string month = Console.ReadLine(); 
            switch (month)
            {
                case "1":
                case "3":
                case "5":
                case "7":
                case "8":
                case "10":
                case "12":
                    Console.WriteLine("{0}年的{1}月有31天", year, month);
                    break;
                case "4":
                case "6":
                case "9":
                case "11":
                    Console.WriteLine("{0}年的{1}月有30天", year, month);
                    break;
                case "2":
                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    {
                        Console.WriteLine("{0}年的{1}月有29天", year, month); 
                    }
                    else
                    {
                        Console.WriteLine("{0}年的{1}月有28天", year, month);
                    } 
                    break;
                default:
                    Console.WriteLine("你是火星来的吧.");
                    break;
            }




            //int i = 12;
            //switch (i)
            //{
            //    case 1:
            //        Console.WriteLine("AAAAAAAa");
            //        break;
            //    default:
            //        break;
            //}




            //Console.WriteLine("请输入土豪的儿子的成绩:");
            //int score =int.Parse(Console.ReadLine());
            //switch (score>60)
            //{
            //    case true:
            //        Console.WriteLine("奖励汽车");
            //        break;
            //    case false:
            //        Console.WriteLine("打他");
            //        break; 
            //}






            //double i = 12;
            //int j = 11;


            //switch (i + j)
            //{
            //    case 12:
            //        Console.WriteLine("A");
            //        break;
            //    default:
            //        Console.WriteLine("AA");
            //        break;
            //}


            //Console.WriteLine("请输入1个月份:");
            //string month = Console.ReadLine();
            //switch (month)
            //{
            //    case "1":
            //    case "2":
            //    case "3": 
            //        Console.WriteLine("春季");
            //        break;
            //    case "4":
            //    case "5":
            //    case "6":
            //        Console.WriteLine("夏季");
            //        break;
            //    case "7":
            //    case "8":
            //    case "9":
            //        Console.WriteLine("秋季");
            //        break;
            //    case "10":
            //    case "11":
            //    case "12":
            //        Console.WriteLine("东季");
            //        break;
            //    default:
            //        Console.WriteLine("你是从火星来的吧");
            //        break;
            //}



            //请写1个程序,让用户输入1个月份,把这个月的季节打出来.
            //123 春   456 
            //Console.WriteLine("请输入1个月份:");
            //string month = Console.ReadLine();
            //if (month == "1" || month == "2" || month == "3")
            //{
            //    Console.WriteLine("春季");
            //}
            //else if (month == "4" || month == "5" || month == "6")
            //{
            //    Console.WriteLine("夏季");
            //}
            //else if (month == "7" || month == "8" || month == "9")
            //{
            //    Console.WriteLine("秋季");
            //}
            //else if (month == "10" || month == "11" || month == "12")
            //{
            //    Console.WriteLine("冬季");
            //}
            //else
            //{
            //    Console.WriteLine("你是从火星来的吧..");
            //}


            //  Console.WriteLine("请输入你现在想说的话:");
            //  string input = Console.ReadLine(); 
            //  switch (input)
            //  {
            //      case "哈哈":
            //          Console.WriteLine("你现在的心情一定很爽");
            //          break;
            //      case "呵呵":
            //          Console.WriteLine("你现在一定很无奈");
            //          break;
            //      case "嘿嘿":
            //          Console.WriteLine("你一定干了亏心事");
            //          break;
            //      default:
            //          Console.WriteLine("你说的什么我也不懂");
            //          break;
            //  } 
            //Console.WriteLine("OVER");



            Console.ReadKey();
        }
    }
}
