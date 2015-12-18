using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02作业
{
    class Program
    {
        static void Main(string[] args)
        {

            //      1. 提示用户输入用户名，然后再提示输入密码，如果用户名是“admin”并且密码是“888888”，就提示正确
            //否则提示到底是谁错了. 
            //用户名错了.
            //密码错了
            //用户名密码都错. 

            //用户的数据需不需要转换:
            //a. 这个数据参与算术运算 大小比较. 要做转换数值类型.
            //b. 只做相等或者不等比较 没有必要转换. 因为字符串也可以做相等不等比较 。
            //c. 数据本身能不能转换.
            //Console.Write("用户名:");
            //string userName = Console.ReadLine();
            //Console.Write("密码:");
            //string pwd = Console.ReadLine();  
            //if (userName == "admin" && pwd == "888888")
            //{
            //    Console.WriteLine("身份验证成功");
            //} 
            ////a.用户名错误但是密码正确  密码正确但是用户名错误 都错误.
            ////什么情况下才是 密码错误 用户名正确.
            //else if (userName == "admin")
            //{
            //    Console.WriteLine("密码错误,");
            //}
            //else if (pwd == "888888")
            //{
            //    Console.WriteLine("用户名错误");
            //}
            //else
            //{
            //    Console.WriteLine("用户名和密码都错误");
            //}



            //提示用户输入年龄，如果大于等于18，则告知用户可以查看，
            //如果小于10岁，则告知不允许查看，
            //如果大于等于10岁并且小于18，则提示用户是否继续查看（yes、no），如果输入的是yes则提示用户请查看，否则提示"退出,你放弃查看"。



            //Console.WriteLine("请输入你的年龄:");
            //int age = int.Parse(Console.ReadLine());

            //if (age >= 18)
            //{
            //    Console.WriteLine("好吧,给你看点更好看的....");
            //}
            //else if (age < 10)
            //{
            //    Console.WriteLine("你妈妈喊你回家吃饭......");
            //}
            //else
            //{
            //    //说明年龄在10-17的范围之内.
            //    Console.WriteLine("你确定要看吗?  y/n");
            //    string ans = Console.ReadLine();
            //    if (ans == "y")
            //    {
            //        Console.WriteLine("好吧,给你看...");
            //    }
            //    else
            //    {
            //        Console.WriteLine("真乖,回家去吧..");
            //    }

            //}



            //编一个程序，输入一个整数,如果该数大于0，则加上100，如果小于0加上500，如果等于0,则什么都不做输出结果

            //Console.WriteLine("请输入1个数:");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num > 0)
            //{
            //    num += 100;  num=num+100;  //10
            //}
            //else if (num < 0)
            //{
            //    num += 500; 
            //}

            //Console.WriteLine(num);



            //      由用户输入鸡蛋的总数量,如果坏蛋率小于10%,则吃掉,否则找超市去退货. 坏蛋的数量随机产生
            //坏蛋率: 坏蛋的数量/鸡蛋的总数量.
            //100
            //5

            //Console.WriteLine("请输入鸡蛋的总数量:");
            //int egg = int.Parse(Console.ReadLine());//100

            ////产生1个0-100的随机数 然后求坏蛋率. 
            //Random r = new Random();
            //int badEgg = r.Next(0, egg + 1);
            //Console.WriteLine("坏蛋的数量:" + badEgg);
            ////求坏蛋率 
            //double rate = badEgg * 1.0 / egg;
            //Console.WriteLine("坏蛋率:" + rate);
            //if (rate < 0.1)
            //{
            //    Console.WriteLine("吃掉..");
            //}
            //else
            //{
            //    Console.WriteLine("退货..");
            //}


            //输入一个正数，对该数进行四舍五入到个位数的运算。
            //例如，实数12.56经过四舍五入运算，得到结果13；而12.46经过四舍五入运算，得到结果12。***** 

            //double d = 12.16;
            ////得到小数部分的整数部分.
            //int num = (int)d;//12
            ////得到小数部分
            //double xiaoShu = d - num;//0.56
            ////判断小数部分的值.如果大于等于0.5 入 否则舍
            //if (xiaoShu >= 0.5)
            //{
            //    num++;
            //}
            //Console.WriteLine(num); 


            ////12.123456
            //double d = 12.1287899;
            //double d1 =  Math.Round(d,2);
            //Console.WriteLine(d1);




            //8.判断输入的年份是否是闰年.年份要求由用户输入
            //   润年的判定(符合下面两个条件之一):
            //     a.让用户年份能够被400整除.
            //     b.年份能够被4整除但不能被100整除.  
            //   如果是闰年 就打印是闰年 如果不是闰年 就打印不是闰年, 

            //Console.WriteLine("请输入年份:");
            //int year = int.Parse(Console.ReadLine());
            //if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            //{
            //    Console.WriteLine("是1个闰年");
            //}
            //else
            //{
            //    Console.WriteLine("不是闰年.");
            //} 

            //10  20   20  

            //9.编一个程序，从键盘上输入三个数，把最大数找出来。  ***
            int i1 = 12, i2 = 20, i3 = 20;
            if (i1 > i2)
            {
                //说明i1和i2中 i1是最大的.
                if (i1 > i3)
                {
                    Console.WriteLine(i1);
                }
                else
                {
                    Console.WriteLine(i3);
                }
            }
            else
            {
                //说明i1和i2中 i2是最大的.
                if (i2 > i3)
                {
                    Console.WriteLine(i2);
                }
                else
                {
                    Console.WriteLine(i3);
                }
            }





            Console.ReadKey();
        }
    }
}
