using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C01Review
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.while循环
             * 2.do-while循环
             * 3.for循环
             * 
             * 
             */

            // 循环录入5个人的年龄并计算平均年龄,如果录入的数据出现负数或大于100的数,立即停止输入并报错.

            //int sum = 0;
            //bool flag = true;//flag 旗帜 标志.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("请输入第{0}个人的年龄:", i + 1);
            //    int age = int.Parse(Console.ReadLine());
            //    if (age < 0 || age > 100)
            //    {
            //        Console.WriteLine("非法年龄,程序结束");
            //        flag = false;
            //        break;
            //    }
            //    sum += age;
            //}
            //if (flag)
            //{
            //    Console.WriteLine("平均年龄是:" + (sum / 5));
            //}


            // 1~100之间的整数相加，得到累加值大于20的当前数 1+2+3+4+5+6 break.
            //int sum = 0;
            //for (int i = 1; i < 101; i++)
            //{
            //    sum += i;
            //    if (sum > 20)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}


            //计算1到100(含)之间的除了能被7整除之外所有整数的和。 
            //1-100之间不能够被7整除的数的和.
            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 7 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);


            //6 .求1-100之间6的倍数的个数

            //int j = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 6 == 0)
            //    {
            //        j++;
            //    }
            //}
            //Console.WriteLine(j);


            //随机产生10个3-200之间的随机数,求出其中的最大值.

            //Random r = new Random();
            //int max = int.MinValue;
            //for (int i = 0; i < 10; i++)
            //{
            //    int num = r.Next(3, 201);
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine("最大值:" + max);


            //本金10000元存入银行，年利率是千分之三，每过1年，
            //将本金和利息相加作为新的本金。计算5年后，获得的本金是多少？ 
            //decimal money = 10000; 
            //for (int i = 0; i < 5; i++)
            //{
            //    money = money * 1.003m;
            //} 
            //Console.WriteLine(money);
            





             

            Console.ReadKey();
        }
    }
}
