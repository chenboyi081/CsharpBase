using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1  实现要求用户一直输入用户名和密码，只要不是admin、888888就一直提示要求重新输入,如果正确则提登录成功.
            //while (true)
            //{
            //    Console.Write("用户名:");
            //    string userName = Console.ReadLine(); 

            //    Console.Write("密码:");
            //    string pwd = Console.ReadLine();

            //    if (userName == "admin" && pwd == "888888")
            //    {
            //        Console.WriteLine("身份验证成功");
            //        break;
            //    } 

            //}

            //求1-100之间6的倍数的个数

            //int i = 1;
            //int j = 0;
            //while (i <= 100)
            //{
            //    if (i % 6 == 0)
            //    {
            //        j++;
            //    }
            //    i++;
            //}
            //Console.WriteLine(j);



            //判断101-200之间有多少个素数，并输出所有素数。  
            //素数指在一个大于1的自然数中，除了1和此整数自身外，不能被其他自然数整除的数 ***** 


            //a. 遍历101-200之间的每1个整数.
            //int i = 101;
            //while (i <= 200)
            //{
            //判断i是不是1个素数. 这个数只能被1和本身整除.
            //11  把2-10中的每1个整数遍历出来. 被i去模. 只要有1个的结果为0 那么就不是素数 。
            //当所有的都不为0的时候 才是素数.
            //2到i-1中的每1个整数遍历出来.

            //    int j = 2;

            //    bool isSuShu = true;

            //    while (j < i) //102
            //    {
            //        if (i % j == 0)
            //        {
            //            isSuShu = false;
            //            //Console.WriteLine(i + "不是素数");
            //            break;
            //        }
            //        j++;
            //    }
            //    if (isSuShu)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    //i什么情况下是素数. 当上面的循环正常结束. 就是素数.
            //    //如果j的值和i的值 相等 那么就是正常结束的.
            //    //if (j == i)
            //    //{
            //    //    Console.WriteLine(i);
            //    //}

            //    i++;
            //}





            // 猜数字游戏.  随机产生1个1-100之间的数 让用户猜  当用户输入的数比产生的随机数大 就输出 猜大了。
            //  当用户输入的数比产生的随机数小的时候 就输出 猜小了。。。当用户刚好输入的就是这个随机数的时候 提示成功  并显示用户猜了多少次.

            //a.  产生1个随机数.
            // b.  反复的让用户去猜这个数.


            //Random r = new Random();
            //int num = r.Next(1, 101);
            //int ciShu = 0;
            //while (true)
            //{
            //    ciShu++;
            //    Console.WriteLine("请输入1个数:");
            //    int guess = int.Parse(Console.ReadLine());
            //    if (guess > num)
            //    {
            //        Console.WriteLine("猜大了");
            //    }
            //    else if (guess < num)
            //    {
            //        Console.WriteLine("猜小了");
            //    }
            //    else
            //    {
            //        Console.WriteLine("恭喜你.猜对了,猜了" + ciShu + "次");
            //        break;
            //    }
            //}


           // 编一个程序，输入用户名和密码，实现用户登录程序的功能，至多允许输入三次，超过三次不允许登录就退出程序.

            //int i = 0;

            //while (true)
            //{
            //    i++;
            //    Console.WriteLine("用户名:");
            //    string userName = Console.ReadLine();
            //    Console.WriteLine("密码:");
            //    string pwd = Console.ReadLine(); 
            //    if (userName == "admin" && pwd == "888888")
            //    {
            //        Console.WriteLine("身份验证成功");
            //        break;
            //    } 
            //    if (i > 2)
            //    {
            //        Console.WriteLine("启动自爆装置");
            //        break;
            //    }
            //}





            Console.ReadKey();

        }
    }
}

