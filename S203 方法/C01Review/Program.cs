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
            //写1个程序,由用户输入班级的人数,然后输入每个人的成绩. 如果输入的成绩不是整数或者不在0-100的范围之内 要求重新输入.
            //输入完毕以后 求总成绩和平均成绩
            //再去掉1个最高分 去掉1个最低分的平均成绩.
            //将成绩从高到第的打印出来.

            Console.WriteLine("请输入班级的人数:");
            int num = int.Parse(Console.ReadLine());
            //声明1个数组 长度为num 用来存储班级每个同学的成绩.
            int[] score = new int[num];
            //使用for循环来 接收每个同学的成绩 并存储到数组中.
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("请输入第{0}个人的成绩:", i + 1);
                //先接收用户输入同学的成绩
                while (true)
                {
                    try
                    {
                        int chengJi = int.Parse(Console.ReadLine());
                        //如果没有发生异常.就说明输入的是1个整数.
                        if (chengJi < 0 || chengJi > 100)
                        {
                            Console.WriteLine("成绩必须是0-100的整数.请重新输入:");
                        }
                        else
                        {
                            //否则说明用户输入的是1个整数 并且在0-100的范围之内.
                            //我们就将成绩存入到数组中 并接收while循环.
                            score[i] = chengJi;
                            break;
                        }

                    }
                    catch
                    {
                        Console.WriteLine("成绩只能为整数,请重新输入:");
                    }
                }

            }
            //求总成绩和平均成绩.
            int totalScore = 0;
            foreach (int item in score)
            {
                totalScore += item;
            }
            double avg = totalScore * 1.0 / num;
            Console.WriteLine("总成绩为:" + totalScore + ",平均成绩为:" + avg);
            //将成绩排序:
            for (int i = 0; i < score.Length - 1; i++)
            {
                for (int j = 0; j < score.Length - 1 - i; j++)
                {
                    if (score[j] < score[j + 1])
                    {
                        int temp = score[j];
                        score[j] = score[j + 1];
                        score[j + 1] = temp;
                    }
                }
            }
            //去掉1个最高分和最低分的平均成绩.
            double pingJun = (totalScore - score[0] - score[score.Length - 1]) / (score.Length - 2);
            Console.WriteLine("去掉最高分{0},和最低分{1}的平均成绩{2}",score[0],score[score.Length-1],pingJun);
            Console.WriteLine("成绩由高到低:");
            //将成绩由高到低的打印.
            foreach (int item in score)
            {
                Console.WriteLine(item);
            }






            Console.ReadKey();
        }
    }
}
