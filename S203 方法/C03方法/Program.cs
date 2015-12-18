using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03方法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 812, 12 }; 
            GetMax(arr); 

            Console.ReadKey();
        }

        //写1个方法,这个方法可以求出1个整型数组中的最大值.
        public static void GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }








        public static void PanDuanSuShu(int num)
        {
            //判断1个数 是不是1个素数
            //int num  2   num-1
            bool flag = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("不是素数");
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine("是1个素数.");
            }


        }

    }
}
