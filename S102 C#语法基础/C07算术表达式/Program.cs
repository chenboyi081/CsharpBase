using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C07算术表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 算术运算符
             *    +  -  *   /   %
             *    
             * 2. 算术表达式.
             *    由算术运算符连接起来的式子.
             *    
             *    我们不能光秃秃的写1个表达式, 因为表达式是有结果的,我们必须要处理这个结果.
             *    a. 直接将表达式的结果打印.
             *    b. 将表达式的结果通过赋值符号存储在1个变量中.
             * 
             * 
             * 3. +号. 代表求和运算.
             *    当加号两边的数据类型都是数值类型的时候,那么这个时候+号代表算术求和运算 结果就是数学意义上的和.
             *    当加号任意1边的数据类型是字符串的时候,那么+号代表字符串的连接, 会把两边的数据连接起来组成1个新的字符串.
             *    
             *    算术表达式的结果的类型:
             *    a. byte short int 互相之间参与算术表达式 那么结果就是int类型的.
             *    b. 其他的情况:
             *       如果参与算术表达式的数据的类型是一致的,那么表达式的结果的类型就是这个类型.
             *       如果参与算术表达式的数据的类型不一致,那么表达式的结果的类型是范围最大的那个类型.
             *       
             *    c. 关于范围
             *       整型之间： long>int>short>byte
             *       浮点型: double>float>decimal 
             *       浮点型数据的范围总是比整型的范围大.
             *    
             *    d(了解) uint与ushort=>uint
             *            ushort与ushort=>int
             *            uint与sbyte==>long
             * 
             * 4. -号:  代表数学意义上的求差运算.
             * 5. *号:  代表数学意义上的求积运算
             * 6. /号:  代表数学意义上的求商运算.
             *          需要注意的是 10/4 的结果是2    
             *          因为10和4都是int类型的,所以结果也是int类型的.
             *          
             *          如果需要保留小数部分.
             *          a. 任意的1个数据的类型改为double
             *          b. *1.0 让其类型变为double
             * 
             *    
             * 7. %号: 模  求模运算  求余数.
             *      10%3 结果是10除以3的余数.
             *    
             *  
             * 8. 参与算术表达式的数据只能是数值类型的.还可以是char类型的.
             *    字符串不能参与算术运算.
             *    
             *    当char类型的数据参与算术运算的时候,首先会将这个char类型的数据转换为其所对应的ASCII码 然后再参与运算.
             *    每1个字符都有1个对应的int类型的整数. 这个对应的整数就叫做这个字符的ASCII码
             *    'a'   97
             *    'A'   65
             *    
             * 9. 算术运算的优先级.
             *    先乘除 后加减.
             *    如果同级别 从左到右 依次计算. 
             *    
             *    使用小括弧改变优先级.有小括弧的先算小括弧中的.
             *    小括弧是可以无限制的套用的,但是一定要成对的出现.
             *    
             * 10. decimal类型的数据不能和其他的浮点型数据参与算术运算.因为会丢失精度.
             *     但是decimal类型的数据是可以和其他的整型的数据参与运算的,因为不会丢失精度.
             *     
             *  
             *   
             */

            //练习1：定义两个数分别为10和20，打印出两个数的和
            //int num1 = 10, num2 = 20;
            //int he = num1 + num2;
            //Console.WriteLine(he);


            //计算半径为5的圆的面积并打印出来
            //double r = 12.5; 
            //double area =  3.14 * r * r; 
            //Console.WriteLine("面积为:"+area);



            //某商店T恤的价格为35元/件,裤子的价格为120元/条.小明在该店买了3件T恤和2条裤子,请计算并显示小明应该付多少钱?
            double tshirtPrice = 35.0;
            double kuziPrice = 120.0; 
            double price =  tshirtPrice * 3 + kuziPrice * 2; 
            Console.WriteLine("小明应该付:"+price); 
            //假如商店为小明打8.8折,那么小明应该付多少钱呢?
            //购物总计为:XX元,打折后应付为:XX元. 
            double realPrice = price * 0.88;
            Console.WriteLine("打折后的价格:"+realPrice);






            //定义三个变量 用来存储小思的 语数外成绩 求总分和平均分.
            //double _Chinese = 90;
            //double math = 100;
            //double _English = 99; 
            //double totoalScore = _Chinese + math + _English; 
            //double avg =  totoalScore / 3; 
            //Console.WriteLine("总成绩:{0},平均成绩:{1}",totoalScore,avg); 
            ////Console.WriteLine(float.MaxValue);
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(decimal.MaxValue);


            //decimal d1 = 12.123m;
            //int i1 = 12;

            //decimal res = d1 + i1;

            //Console.WriteLine(res);


            //double d1 = 12.45;
            //decimal d2 = 12.45678m;


            //decimal d3 = d1 + d2;


            //Console.WriteLine(d3);
            //int res = (3 + (2 - 5) * 5) * 2; 
            //Console.WriteLine(3 + 2 - 5 * 2);


            //char c = '中';
            //int res =   c + 1;


            //Console.WriteLine(res);


            //string s1 = "中国";
            //string s2 = "日本";

            //int i1 = 12;
            //int i2 = 11;  
            //int res = i1 * i2; 
            //Console.WriteLine(res);

            //int i1 = 10;
            //int i2 = 3;

            //int res =  i1 % i2;


            // Console.WriteLine(res);



            //int i1 = 10;
            //int i2 = 4;
            //Console.WriteLine(i1 / i2);

            //int res = i1 / i2;
            //Console.WriteLine(res);





            //int i1 = 12;
            //double d1 = 2.5;
            //double res =  i1* d1;
            //Console.WriteLine(res);



            //int i1 = 12;
            //int i2 = 2;
            //int res =  i1* i2;
            //Console.WriteLine(res);




            //double d2 = 10.6;
            //int i1 = 10;
            //double res =  d2 - i1;
            //Console.WriteLine(res);



            //double d1 = 10.5;
            //double d2 = 0.4;
            //double d3 =  d1 - d2;
            //Console.WriteLine(d3);





            //int i1 = 2100000000;
            //int i2 = 2100000000;
            //int i3 = i1 + i2;
            //Console.WriteLine(i3);

            //uint i = 12;
            //ushort s = 12;
            //uint res = i + s;


            //ushort s1 = 12;
            //ushort s2 = 11;
            //int s3 =  s1 + s2;


            //uint i1 = 12;
            //sbyte s1 = 12;
            //long  res =  i1 + s1;


            //int i1 = 12;
            //decimal d1 = 12.12m;
            //decimal res =  i1 + d1;
            //Console.WriteLine(res);



            //int i1 = 12;
            //float f1 = 12.12f; 
            //float f2 =  i1 + f1;
            //Console.WriteLine(f2);


            //int i1 = 12;
            //double d1 = 12.12; 
            //double d2 =  i1 + d1; 
            //Console.WriteLine(d2);

            //long l1 = 110;
            //int i1 = 200; 
            //long res =  l1 + i1;
            //Console.WriteLine(res);



            //long l1 = 12;
            //long l2 = 13;

            //long l3 =  l1 + l2;
            //Console.WriteLine(l3);


            //float f1 = 12.11f;
            //float f2 = 12.11f;

            //float f3 = f1 + f2;
            //Console.WriteLine(f3);


            //decimal d1 = 12.12m;
            //decimal d2 = 11.11m;

            //decimal d3 =  d1 + d2;
            //Console.WriteLine(d3);


            //double d1 = 12.12;
            //double d2 = 34.56; 
            //double d3 = d1 + d2;
            //Console.WriteLine(d3);


            //short s1 = 32767;
            //short s2 = 10;

            //int s = s1 + s2;


            //short s1 = 12;
            //short s2 = 190;
            //short s3 = s1 + s2;


            //byte b1 = 12;
            //int i1 = 11;
            //int i2 = b1 + i1;


            //int num1 = 12;
            //int num2 = 20;

            //int res = num1 + num2;


            //int res =  1 + 1;

            //Console.WriteLine(res);


            Console.ReadKey();
        }
    }
}
