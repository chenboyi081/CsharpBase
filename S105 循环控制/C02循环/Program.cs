using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02循环
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 循环: 将1段代码反复不停的执行指定的次数.
             *    循环要确定的事情:
             *    a. 需要被反复不停执行的代码.
             *    b. 循环结束的条件.
             *    
             * 2. 循环结构.
             *    while循环   do-while循环   for循环
             *    他们都是循环结构. 唯一的区别 语法不同.
             * 
             * 
             * 3. while循环.
             *    a. 语法.
             *    while(bool表达式)
             *    {
             *       那段需要被反复不停执行的代码.
             *       循环体;
             *    }
             *    b. 执行步骤
             *      1). 计算bool表达式的结果.
             *            1.1) 如果结果为true:执行循环体,执行完毕以后.跳回第1步继续执行.
             *            1.2) 如果结果为false,就结束循环结构 继续往下执行.
             *            
             *    
             * 4. 循环的应用之一: 循环体确定,循环的次数确定:
             *    a. 声明1个循环增量i 默认值为0.
             *    b. 循环的条件  i<次数.
             *    c. 在循环体中一定要记得去更改循环增量i的值.
             *    
             *    eg: 将代码循环5次.
             *    int i = 0;
             *    while(i<5)
             *    {
             *       循环体;
             *       i++;
             *    }
             *    
             *    注意的地方:
             *    a. 循环增量的值不一定要从0开始. 如果这样的话 循环条件i<数就要适时的发生变化.
             *       绝大多数情况下,都是从0开始的.
             *    b. 循环增量从0开始的话,循环条件就小于 
             *       如果从1开始 就要小于等于.
             *       
             *  
             * 
             * 5. 循环应用之二: 循环体确定、循环次数不确定,但是循环结束的条件确定.
             *    a. 先将循环体写1次,以保证至少执行1次.
             *    b. 根据第1次的结果 写1个条件是否要进入循环. 循环条件写上 要进入循环的条件.
             *       循环条件:
             *       我们确定的是循环结束的条件. 而我们要写上循环继续的条件 
             *    c. 在循环体的内部一定要记得 更改 循环条件表达式中的变量的值. 
             *       否则 循环就会是1个死循环.
             *     
             *    
             * 6. 循环应用之三: 遍历
             *    将1堆数据中的每1个数据拿出来.
             *    eg: 将n到m之间的每1个整数遍历出来.
             *    int i = n; 声明1个循环增量i 赋值为n
             *    while(i<=m)
             *    {
             *       i就是我们遍历出来的那个数.
             *       i++;
             *    }
             *  
             * 
             * 7. 循环应用之四: 求1堆数据中的符合特定条件的数.
             *    a. 遍历这堆数据中的每1个数据.
             *    b. 判断遍历出来的数据是否符合特定的条件.
             *    
             *    eg: 求1-100之间的偶数.
             *    int i =1;
             *    while(i<=100)
             *    {
             *        if(i是符合特点条件的)
             *        {
             *            i就是我们要找的.
             *        }
             *        i++;
             *    }
             *    
             * 
             * 8. 循环的应用之五: 求累加和与平均值.
             *    求1堆数据的累加和:
             *    a. 声明1个"桶"变量 用来保存累加和.
             *    b. 遍历这堆数据中的每1个数,将遍历出来的数累加到"桶"变量中去.
             *    c. 遍历完成以后,"桶"变量中存储的就是累加和
             *    
             *    注意的是:
             *    a. 在循环体中是累加 不是赋值.
             *    b. "桶"变量一定要声明在while的外面.变量的作用域.
             * 
             * 
             * 
             * 9.循环的应用之六:求最大值 最小值.
             *   求1堆数中的最大值或者最小值.
             *   a. 声明1个"擂台变量"  用来保存最值.
             *   b. 遍历这1堆数中的每1个数.把遍历出来的数和擂台上的数做比较.
             *      比的过就上 比不过就走.
             *   c. 当遍历完成以后. "擂台" 变量中的值 就是这1堆数中的最值.
             *   
             *   需要注意的是.
             *   a. 擂台变量的值不能直接赋值为0.
             *      a.1  擂台变量的值 赋值为 这堆数中的任意1个.
             *      a.2  擂台变量的值 赋值为 全世界最戳的那个值.
             *   
             * 
             * 10. 循环应用之七: 穷举.  1个1个的试
             *    
             * 11. 循环的应用之八:计数
             * 
             * 
             * 12. break.
             *     a. 可以用在switch-case结构中.  代表立即结束整个switch结构.
             *     b. 还可以用在循环体中. 在循环体中如果执行到break 就会立即结束当前循环.
             *        如果break后面还有代码.那么后面的代码不会执行了.
             *     c. 什么时候使用break
             *        对于循环次数不确定的循环.我们清楚的是 循环结束的条件.
             *        但是事实上我要写的是 循环继续的条件.
             *        
             *        1). 先写1个"死"循环.
             *        2). 在循环体的内部 判断循环是否应该结束 使用break结束循环.
             *            这样做的好处.在于我们是确定循环结束的条件的,
             *            可以很快速的就把循环结束的条件写出来.
             *     
             * 
             * 13. continue
             *     a. 只能使用在循环体中.代表立即结束本次循环.准备进入下1次循环.
             *     b. 如果遇到了continue 就会立即的结束本次循环,如果循环体没有执行完,continue后面还有代码.
             *        那么后面的代码是不会执行的.
             *     
             * 
             */

            int i =0;
            while (i < 5)
            { 
                if (i == 2)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                
            }
            Console.WriteLine("OVER");



            //4. 2006年培养学员80000人，每年增长25%，请问按此增长速度，到哪一年培训学员人数将达到20万人？

            //int year = 2006;
            //double num = 80000; 
            ////算法:穷举. 2007 10w     2008 125000   2009 156250  2010  19w  2011 


            //while (true)
            //{
            //    num = num * 1.25;
            //    year++;
            //    if (num >= 200000)
            //    {
            //        Console.WriteLine(year);
            //        break; 
            //    } 
            //}







            //int i = 2;
            //while (true)
            //{
            //    if (i % 2 == 0 && i % 3 == 0 && i % 4 == 0)
            //    {
            //        break;
            //    }
            //    i++;
            //}
            //Console.WriteLine(i);




            //while (true) 
            //{
            //    Console.WriteLine("输入用户名:");
            //    string userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码:");
            //    string pwd = Console.ReadLine(); 
            //    if (userName == "admin" && pwd == "888888")
            //    {
            //        break;
            //    }
            //}
            



            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    if (i != 2)
            //    {
            //        break;
            //    }
            //    i++;
            //    Console.WriteLine("哈哈....");
            //}


          










            //string str = "呵呵";
            //switch (str)
            //{
            //    case "呵呵":
            //        Console.WriteLine("A");
            //        break;
            //        Console.WriteLine("B");                     
            //    default:
            //        break;
            //}












            //请统计1-100之间能够被4整除的数的 个数.

            //int i = 1;
            //int j = 0;
            //while (i <= 100)
            //{
            //    if (i % 4 == 0)
            //    {
            //        j++;
            //    }
            //    i++;
            //}

            //Console.WriteLine(j);


            //7. 操场上100多人排队，三人一组多1人，四人一组多2人，五人一组多3人，共多少人？


            //有1个数 这个数至少是2  这个数被3除余1  这个数被4除余1   这个数被2除余1 

            //int i = 2;
            //while (i % 2 != 1 || i % 3 != 1 || i % 4 != 1)
            //{ 
            //    i++;
            //}
            //Console.WriteLine(i);





            //让用户输入五个数,把这5个数中的最大数找出来. 

            //int i = 0;
            ////擂台变量.
            //int min = int.MaxValue;
            //while (i < 5)
            //{
            //    Console.WriteLine("请输入第{0}个数", i + 1);
            //    int num = int.Parse(Console.ReadLine());
            //    if (num < min)
            //    {
            //        min = num;
            //    }
            //    i++;
            //}
            //Console.WriteLine("最大值:" + min);



            //从控制台接受用户输入5名同学的成绩,求总成绩和平均成绩.

            //int i = 0;
            //int sum = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine("请输入第{0}个同学的成绩:", i + 1);
            //    int score = Convert.ToInt32(Console.ReadLine());
            //    sum += score;
            //    i++;
            //}

            //Console.WriteLine("总成绩:" + sum + ",平均成绩:" + (sum / 5));



            //写1个程序,求1-100之间能够被4整除的数 的累加和.

            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    if (i % 4 == 0)
            //    {
            //        sum += i;
            //    }
            //    i++;
            //}
            //Console.WriteLine(sum);


            //求1-100之间的所有的整数的累加和. 
            //int sum = 0;
            //int i = 1;
            //while (i <= 100)
            //{

            //    sum += i;
            //    i++;
            //    Console.WriteLine(sum); 
            //} 




            //求素数:101-200之间的素数找出来.
            //int i = 101;
            //while (i <= 200) //将101到200之间的每1个整数遍历出来 。
            //{
            //    //判断i是不是1个素数.
            //    //19 2-18中的每1个整数遍历出来 被19去模. 14 
            //    //i   只需要把2到i-1中的每1个整数遍历出来 被i模 只要有1个的结果为0 就说明 i不是素数.
            //    //每1个都不为0的时候 才是素数.   15 

            //    //将2到i-1中的每1个整数遍历出来 被i模.
            //    int j = 2;
            //    while (j < i)//  i=102 
            //    {
            //        if (i % j == 0)
            //        {
            //            // Console.WriteLine(i + "不是1个素数");
            //            //让循环结束
            //            j = i + 1;
            //        }
            //        j++;
            //    }
            //    // 
            //    //上面的while循环是正常结束的.说明i是1个素数.
            //    if (i == j)
            //    {
            //        Console.WriteLine(i + "是1个素数.");
            //    }

            //    i++;
            //}




            //1-100中可以被3整除的数找出来. 
            //int i = 1;
            //while (i <= 100)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}







            //1-100之间的偶数找出来. 
            //int i = 1;
            //while (i <= 100)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}





            //将1-10中的每1个整数打印出来
            //循环10次. 
            //int i = 100;
            //while (i <= 200)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} 



            //猜数字游戏: 产生1个 1-100的随机数,让用户反复不停的去猜 直到猜对为止.

            ////a. 产生随机数.
            //Random r = new Random();
            //int ranNum = r.Next(1, 101);//10

            //Console.WriteLine("请猜1个数:");
            //int guess = int.Parse(Console.ReadLine());//2
            //int i = 1;
            //while (guess != ranNum)
            //{
            //    i++;
            //    if (guess > ranNum)
            //    {
            //        Console.WriteLine("猜大了.");
            //    }
            //    else if (guess < ranNum)
            //    {
            //        Console.WriteLine("猜小了.");
            //    }
            //    Console.WriteLine("再猜1次吧.");
            //    guess = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("恭喜你,猜对了..你猜了:" + i + "次");



            //要求用户反复不停的输入用户名 直到正确为值. "admin" 
            //Console.WriteLine("请输入用户名:");
            //string userName = Console.ReadLine();
            ////"xx"
            //while (userName != "admin") //"admin"
            //{
            //    Console.WriteLine("请输入用户名:");
            //    userName = Console.ReadLine();
            //}




            //int i = 0;//用来记录循环的次数. 
            //while (i <= 5)
            //{
            //    Console.WriteLine("我爱你");
            //    i++;
            //}







            Console.ReadKey();
        }
    }
}
