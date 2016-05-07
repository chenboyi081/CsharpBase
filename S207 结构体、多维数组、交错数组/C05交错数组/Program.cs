using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C05交错数组
{

    class Program
    {
        static void Main(string[] args)
        {

            /* 1. 在类中只能定义字段、属性、方法、构造函数.
             *    语法上允许在定义字段的同时为字段赋值.
             * 
             * 
             * 2. 交错数组的本质是1个一维数组,只不过这个1维数组的元素的类型是1个数组. 
             *    元素的类型[][] 数组的名称 = new 元素的类型[交错数组的长度][]
             *    在声明交错数组的时候,只需要指定1维数组的长度。
             *    
             * 3. 赋值.
             *    给交错数组的元素赋值,一定要是1个数组,因为交错数组的元素是1个数组类型的
             *    
             *    为交错数组的元素的元素赋值
             *    先通过索引器确定交错数组的元素 这个元素的类型是1个数组  再通过1个索引器确定交错数组的元素的元素
             *    arr[0][0]=12;
             *    
             * 
             * 4. 取值:
             *    
             *    
             * 5. 遍历.
             *    使用foreach遍历,因为交错数组的元素的类型是1个数组,所以迭代变量的类型也应该是1个数组.
             *    然后再遍历这个迭代变量.
             *    foreach (int[] item in arr)
             *    {
             *       foreach(int i in item)
             *       {
             *           cw(i);
             *       }
             *    }
             *    使用for循环来遍历交错数组, 
             *    for (int i = 0; i < arr.Length; i++)
             *    {
             *        arr[i]是交错数的元素,这个元素是1个数组 还得遍历这个arr[i]
             *        for(int j=0;j<arr[i].Length;j++)
             *        {
             *            cw(arr[i][j]);
             *        }
             *    }
             * 
             * 
             * 
             * 6. 表示1个表格数据,行确定m,但是每1个行的列数不相同. 这个时候就可以使用交错数组.
             */

            int[][] arr = new int[4][];
            arr[0] = new int[4];
            arr[1] = new int[3];
            arr[2] = new int[5];
            arr[3] = new int[9];

            foreach (int[] item in arr)
            {
                foreach (int i in item)
                {
                    Console.Write(i+"\t");
                }
                Console.WriteLine();
            }





            //int[][] arr = { new int[] { 1, 2, 3, }, new int[] { 4, 5, 667, 8, 9 } };

            //Console.ReadKey();


            //int[][][] arr = new int[3][][];
            //arr[0]= new int[4][];
            //arr[0][0] = new int[4];

            //int[][] arr = new int[3][]; 
            //arr[0] = new int[4];
            //arr[1] = new int[3];
            //arr[2] = new int[2]; 
            //arr[0][0] = 12;
            //arr[1][1] = 100;
            //arr[2][0] = 200;


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j]+"\t");
            //    }
            //    Console.WriteLine();
            //}


            //foreach (int[] item in arr)
            //{
            //    foreach (int i in item)
            //    {
            //        Console.Write(i + "\t");
            //    }
            //    Console.WriteLine();
            //}


            Console.ReadKey();
        }
    }
}
