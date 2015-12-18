using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 类型转换:
             *    a. 我们的变量一旦声明,其类型就无法改变.
             *    b. 类型转换指的是,将1个变量中的值拿出来(有的时候会将这个值经过处理) 把它存储到 另外的1个类型的变量中去
             *       的这样的1个过程.
             *    c. 类型转换完成以后,变量的类型仍然是原来的类型.不会发生变化.
             *    
             * 2. 自动类型转换(隐式类型转换)
             *    在数据类型兼容的情况下,我们可以直接将1个小范围类型的变量的值 赋值给 1个大范围的类型的变量.
             *    a. 数据类型兼容.(数值类型和char类型)
             *    b. 目标类型的范围比源类型大.
             *       关于范围:
             *       1). 浮点型的范围总是比整型的要大.
             *       2). 整型: long>int>short>byte
             *           浮点型: double>float>deciaml
             *    满足这个条件的赋值,是绝对不会出现任何问题的,所以C#帮助我们自动的完成这个转换.
             *    c. char:
             *       可以直接将1个char类型的数据赋值给1个int类型的变量.
             *       这个int类型的变量的值 是这个char数据的 ASCII 码
             *    
             * 3. 强制类型转换.
             *    在数据类型兼容的情况下,我们不能直接将1个大范围变量中的值 赋值给 1个小范围的变量中,
             *    因为有可能会发生溢出的情况. 所以C#不会帮助我们完成这个转换。 
             *    在编译的时候,编译器只会知道变量的类型,无法知道变量中的值.因为变量中的值是在运行的时候才存储进去的.
             *    
             *    如果程序员就是要让我们的C#完成这个赋值, 这个时候我们可以使用强制转换的语法.
             *    强制类型转换的意义:
             *     告诉编译器,你就直接将大范围变量中的值拿出来赋值给小范围的变量吧. 我知道有可能会发生溢出的情况
             *     但是你放心 我负责.
             *     
             *    如果大范围变量中的值 在 小范围变量的类型中. 那么强制转换是不会有问题的.一切ok.
             *    如果超过范围了. 就不是我们想要的结果了.
             *    
             *    将浮点型强制转换为整型: 直接干掉小数部分 保留整数部分.
             *    
             *    char：
             *    将int类型的数据赋值给char类型的变量 需要做强制转换.
             *    结果就是 以int类型的数据为ASCII码 对应的字符.
             *    
             * 4. 自动类型转换和强制类型转换的前提是: 数据类型兼容. 
             *    自动类型转换和强制类型转换 都是把源变量中的值拿出来直接赋值给目标变量 如果超过范围 直接截取.
             *    所以,他们是内存级别的转换.
             *    
             *    
             * 5. Parse转换.
             *    a. 作用: 专门将字符串转换为其他类型的
             *    b. 语法:
             *       想要把字符串转换为什么类型,就   什么类型.Parse(待转换的字符串);
             *       string str= "123";
             *       int num =  int.Parse(str);
             *       声明1个对应的类型的变量 来接收转换成功以后的数据.
             *    c. 细节:
             *       1). 只能将字符串转换为其他的类型.
             *       2). 转换成功的条件:
             *           字符串的字面量是1个指定类型的时候,那么这个时候就可以通过Parse将其转换为这个类型.
             *           否则就会发生运行错误. 
             *    d.Parse转换是1个加工改造的过程.
             * 
             * 
             * 6. Convert转换.
             *    a. 是1个万能的转换.因为它可以做自动类型转换的事情、强制转换的事情、Parse转换的事情、其他的转换.
             *    b. 语法:
             *       要转换为什么类型就
             *       Convert.To什么类型(待转换的数据);
             *       然后声明1个对应的类型的变量来接受这句代码转换成功以后的数据.
             *       
             *       注意的是:
             *       int=>Int32  long=>Int64  short=>Int16
             *       float=>Single
             *       其他的类型直接To就可以了.  byte decimal double string char 
             *   
             *    c. Convert转换做自动类型转换的时候和自动转换的语法的区别.
             *       没有任何的区别.
             *       但是没有病的话 做自动类型转换不要用Convert了,直接赋值多方便啊.
             *       
             *    d. 做强制转换的时候和强转的语法的区别.
             *       当强制转换成功的时候. 这个时候没有任何区别.
             *       当发生溢出的情况的时候. 强制转换的语法不会报错,并保存溢出的部分.
             *                             Convert转换如果发生溢出 运行报错.
             *       
             *        
             *       当将浮点型强制转换为整型的时候.
             *        使用强制转换的语法: 会直接去掉小数部分.
             *        使用Convert转换会做四舍五入. 只有大于0.5的时候才会入, 小于等于0.5舍
             *        
             *    e. 转换字符串的时候与Parse转换的区别.
             *       当Convert转换字符串的时候,其内部就是调用了Parse方法.效果和Parse转换是一样的.
             *       
             *       唯一的区别:
             *       当字符串的值为null的时候.
             *       Convert转换得到0. Parse转换报异常.
             *       
             *    f. 其他的转换.
             *       根据意义来转换的. false:0        true:1
             *       
             * 7. ToString 将任意的类型转换为字符串.
             *    语法:  该变量名.ToString(); 声明1个字符串类型的变量接收其结果.
             *           就会将该变量的值转换为字符串.
             * 
             * 
             * 
             * 
             */

            // 1.	请写1个程序,这个程序要求用户从控制台输入两个数, 然后输出两个数的积.

            //a. 从控制台接受用户输入这两个数.
            //Console.WriteLine("请输入第1个数:");
            //string strNumA = Console.ReadLine();
            //Console.WriteLine("请输入第2个数:");
            //string strNumB = Console.ReadLine();
            ////b. 将用户输入的数据转换为数值类型
            //double numA = double.Parse(strNumA);
            //double numB = Convert.ToDouble(strNumB);
            ////c. 求积
            //Console.WriteLine("{0}*{1}={2}", numA, numB, numA * numB);

            //2.	求用户输入矩形的长和宽,求出矩形的面积和周长,并将结果显示在屏幕上. 
            //面积: 长*宽  周长  （长+宽)*2

            //3.	要求用户输入圆形的半径,求出圆形的面积和周长,并将结果显示在屏幕上.
            //面积:pi*r*r 周长: 2*pi*r

            //Console.WriteLine("请输入圆形的半径:");          
            ////将用户输入的内容直接交给Parse转换 转换为double
            //double r =  double.Parse(Console.ReadLine());
            //double zhouChang = 2 * 3.14 * r;
            //double mianJi = 3.14 * r * r;
            //Console.WriteLine("面积为{0},周长为{1}",mianJi,zhouChang);






            //4.	编程实现计算几天(如46天)是几周零几 天. 天数要求用户 从控制台输入

            //Console.WriteLine("请输入1个天数:");
            //int days = int.Parse(Console.ReadLine());//42
            //int week = days / 7;
            //int day = days % 7;
            //Console.WriteLine("{0}天有{1}周{2}天",days,week,day); 



            //5.	请用户从控制台输入1个秒数,求用户输入的秒数是几天几小时几分钟几秒? 708905 
            int zongMiaoShu = 708905;
            //求天数,总秒数/1天的秒数
            int day = zongMiaoShu / (24 * 60 * 60);
            //求小时. 算了天以后 剩下秒数有多少小时. 
            int hour = zongMiaoShu % (24 * 60 * 60) / (60 * 60);
            //求分钟. 算了小时以后,剩余的秒数有多少分钟.
            int min = zongMiaoShu % (24 * 60 * 60) % (60 * 60) / 60; 

            int s = zongMiaoShu % (24 * 60 * 60) % (60 * 60) % 60; 
            Console.WriteLine(day + ":" + hour + ":" + min + ":" + s);

             
            //6.	编一个程序，定义圆周率Pi=3.1415,要求用户输入这个圆柱的底圆的半径和圆柱的高 求出圆柱的体积。圆柱的体积:Pi*圆的半径的平方*圆柱的高
            //7.	编一个程序，定义变量量Pi=3.14159265,从键盘上输入半径r,求出圆的面积。














            //int i = 12;//"12"
            //string s = i.ToString();
            //Console.WriteLine(s + 1);



            //double d = 12.12;
            //string s1 =  d.ToString();
            //Console.WriteLine(s1+1);



            //int i = 12; 
            //string s =  Convert.ToString(i);
            //Console.WriteLine(s+1);



            //bool b1 = true;
            //int i =  Convert.ToInt32(b1);
            //Console.WriteLine(i);







            //string str = null;//不是""

            //int num =  int.Parse(str);

            ////int num = Convert.ToInt32(str);
            //Console.WriteLine(num);



            //string str = "123a";
            ////int num = int.Parse(str);
            ////Console.WriteLine(num);


            //int num1 =  Convert.ToInt32(str);
            //Console.WriteLine(num1);




            //double d1 = 12.589;
            //int i = (int)d1;
            //d1 - i;

            //double d = 12.5;
            //int i = Convert.ToInt32(d);
            //Console.WriteLine(i);

            ////double d1 = 12.999;
            //int i = (int)d1;
            //Console.WriteLine(i);




            //double d2 = 12.1299;
            //int i1 = Convert.ToInt32(d2);
            //Console.WriteLine(i1);




            //string str = "8";
            //char cha = Convert.ToChar(str);//'8'
            //Console.WriteLine(cha - 1);


            //int i = 300;
            //byte b = (byte)i;
            //Console.WriteLine(b);


            //int i1 = 300;
            //byte b1 = Convert.ToByte(i1);
            //Console.WriteLine(b1);



            //byte b = 12;
            //int i = b;

            //byte b1 = 12;
            //int i1 =  Convert.ToInt32(b1);
            //Console.WriteLine(i1);




            //string str = "a";
            //char c =  Convert.ToChar(str);

            //Console.WriteLine(c);
            //string str = "12.123";
            //float f =  Convert.ToSingle(str);
            //Console.WriteLine(f+1);


            //string str = "123";
            //short num = Convert.ToInt16(str);
            ////int num = Convert.ToInt32(str);
            //Console.WriteLine(num+1);

            //求用户输入矩形的长和宽,求出矩形的面积和周长,并将结果显示在屏幕上

            ////1. 让用户输入长和宽.
            //Console.WriteLine("请输入长:");
            //string strChang = Console.ReadLine();//"67.2"
            //Console.WriteLine("请输入宽:");
            //string strKuan = Console.ReadLine(); 
            ////2. 因为用户输入的是字符串类型 所以我们应该做转换,
            //double chang = double.Parse(strChang);
            //double kuan = double.Parse(strKuan); 
            ////3. 求周长和面积.
            //double zhouChang = (chang + kuan) * 2;
            //double mianJi = chang * kuan;
            //Console.WriteLine("周长为{0},面积为{1}",zhouChang,mianJi); 

            //string str = "123.123";
            //int num = int.Parse(str);
            //Console.WriteLine(num+1);



            //int i = 98;
            //char c = (char)i;
            //Console.WriteLine(c);


            //double d = 12.12;
            //int i = (int)d; 


            //int i = 120000;
            //short s = (short)i;
            //Console.WriteLine(s);



            //int i = 120000;
            //long l = i;

            //double d = i;




            Console.ReadKey();
        }
    }
}
