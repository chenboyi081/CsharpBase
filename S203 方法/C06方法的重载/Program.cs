using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C06方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("jack");

            Console.WriteLine(10);

            int[] arr = new int[3];
            Console.WriteLine(arr); 

            Console.WriteLine(false);


            Console.WriteLine(12.12);


 

           
            Console.ReadKey();
        }

        public static void Test(string name)
        {
            Console.WriteLine("哈哈哈,我是带1个参数的方法..");
        } 

        public static void Test()
        {
            Console.WriteLine("哈哈哈,我是test");
        }


    }
}
