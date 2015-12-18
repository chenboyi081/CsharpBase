using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C06IF结构
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 无论是比较表达式还是逻辑表达式他们只是得到这个条件是否成立的1个结果.
             *    判断1个条件是否成立,得到结果以后.我们还得根据这个结果做出不同的反应.
             * 
             * 2. 需求:
             *    有1段代码,只有在满足某个条件的时候才会去执行,如果不满足就不执行.
             *    
             * 3. if结构.
             *    a. 语法:
             *    if(bool表达式)
             *    {
             *        执行代码.
             *    }
             *    bool表达式: 表达式的结果如果是1个bool类型的,那么这个表达式就是1个bool表达式.
             *    b. 执行步骤:
             *       首先计算bool表达式的结果.如果结果为true，就执行if大括弧中的代码. 然后继续往下执行.
             *                              如果是false，那么就跳过if块中的代码,往下执行.
             *  
             * 4. 什么时候使用if结构?
             *    有1段代码,只有在满足某个条件的时候才会去执行,如果不满足就不执行.
             *    if(执行的条件)
             *    {
             *        满足条件要执行的代码.
             *    }
             *    
             * 5. 注意的地方.
             *    a. if结构的小括弧后面没有分号.
             *       一句代码的后面有1个分号.
             *       1个块如果有大括弧的结构 是没有分号的.
             *       
             *    b. if后面的小括弧中,一定要是1个bool表达式.
             *    c. if结构中. 可以有任意行的代码 只要是符合我们逻辑的代码. 都可以写在其中.
             *       反正条件成立就执行.
             *       
             * 
             * 
             */

            //请用户输入1个数据,如果输入的是1个正数. 那么就让用户再输入一个数,否则就算了.

            Console.WriteLine("请输入1个数据:"); 
            int num = Convert.ToInt32(Console.ReadLine()); 
            if (num > 0)
            {
                Console.WriteLine("亲,请再输入1个数:");
                int num1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("OVER");





            //从键盘上输入一个数,如果这个值在区间[0,100]里，则加上1000，否则不加。最后输出结果。

            //Console.WriteLine("请输入1个数:");
            ////string str = Console.ReadLine();
            ////int num = int.Parse(str); 
            //int num = int.Parse(Console.ReadLine());

            //if (num >= 0 && num <= 100)
            //{
            //    Console.WriteLine("Aaaaa");
            //    num = num + 1000;
            //    Console.WriteLine("bbbbbbbbbb");
            //    Console.WriteLine("ccccccccccccccccccccc");
            //}
            //Console.WriteLine(num);




            //从控制台接收用户输入 土豪儿子的 成绩,如果及格 就奖励,否则就算了.
            //Console.WriteLine("请输入土豪儿子的成绩:");
            //int score = int.Parse(Console.ReadLine());
            //if (score >= 60)
            //{
            //    Console.WriteLine("奖励你....");
            //}
            //Console.WriteLine("OVER");



            //思发 钱包里的钱 有没有100块.
            //int sfMoney = 15;
            //bool b =  sfMoney > 100; 
            //if (b == true)
            //{
            //    Console.WriteLine("走,请吃饭...");
            //} 
            //Console.WriteLine("OVER");





            Console.ReadKey();
        }
    }
}
