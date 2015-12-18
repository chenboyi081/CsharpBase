using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C05逻辑运算符与逻辑表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 比较表达式：只能判断1个条件是否成立.
             * 
             * 2. 逻辑运算符.
             *    a. 用来判断多个比较表达式的,并且使用逻辑运算符来指定这多个比较表达式之间的关系.
             *    
             *    && 逻辑与 并且.
             *    || 逻辑或 或者.
             *    !  非. 取反.
             *   
             * 3. 逻辑表达式:
             *    a.使用逻辑运算符连接起来的式子.
             *    b.逻辑运算的两边必须是1个比较表达式.
             * 
             * 4. && 并且.
             *    使用&&连接起来的逻辑表达式,只有两边的比较表达式的结果都为true的情况下,整个逻辑表达式的结果才为true。
             *    只要有任意的1边的比较表达式的结果为false,那么整个逻辑表达式的结果就为false。
             * 
             *    true && ture  true
             *    flase && true false
             *    true && false flase
             *    false && flase flase
             *     
             *    如果左边的表达式的结果为false。那么这个时候就可以确定整个逻辑表达式的结果为false了.
             *    右边的比较表达式根本不会去运算了.
             * 
             * 5. || 逻辑或. 或者.
             *    使用||连接起来的逻辑表达式,只要有1边的比较表达式的结果为true,那么整个逻辑表达式的结果就为true。
             *    只有两边的比较表达式都为false的情况下,逻辑表达式的结果才为false。
             *    
             *   true || true true 
             *   flase || true true
             *   true||false true
             *   flase||false false
             *   
             *   如果左边的表达式的结果为true，那么此时就可以确定整个逻辑表达式的结果为true了.
             *   右边的表达式根本不会去计算了.
             * 
             *   
             * 6. ! 非 取反.
             *    a. 取反只能取bool类型的反. 
             *    
             *    !false   true
             *    !true    flase
             *   
             *    
             * 7. 逻辑运算符的优先级.
             *    not and or 
             *    ！  &&  || 由高到低.
             *    使用小括弧来改变优先级.
             * 
             * 
             */


            //让用户输入张三的语文和数学成绩,输出以下判断是否正确,正确输出True,错误输出False
            //1)张三的语文和数学成绩都大于90分
            //2)语文和数学有一门是大于90分的

            //Console.WriteLine("请输入语文成绩:");
            //string strYuWen = Console.ReadLine();
            //int yuWen = int.Parse(strYuWen);//91


            //Console.WriteLine("请输入数学成绩:");
            //string strShuXue = Console.ReadLine();
            //int shuXue = int.Parse(strShuXue);//98


            //bool b1 = yuWen > 90 && shuXue > 90;
            //bool b2 = yuWen > 90 || shuXue > 90; 

            //Console.WriteLine(b1+":"+b2);




            //写下判断润年的表达式,设待判断的年份变量为year.
            //   润年的判定(符合下面两个条件之一):
            //让用户年份能够被400整除.
            //年份能够被4整除但不能被100整除.
            // 输入一个年份,如果是润年,则输出true 如果不是,则输出false

            int year = 2010; 
            bool b = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
            Console.WriteLine(b); 

            //int i = 12;
            //int j = 20;
            //int k = 30; 
            //bool b = (i > 10 || j >= 210) && k > 13; 
            //Console.WriteLine(b);


            //int i = 12;
            //int j = 20; 
            //bool b =  i > 10 && !(j > 30);
            //Console.WriteLine(b);



            //int i = 12;
            //bool b = !(i > 10); 
            //Console.WriteLine(b);

            //bool b = false;
            //Console.WriteLine(!b);



            //int i = 1;
            //bool b = i++ > 0 || ++i > 10;
            //Console.WriteLine(i);

            //int num1 = 12;
            //int num2 = 10;


            //bool b = num1 > 100 || num2 > 100;
            //Console.WriteLine(b);



            //白 富 美.



            //int i = 1;
            //bool b =  i++ > 0 && ++i > 10;
            //Console.WriteLine(i);


            //int num1 = 12;
            //int num2 = 10;

            //bool b = num1 > 10 && num2 > 15;
            //Console.WriteLine(b);







            Console.ReadKey();
        }
    }
}
