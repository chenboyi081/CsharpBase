using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C05占位符
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 1.在Console.WriteLine()的时候拼接字符串的另外的方式.
             *   占位符.
             *   现在字符串中使用大括弧占位,并在大括弧中为它编号. 一般情况下编号从0开始,依次的递增.
             *   在字符串的后面,按照顺序的写上要填到坑中的数据.
             *   填坑的规律: 第0个变量会去填编号为0的坑. 第1个变量会去填编号为1的坑. 第n个变量会去填编号为n的坑
             *   
             * 
             * 
             * 2. 坑的编号其实你可以随便取的.反正后面的第n个变量填编号为n的坑.
             *    要求后面的变量的个数 要是 最大坑的编号+1 个.
             *    
             * 
             */

            string name = "jack";
            byte age = 12;
            char gender = '男';

            Console.WriteLine("大家好,我叫" + name + ",我的年龄是" + age + ",我的性别是" + gender);

            Console.WriteLine("大家好,我叫{0},我的年龄是{0},我的性别是{0}", name, age, gender);




            Console.ReadKey();




        }
    }
}
