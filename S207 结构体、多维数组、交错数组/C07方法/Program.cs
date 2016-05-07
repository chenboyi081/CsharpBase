using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C07方法
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. ref关键字.
             *    a.  ref关键字是用来修饰方法的参数的.
             *    b.  在调用的时候. 在为被ref修饰的形参传值的时候, 实参也必须要用ref修饰.
             *    c.  传值的时候, 传递的不是实参变量的值,传递是是实参变量的地址.
             *        这个时候在方法的内部,修改ref形参的值,其实改的是实参变量的值.
             *    d.  所以,实参必须是1个变量,不能是1个常量. 
             *        因为传递的时候,传递的是变量的地址 而不是值.
             * 
             * 
             * 2. 最大的作用是 可以在方法的内部去修改调用者的变量的值.
             * 
             *    
             * ======================================================================
             * 1. ref关键字.
             *    是用来修饰方法的参数的.
             *    调用的时候,实参必须是1个变量,并且实参也要被ref修饰.
             * 
             *    如果不加ref关键字,那么在为形参赋值的时候,是将实参变量中的值赋值给形参. 
             *    将实参变量的值拷贝1份 将副本赋值给形参.
             *    
             *    如果加了ref关键字,那么在传递的时候,传递的不是实参变量的值.而是实参变量的地址.
             *    所以在方法的内部修改ref形参,实际上修改的是调用者的实参变量的值.
             *    
             *    实际上,我们发现ref传递以后,实参ref和形参ref 就是同1个变量.
             *    这个时候 在方法的内部,修改ref形参的值 就是修改实参变量的值 因为本质上他们是同1个变量.
             *    
             * 2. 什么时候用.
             *    ref最大的作用是可以在方法的内部更改调用者的变量的值.
             *    当我们需要向调用者返回多个数据的时候,就可以用它.
             * 
             * 
             * ========================================================================
             * 1. out关键字.
             *    是用来修饰方法的参数的.
             *    调用的时候,实参必须是1个变量,并且实参也要被out修饰.
             *    
             *    如果加了out关键字,那么在传递的时候,传递的不是实参变量的值.而是实参变量的地址.
             *    所以在方法的内部修改out形参,实际上修改的是调用者的实参变量的值.
             * 
             *    实际上,我们发现out传递以后,实参out和形参out 就是同1个变量.
             *    这个时候 在方法的内部,修改out形参的值 就是修改实参变量的值 因为本质上他们是同1个变量.
             * 
             * 2. 什么时候用.
             *    out最大的作用是可以在方法的内部更改调用者的变量的值.
             *    当我们需要向调用者返回多个数据的时候,就可以用它.
             *    
             * 
             * 3. ref与out的区别.
             *    a. ref在方法的内部可以为其赋值,也可以不赋值. out要求在方法结束之前必须要为它赋值.
             *    b. ref实参变量在传递之前,要求必须有初始值,因为在方法的内部有可能会使用它的值.
             *       out实参变量在传递之前,可以没有初始值.以为在方法的内部一定会为它赋值的.
             *       out在方法中 使用之前 必须为其赋值.
             *       
             *    
             *   ref侧重于修改. out侧重于输出.
             * 
             * 4. 如果方法的内部有可能返回多个数据,那么我们就可以使用ref。
             *    如果方法一定会返回多个数据,那么我们就可以使用out。
             *    
             *    但是 ref 是可以用在任意的场合的.
             * 
             * 
             * 5.TryParse(string str,out int result)方法 判断字符串是否能够转换为指定的类型,并将成功转换后的数据赋值给out实参变量
             *    
             *   stirng str = "123";
             *   int num;
             *   bool b = int.TryParse(str,out num)
             *   判断str是否能够转换为int类型,如果能够转换 方法的返回值为true，并且将成功转换后的数据赋值给out实参变量.
             *   直接在out实参变量中取出转换以后的值 。
             *   
             *   如果不能转换.方法的返回值返回false。
             *   
             *   
             * 
             * 
             * 
             */

            Console.WriteLine("请输入1个整型的数:");
            int num;
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("你输入的不是1个整数");
            }
            else
            {
                Console.WriteLine(num+1);
            }




            //int i1 = 19;
            //TestRef(ref i1);
            //Console.WriteLine(i1);

            //bool flag = false;
            //int num = 0;
            //Test(ref flag, ref num);

            //int[] arr = { 10, 20, 30, 40, 506, 70, 1 };
            //int max=0;
            //int min = 0;
            //GetMaxAndMin(arr, ref max, ref min); 

            //int i1 = 0;
            //TestRef(ref i1);
            //Console.WriteLine(i1);


            //int sum = 0;
            //int avg = 0;
            //GetSumAndAvg(ref  sum, ref  avg, 12, 13, 24, 345, 5, 66, 78, 789, 890, 0, 12);
            //Console.WriteLine(sum + ":" + avg);

            //int num = 0;
            //if (MyParse("123a", ref num))
            //{
            //    Console.WriteLine("yes" + num);
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            //int i1 = 9; 
            //TestOut(out i1);


            //int i1;
            //TestRef(ref i1);

            //int i1;
            //TestOut(out i1);
            //Console.WriteLine(i1);

            //int[] arr = { 10, 20, 2304, 305, 4056, 546, 5067, 607 };
            //int max;
            //int min;
            //GetMax(arr,out max,out min);

            //int num;
            //bool b =  int.TryParse("123a", out num);



            Console.ReadKey();
        }

        //写1个方法,这个方法返回1个整型数组中的最大值和最小值.

        public static void GetMax(int[] arr, out int max, out int min)
        {
            max = arr.Max();
            min = arr.Min();
        }




        public static void TestOut(out int num)
        {
            num = 10;
            num++;
        }

        public static void TestRef(ref int num)
        {
            num++;
        }


        //请写1个方法,这个方法判断1个字符串是否能够转换为整型的数. 并返回转换成功以后的整型的数. 
        public static bool MyParse(string str, ref int num)
        {
            try
            {
                num = int.Parse(str);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //请写1个方法,这个方法返回1个整型数组中的累加和 与 平均值.
        public static void GetSumAndAvg(ref  int sum, ref  int avg, params int[] arr)
        {
            sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            avg = sum / arr.Length;
        }








        ////请写1个方法,这个方法返回1个整型数组中的最大值和最小值 
        //public static void GetMaxAndMin(int[] arr, ref int max, ref int min)
        //{
        //    min = arr[0];
        //    max = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //}


        //public static void Test(ref bool flag, ref int num)
        //{
        //    bool b = true;
        //    int i = 12;

        //    flag = b;
        //    num = i;


        //}




        //public static void TestRef(ref int num)
        //{
        //    num++;
        //}






    }
}
