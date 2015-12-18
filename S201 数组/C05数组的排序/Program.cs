using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C05数组的排序
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 排序算法:
             *  
             * 
             * 
             */

            int[] arr = { 31, 34, 56, 12, 78, 10 }; 
            for (int i = 0; i < arr.Length - 1; i++)//循环1次 就代表比较1轮.
            {
                //i+1 到最后1个 元素遍历出来.
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        arr[i] = arr[i] + arr[j];
                        arr[j] = arr[i] - arr[j];
                        arr[i] = arr[i] - arr[j];
                    }
                }
            }
            Console.ReadKey();



            Console.ReadKey();

        }
    }
}
