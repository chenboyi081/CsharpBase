using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03数组的常用算法
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 求整型数组中的最大值、最小值、累加和、平均值.
             * 
             * 2. 判断数组中是否包含指定的元素.
             * 
             * 3. 查找数据在数组中的下标.
             * 
             * 
             * 4. 排序:
             *    a. 选择排序.
             *       选定1个下标的数据和后面的所有的元素进行比较.
             *    b. 冒泡排序.
             *       两两比较.  
             *     Array.Sort(数组的名称)  就会将该数组从小到大的排序.
             *     
             *    
             * 5. 数组的翻转
             *    Array.Reverse(数组的名称)  就会将数组就翻转.
             *    
             * 5. 查找元素的下标.
             *    int index =  Array.IndexOf(数组名,要查找的数据); 从头到尾的遍历.
             *     
             *    折半查找的首要前提是:数组必须是1个有序的数组.
             *    Array.BinarySearch(数组的名称,要查找的数据); 使用二分查找法在1个有序的数组中查找指定元素的下标.
             *    如果没有找到 返回1个负数.
             *    同样的使用这个方法也是要1个有序的数组.
             *    
             * 
             * 
             *    
             * 
             */


            int[] arr = { 13, 14, 56, 11, 90, 18, 40, 156, 78, 90, 100, 145, 200 };
            int index = Array.BinarySearch(arr, 56);
            if (index < 0)
            {
                Console.WriteLine("没有找到...");
            }
            else
            {
                Console.WriteLine(index);
            }


            //int index =  Array.IndexOf(arr, 145);



            //int[] arr = new int[] { 34, 45, 12, 10, 30, 105, 56, 78, 123 };
            //Array.Sort(arr);



            //int key = 41;
            //int min = 0;
            //int max = arr.Length - 1;
            //int mid = (min + max) / 2;
            //while (key != arr[mid])
            //{
            //    if (key > arr[mid])
            //    {
            //        min = mid + 1;
            //    }
            //    else
            //    {
            //        max = mid - 1;
            //    }
            //    if (max < min)
            //    {
            //        Console.WriteLine("没有找到.....");
            //        break;
            //    }
            //    mid = (min + max) / 2;
            //}
            // Console.WriteLine(mid);


            //100的下标.
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == 100)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}




            //string[] arr = { "我", "爱", "北", "京", "天", "安", "门", "!", "哈" };





            //string[] arr = { "我", "爱", "北", "京", "天", "安", "门", "!", "哈" };
            //Array.Reverse(arr); 
            //for (int i = 0; i < arr.Length / 2; i++)
            //{
            //    string temp = arr[i];
            //    arr[i] = arr[arr.Length - 1 - i];
            //    arr[arr.Length - 1 - i] = temp;
            //} 


            //Console.ReadKey();

            //int[] arr = new int[] { 10, 30, 105, 56, 78, 123 };
            //Array.Sort(arr);
            //Array.Reverse(arr);
            ////Console.ReadKey();




            #region 冒泡排序
            //int[] arr = { 30, 40, 50, 60, 12, 45, 6, 7 };
            //for (int i = 0; i < arr.length - 1; i++)//外层循环 控制比较的轮数.
            //{
            //    for (int j = 0; j < arr.length - 1 - i; j++)
            //    {
            //        //arr[j]  arr[j+1]
            //        if (arr[j] < arr[j + 1])
            //        {
            //            int temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }
            //    }
            //}
            #endregion

            Console.ReadKey();

        }
    }
}
