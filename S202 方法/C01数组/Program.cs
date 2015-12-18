using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C01数组
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 数组的作用: 可以存储多个数据.
             *    数组的存储数据的特点:
             *    a. 存储多个数据
             *    b. 存储的多个数据的类型要相同.
             *    c. 数组能够存储的数据的个数要固定.
             *    
             * 2. 创建数组的语法:
             *    元素的类型[] 数组的名称 = new 元素的类型[数组的长度];
             *    int[] arr = new int[3];
             *    int[]是1个数据类型, 读作int数组. int是int int[]是int[]   int与int[]是不兼容的.
             *    arr是1个变量.
             *    new int[3] 是1个表达式,new是1个运算符. 这个表达式的结果通过赋值符号赋值给数组变量.
             *    
             *    数组在内存中开辟空间:
             *    a. 在内存中声明1个数组变量.
             *    b. 将这个数组变量划分成指定的等分(划分为多少个 是根据创建数组的时候指定数组的长度来决定的,)
             *    c. 这些小的空间的类型 是由创建数组的时候new的时候决定的.
             *    int[] arr = new int[3];
             *    
             *    元素:
             *    下标(索引)
             *    数组的长度:
             *    
             *    注意:
             *    a. 创建数组的时候.赋值符号左右两边的元素的类型要一致.
             *    b. 必须指定数组的长度.
             *    c. 数组的长度可以为0
             *    d. 所有的数据类型都有对应的数组.
             *    
             *    
             * 3.为数组的元素赋值.
             *    a. 确定要为数组的那1个元素赋值. 每1个元素使用下标区分.
             *       数组的名称[元素的下标]=值.
             *       这样就可以将值赋值给指定的下标的元素.
             *    b. 为元素赋值的时候,值的类型必须要与元素的类型一致.
             *    c. 数组的元素 本质上来 其实就是1个普通类型的变量.
             *       所以,虽然数组是可以存储多个数据的,但是数组的元素仍然只能存储1个值.
             *    d. 下标不能越界.
             *    
             * 
             * 4. 取出元素的值.
             *    在需要使用元素的值的地方.
             *    直接 数组的名称[元素的下标]
             *    下标不能越界.
             *    
             * 
             * 5. 遍历数组中的元素
             *    a. 数组名.Length 属性可以得到数组的长度
             *    
             *    使用for循环遍历: 将0到数组的长度-1中的每1个整数遍历出来 当做数组的下标
             *    for(int i=0;i<arr.Length;i++)
             *    {
             *       arr[i]就是遍历出来的每1个元素的值.
             *    }
             *    
             *    foreach遍历数组.             
            *     foreach(声明1个迭代变量 in 数组的名称)
                  {
                     循环体;
                  }
             *    执行步骤:
             *    将数组中的元素的值从第0个到最后1个 挨个依次的赋值给迭代变量 完毕以后自动结束.
             *    注意:
             *    a. 迭代变量的类型要和数组中的元素的类型一致.
             *    b. 迭代变量的名称是可以随意定义的.
             *    c. in是固定的.后面写上要遍历的数组的名称
             *    
             * 6. for遍历和foreach遍历的区别
             *    a. for遍历出来的i是下标 而foreach遍历出来的迭代变量是元素的值.
             *    b. for可以"挑三拣四" foreach只能"从一而终"
             *    c. for可以改变遍历出来的元素的值. foreach只能取迭代变量的值而不能更改.
             *    d. for可以得到当前遍历出来的元素的其他的元素. foreach只能得到当前遍历出来的元素.
             *    
             *    什么使用for： 当要“挑三拣四” 或者 要改元素的值
             *    什么使用foreach：从头遍历到尾 并不改元素的值.
             * 
             * 7. 元素的默认值.
             *    
             * 
             * 8. 关于数组的常用的几种算法:
             *    a. 最大值 最小值
             *    b. 累加和  平均值
             *    c. 判断数组中是否包含指定的元素
             *    d. 查找指定的值在数组中的下标.
             *    
             * 
             * 
             */


            //1.请编写1个程序,接收1个年份,然后返回这个年份的生肖.提示十二生肖: 4鼠 5牛 6虎 7兔 8龙 9蛇 10马 11羊 0猴 1鸡 2狗 3猪  
            //Console.WriteLine("请输入1个年份:");
            //int year = int.Parse(Console.ReadLine()); 
            //string[] shengXiao = { "猴", "鸡", "狗", "猪", "鼠", "牛", "虎", "兔", "龙", "蛇", "马", "羊" };
            //Console.WriteLine(shengXiao[year%12]);


            //请编写1个程序 求出1个整型数组中的最大值和次大值.
            //int[] arr = new int[] { 10, 30, 45, 12, 56, 78 };
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] < arr[j])
            //        {
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("最大值:{0},次大值:{1}",arr[0],arr[1]);


            //请编写程序，求一列数的规则如下: 1、1、2、3、5、8、13、21、34......  求第30位数是多少.。*****
            //交换两个变量的值   
            //int[] arr = new int[30];
            //arr[0] = 1;
            //arr[1] = 1;
            //for (int i = 2; i < arr.Length; i++)
            //{
            //    arr[i] = arr[i - 1] + arr[i - 2];
            //}
            //Console.WriteLine(arr[29]);




            //4. 编程实现 求1-1000内所有的完数(一个数如果恰好等于它的因子之和，这个数就称为“完数”。如6就是1个完数: 6=1+2+3,因子数就是所有可以整除这个数的数,但是不包括这个数自身.比如15的因子数是 1 3 5)  ***


            //   9           // 10 1 2 5  1
            //for (int i = 1; i <= 1000; i++)
            //{
            //    int sum = 0;
            //    //要判断i是不是1个完数. 要找出i的因子数,然后将所有的因子数的累加和求出来
            //    //如果刚好等于i  就说明i是1个完数.
            //    //12       1 2 3 4 6 
            //    //6        1  2  3 
            //    //把1到i-1中的每1个整数遍历出来. 
            //    for (int j = 1; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            sum += j;
            //        }
            //    }
            //    if (sum == i)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //Console.WriteLine(sum);

            //求18的因子数.
            //将1-17中的每1个整数遍历出来 被18模 如果结果为0 那么这个数就是18的因子数. 
            //Console.WriteLine("请输入1个数:");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num-1; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            //用户输入班级的人数,然后依次输入每个同学的成绩. 输入完毕之后,如果及格率没有达到60%，
            //就为每1个没有及格的成绩加2分,直到及格率达到60%为止. ***



            //Console.WriteLine("请输入班级的人数:");
            //int num = int.Parse(Console.ReadLine());
            //int[] scores = new int[num]; ;
            //int jigeNum = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine("请输入第" + (i + 1) + "个同学的成绩:");
            //    scores[i] = int.Parse(Console.ReadLine());
            //    if (scores[i] >= 60)
            //    {
            //        jigeNum++;
            //    }
            //}
            ////计算及格率:  及格的人数/总人数
            //double rate = jigeNum * 1.0 / num;
            //Console.WriteLine("及格率:" + (rate * 100) + "%");
            ////当及格率小于0.6的时候 就应该进入循环为每1个不及格的成绩加2分.
            //while (rate < 0.6)
            //{
            //    Console.WriteLine("及格率为:" + rate + ",没有到0.6 为每1个不及格的成绩开始加2分.");
            //    //a. 为不及格的成绩加2分
            //    jigeNum = 0;
            //    for (int i = 0; i < scores.Length; i++)
            //    {
            //        if (scores[i] < 60)
            //        {
            //            scores[i] += 2;
            //        }

            //        if (scores[i] >= 60)
            //        {
            //            jigeNum++;
            //        }
            //    }
            //    Console.WriteLine("加分完成:新的成绩为:");
            //    foreach (int i in scores)
            //    {
            //        Console.Write(i + "\t");
            //    }
            //    //b.求新的及格率.
            //    rate = jigeNum * 1.0 / num;
            //}
            //Console.WriteLine("及格率:"+rate);











            //char[] c = new char[3];
            //Console.WriteLine(c[0]); 
            //int[] arr = new int[3]; 
            //arr[0] = 12;
            //arr[1] = 11;
            //arr[2] = 10; 
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}




            // 6. 编一个程序，定义数组，用for循环语句，顺序输入10个实数，然后逆序输出这10个数。

            //int[] arr = new int[10];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("请输入第{0}个数:",i+1);
            //    arr[i] = int.Parse(Console.ReadLine());  
            //}


            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}




            //声明1个长度为100的int类型数组. 要求给数组中的元素赋随机值（1-100）不能重复.
            //Contains方法可以判断数组中是否包含指定的元素
            //int[] arr = new int[100];
            //Random r = new Random(); 
            //for (int i = 0; i < arr.Length;)
            //{
            //    //先产生1个随机数 看这个随机数是否在数组中存在.  
            //    //如果不存在 我才将其赋值进去.
            //    int num =  r.Next(1, 101);
            //    if(arr.Contains(num)==false)
            //    {
            //        arr[i] = num;
            //        i++;
            //    } 
            //} 
            //foreach (int i in arr)
            //{
            //    Console.Write(i+"    ");
            //}




                Console.ReadKey();
        }
    }
}




