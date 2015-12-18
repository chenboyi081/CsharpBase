using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C07For循环
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. for循环:仍然是循环.仍然是将1段代码进入反复不停的执行.
             *    
             * 2. 语法:
             *    for(初始化表达式;bool表达式;循环后操作表达式)
             *    {
             *        循环体;
             *    }
             *    
             * 3. 执行步骤
             *    1. 执行初始化表达式.
             *    2. 计算bool表达式的结果.
             *       2.1  如果结果为true。就执行循环体.
             *            循环体执行完毕以后,再执行循环后操作表达式.
             *            再跳回第2步继续执行.
             *       2.2  如果结果为flase，就结束for循环,继续往下执行.
             *            
             * 4. for循环和while循环比较
             *    a. 执行的步骤与原理都是一样的,
             *    b. 唯一的区别就是语法不同.
             *    
             * 5. for循环的三个表达式其实是可以省略的.分号是不能省略.
             *    如果第2个表达式(bool表达式)不写 那么默认就是true。
             *    
             *    
             * 6. 第3个表达式不是说一定是i++ i--.  只要是个表达式都可以写在那.
             *    反正循环体执行完毕后 就去执行第3个表达式.
             *    
             *    第2个表达式要么不写. 不写默认就是true。
             *    要写的话 必须是1个bool表达式.
             *    
             *    第1个表达式不是说非要声明1个循环增量.
             *    只要是1个C#语句都可以.
             *    特别要强调的是 初始化表达式 只执行1次.
             *    
             *    
             *    正常情况下:
             *     初始化表达式中声明1个循环增量.
             *     循环后操作表达式中我们改变循环增量的值.
             * 
             * 
             * 7. 循环次数确定的循环, 使用for循环.
             *    循环次数不确定的循环, 使用while循环.
             * 
             */

             


            //找出100-999间的水仙花数?
            //for (int i = 100; i <= 999; i++)
            //{
            //    int bai = i / 100;
            //    int shi = i % 100 / 10;
            //    int ge = i % 10;
            //    if (bai * bai * bai + shi * shi * shi + ge * ge * ge == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //} 
            //double res =  Math.Pow(5,3);
            //Console.WriteLine(res);









            //求1-100间的所有偶数和?
            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i; 
            //    }
            //}
            //Console.WriteLine(sum);




            //for (Console.WriteLine("A"); true; Console.WriteLine("C"))
            //{
            //    Console.WriteLine("D");
            //}


            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i); 
            //}





            //请将10-1中的每1个整数遍历出来.
            //int i = 10;
            //while (i >= 1)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //Console.WriteLine("******************");
            //for (int j = 10; j >= 1; j--)
            //{
            //    Console.WriteLine(j);
            //}



            //1.循环的次数确定的循环
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("我爱你,北京!");
            //} 
            //Console.WriteLine("*********************************");


            //2. 循环的次数不确定 但是结束的条件是确定的.
            //for (  ;   ;    )
            //{
            //    Console.WriteLine("请输入用户名");
            //    string userName = Console.ReadLine();
            //    if (userName == "admin")
            //    {
            //        break;
            //    }
            //}

            //3.遍历
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //4. 求指定范围中符合特定条件的数
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //5.求最大值和最小值.
            //int max = int.MinValue;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("请输入1个数:");
            //    int num = int.Parse(Console.ReadLine());
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //}
            //Console.WriteLine(max);


            //6.求累加和.
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);


            //7.穷举.
            //for (int i = 2; true; i++)
            //{
            //    if (i % 2 == 1 && i % 3 == 1 && i % 4 == 1)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}

            //8.计数
            //int j = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 6 == 0)
            //    {
            //        j++;
            //    }
            //}

            //Console.WriteLine(j);

            //int j = 0;
            //while (j < 5)
            //{
            //    Console.WriteLine("我爱你,广州");
            //    j++;
            //}



            Console.ReadKey();
        }
    }
}
