using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02值类型与引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.  int[] arr = new int[3] { 10, 20, 30 };
             *     int[] newArr = arr;
             *     这样赋值是可以滴,因为arr和newArr都是同1个类型的变量 是可以相互赋值的.
             *     
             * 
             * 2. 内存中主要分为两块空间.
             *    栈空间:
             *    堆空间:
             *    他们都是用来存储数据的.
             *    不同的数据存储在不同的空间中,方便系统管理数据.
             *    
             * 3. int类型的变量.变量开辟在栈空间中. 这个变量的值存储在这个int类型的变量中.
             *    int[]类型的变量,变量是开辟在栈空间中 真实的数组是在堆空间中的.
             *                   变量中存储的是 真实的数组 在堆空间中的地址.
             *    
             * 4. 变量之间的相互赋值:
             *    无论这个变量是个什么类型的. 都是将源变量中的值拷贝1份.将这个副本赋值给目标变量.
             *    
             * 5. 数组在内存中的创建:
             *    int[] arr = new int[3];
             *    a. arr是1个变量,这个变量开辟在栈空间中.
             *    b. new int[3]是1个表达式,new是1个运算符
             *       这个表达式做的事情
             *       1). 在堆内存中开辟连续的3块int类型的空间.
             *       2). 返回第1个空间在堆空间中的地址.
             *    所以,真实的数组是存储在堆空间中的 数组变量中的存储的仅仅是
             *         真实的数组在堆空间中的地址.
             *         
             * 6. 常见的数据类型
             *    数值类型:  long int short byte decimal double float
             *    非数值类型: char string bool array
             *    划分的依据: 数据的样式.
             *    
             * 
             * 7. 值类型:
             *        所有的数值类型(long int short byte decimal double float ulong uint ushort sbyte)
             *        char
             *        bool  
             *    引用类型:
             *        string 是1个特殊的引用类型.
             *        数组
             *    划分的依据: 他们在内存中存储的结构不同.
             *    
             *    值类型与引用类型:
             *    相同点: 无论是引用类型的变量还是值类型的变量,这个变量都是开辟在栈空间中的.
             *    不同的地方:
             *         值类型的变量的真实的值. 直接存储在该变量中.
             *         引用类型的变量的真实的数据是存储堆空间中的. 变量中存储的是真实的值在堆空间中的地址.
             *         
             *    
             * 8. 变量之间相互赋值的时候.效果就会不同.
             *    a. 在变量之间相互赋值的时候.无论这个变量是个什么类型的. 都是将源变量中的值拷贝1份.将这个副本赋值给目标变量.
             *    b. 值类型的变量在相互赋值的时候.
             *       因为值类型的变量中存储的是事实的值,所以拷贝传递的也是真实的值. 
             *       赋值完成以后 对1个变量进行修改不会影响另外的1个变量的值.
             *       
             *       
             *       
             *    c. 引用类型的变量在相互赋值的时候.
             *       因为引用类型的变量中存储的是真实的值在堆空间中的地址, 所以我们拷贝传递的是 地址.
             *       赋值完成以后,两个变量指向堆空间中的同1个真实数据.
             *       对1个变量进行修改 会影响另外的1个变量的值.
             *    
             * 
             *    
             *    
             *    
             *    
             * 
             */


            string str1 = "jack";
            string str2 = str1;
            str2 = "rose";
            Console.WriteLine(str1);



            //bool b1 = false;
            //bool b2 = b1;
            //b2 = true;
            //Console.WriteLine(b1);


            //Console.ReadKey();


            //int i = 12;
            //int j = i;
            //j = 10;
            //Console.WriteLine(i);

            int[] arr = new int[3] { 10, 20, 30 };
            int[] newArr = arr;
            newArr[0] = 100;
            Console.WriteLine(arr[0]);

            Console.ReadKey();

        }
    }
}
