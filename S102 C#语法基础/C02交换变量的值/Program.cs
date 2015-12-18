using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02交换变量的值
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 变量之间的相互赋值.
             *     将源变量中的值拷贝1份,将这个副本赋值给目标变量.
             *     赋值完成以后,源变量中的值仍然存在.
             *     
             *  
             * 2. 交换变量的值.
             *    a. 声明1个临时变量.转圈.
             *       任意的数据类型之间的交换(前提是可以交换)都可以用这种方式.
             *    b. 如果交换的变量的类型是数值类型的.
             *       两数相加再相减.
             * 
             */

         
            int num1 = 12;
            int num2 = 20; 

            num1 = num1 + num2;//32
            num2 = num1 - num2;//12
            num1 = num1 - num2;//20


            ////准备1个空的变量.
            //int temp = num1;
            //num1 = num2;
            //num2 = temp;

            Console.WriteLine("num1=" + num1 + ",num2=" + num2);


            //int num1 = 12;
            //int num2 = num1;

            //Console.WriteLine(num2);

            Console.ReadKey();
        }

    }
}
