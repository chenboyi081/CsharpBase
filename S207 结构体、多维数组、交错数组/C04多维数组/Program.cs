using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C04多维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 二维数组: 它表示1个表格数据. 有行有列.
             *    与数组的特点一样: 所有的数据的类型相同. 存储的个数固定.
             * 2. 创建1个二维数组呢? 二维数组的特点在于有行有列.
             *    元素的类型[,] 数组的名称 = new 元素的类型[行数,列数];
             *    
             *    表示声明了1个指定行数,每1行有指定列数的1个表结构.
             *    二维数组的元素的个数: 行数*列数
             *    
             * 3. 为二维数组中的元素赋值.
             *    二维数组中的元素必须通过行列两个坐标来确定.确定这个元素在第几行的第几列.
             *    二维数组中的行列坐标从0开始.
             *    
             *    在索引器中写上行坐标和列坐标就可以定位到指定的元素.
             *    arr[行坐标,列坐标]=值;
             *    
             * 4. 取值:
             *    仍然通过行列坐标去取值.
             *    
             *    
             * 5. 一维数组表示1条线. 确定线上的1点只要1个坐标.
             *    二维表示表示1个面. 确定面上的1点要2个坐标.
             *    
             * 6. 数组的Rank属性 可以得到数组的维度.
             * 
             * 7. 遍历:
             *    Length属性代表数组中元素的个数,而 二维数组中的Length指的是行*列
             *    a. 使用foreach可以简单快速的遍历.
             *       foreach(int item in arr)
             *       {
             *           cw(item);
             *       }
             *    b. 数组的GetLength()方法可以得到指定维度的长度.
             *       传入0 可以得到行数,
             *       传入1 可以得到列数
             *       for(int i=0;i<arr.GetLength(0);i++)
             *       {
             *          for(int j =0;j<arr.GetLength(1);j++)
             *          {
             *               arr[i,j];
             *          }
             *       }
             * 
             * 
             * 8. 当我有1个表格数据的时候.
             *    这些数据有行有列的存储.  我们就可以使用二维数组.
             *    
             * 9. 使用数组初始化器初始化二维数组中的每1个元素,
             *    int[,] arr = { { 10, 20, 30 }, { 40, 50, 60 }, { 60, 70,80} };
             *
             * 
             * 
             * 10.三维数组.
             *    
             */


            int[, ,] arr = new int[3, 5, 4];
            Console.WriteLine(arr.Length); 
            arr[0, 0, 0] = 12;
            arr[2, 4, 3] = 19;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.WriteLine(arr[i,j,k]);
                    }
                }
            }


            //int[] newArr = new int[3];
            //Console.WriteLine(newArr.Rank);
            //声明1个变量  公司有4个销售小组,每组3人. 将每个人的销售成绩保存起来. 
            //int[,] arr = new int[14, 6];
            //arr[0, 0] = 12;
            //arr[2, 2] = 22;


            //int[,] arr = { { 10, 20, 30 }, { 40, 50, 60 }, { 60, 70, 80 } };


            ////Console.WriteLine(arr.GetLength(2));

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            Console.ReadKey();
        }
    }
}
