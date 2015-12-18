using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02嵌套循环
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 嵌套循环:
             *     a.循环体中包含有1个循环结构.
             *     b.不要想太多. 就把里面的循环当做外面的循环的1个循环体就可以了.
             *       反正外面的循环条件成立的时候 就会执行循环体,只不过这个循环体中有1个循环结构.
             *       
             * 
             * 2. 地球和太阳的故事.
             *    地球绕着太阳转: 转1圈是1年 公转.
             *    地球绕着太阳转的同时,地球也在自转. 转1圈是1天. 
             *    当地球公转完1圈的时候 地球自转365圈.
             *    
             * 3. 外层循环循环1次,内层循环要循环所有次.
             *   
             * 
             * 
             * 
             * 
             */

            for (int i = 1; i <= 9; i++)//外层循环 每循环1次就表示打印九九表的1行.
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", j, i, j * i);
                }
                Console.WriteLine();
            }



            //请写1个程序,由用户输入1个数字.  n
            //然后打印n行 每1行有n颗星.
            //****
            //****
            //****
            //****


            //int num = 4; 
            //for (int i = 0; i < 4; i++) //循环1次, 就打印1行.
            //{
            //    //而1行中有4颗星.
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("*");//把这些星打印在同1行.
            //    }
            //    Console.WriteLine();//换行.
            //}











            //for (int i = 0; i < 3; i++)//循环1次 代表 地球公转1圈.
            //{
            //    Console.WriteLine("第{0}年开始了", i + 1);
            //    for (int j = 0; j < 365; j++)//自转
            //    {
            //        Console.WriteLine("\t第{0}天结束了", j + 1);
            //    }
            //    Console.WriteLine("第{0}年结束了", i + 1);
            //}



            Console.ReadKey();
        }
    }
}
