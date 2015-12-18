using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C05值传递和引用传递
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12;
            TestInt(num);
            Console.WriteLine(num);


            int[] arr = new int[3] { 10, 10, 10 };
            TestArray(arr); 

            Console.ReadKey();
        }

        public static void TestArray(int[] newArr)
        {
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = 100;
            }
        }


        public static void TestInt(int num)
        {
            num++;
        }


    }
}
