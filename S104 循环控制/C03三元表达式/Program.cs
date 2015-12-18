using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03三元表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.有三个数据参与的表达式.三元表达式.
             *   
             * 2.语法
             *   bool表达式?值1:值2; 
             * 3.三元表达式的结果.
             *   如果bool表达式的值为true，那么这个三元表达式的结果为值1.
             *   如果bool表达式的值为false，那么这个三元表达式的结果为值2.
             *   
             *   所以三元表达式的结果要么是值1,要么是值2,所以结果的类型和值1、值2的类型一致.
             *   
             * 4.要注意的细节.
             *   a. bool表达式的后面是1个?  值1和值2之间使用冒号隔开的.
             *   b. 值1和值2的数据类型必须要相同或者兼容. 只有这样才可以用1个变量接收他的结果.
             *   c. 三元表达式一定是可以用if-else结构来代替的.
             * 
             */


            int i1 = 12, i2 = 11, i3 = 19;

            int max = (i1 > i2 ? i1 : i2) > i3 ? (i1 > i2 ? i1 : i2) : i3;

            Console.WriteLine(max); 

            string s = i1 > i2 ? "中" : i1.ToString();


            //int i = 12;
            //if (i > 10)
            //{
            //    Console.WriteLine("我爱北京天安门");
            //}
            //else
            //{
            //    Console.WriteLine("我爱广州小蛮腰");
            //}


            //string str = i > 12 ? "我爱北京" : "我爱广州";
            //Console.WriteLine(str);




            //int i = 12;
            //string res = i > 10 ? "中国" : "日本"; 


            //int j = 12;
            //string str = "";
            //if (j > 10)
            //{
            //    str = "中国";
            //}
            //else
            //{
            //    str = "日本";
            //}





            Console.ReadKey();
        }
    }
}
