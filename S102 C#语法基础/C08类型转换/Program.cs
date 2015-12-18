using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C08类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10, b = 3;
            //int mod = a % b; //1
            //double quo = a / b;   //3.3333  
            //Console.WriteLine(mod);
            //Console.WriteLine(quo);

            /* 1. 自动类型转换.
             *    将1个byte类型的变量中的值赋值给1个int类型的变量,为什么不报错,数据类型明显不同?
             *    a. byte类型的变量和int类型的变量都是用来存储整型的数据.
             *    b. 无论byte类型的变量中的值是多少,都可以将其放到int类型的变量中去,不会出任何的问题.
             *    
             *    在数据类型兼容的情况下,我们可以将1个小范围的变量的值 直接 赋值给1个大范围的类型的变量.
             *    这样做绝对不会有问题的.
             *    a. 因为他们之间相互兼容
             *    b. 小范围变量的值无论是多少都可以直接放到大范围的变量中.
             *    因为不会有任何问题,所以直接赋值就可以了,C#编译器自动的帮助我们完成转换.
             *    范围: 
             *    所有的数值类型和char类型之间是互相兼容的.
             *    
             *    类型转换:指的是把1个类型的变量的值 拿出来(有的是要经过处理）赋值给另外的1个类型的变量 的过程.
             *    变量的类型一旦声明,就无法改变.
             *    
             *    可以直接将1个char类型的数据赋值给1个int类型的变量.那么这个int类型的变量的值就是这个char类型的数据对应的ASCII码
             *    char类型的数据对应的ASCII码是1个int类型的数据. 
             * 
             *    满足自动类型转换的条件:
             *    a. 数据类型兼容.(所有的数值类型和char类型之间相互兼容) 特别强调字符串和数值类型以及char类型之间不兼容.
             *    b. 目标变量的范围要大于源变量.
             * 
             * 2. 强制类型转换.
             *    在数据类型兼容的情况下,我们不能直接将1个大范围的类型的变量的值 直接 赋值给1个小范围的类型的变量.
             *    因为有可能会发生溢出的现象.
             *    当大范围变量中的值 刚好 在小范围的变量中. 这个时候其实是可以的.
             *    当大范围变量中的值超过小范围的变量,那么这个时候就会发生溢出的现象.
             *    所以这个时候 C#编译器就不会帮助我们自动的去完成转换了.
             *    
             *    这个时候我们可以使用强制转换的语法,来让我们的C#系统不考虑溢出的情况.直接将大范围变量中的值赋值给小范围的变量.
             *    如果强制转换的时候.大变量中的值在小变量的范围之内,一切和谐.
             *    但如果不在,那么结果就不是我们想要的了.
             *    所以我们在强制转换的时候,一定要保证大范围变量中的值 要在 小范围的变量中.
             *    
             *    将浮点型强制转换为整型, 会将小数部分活生生的截取掉. 不会做四舍五入.
             *    
             *    强制类型转换的首要前提是:
             *    a. 类型兼容
             *    b. 大范围赋值给小范围.
             * 
             *    可以直接把char类型的数据赋值给int类型的变量.
             *    但是不能直接把int类型的数据赋值给char类型的变量,如果一定要赋值,那么必须使用强制转换的语法.
             *    结果就是以这个int类型的数为ASCII码所对应的字符.
             *    
             *     
             * 3. 关于char类型
             *    a.  每1个char类型的数据都有1个对应的ASCII码.这些ASCII是1个int类型的数.
             *    b.  char类型不是int类型. 只是char数据的ASCII码是1个int类型的.
             *    c.  自动类型转换.
             *        char c = 'a';
             *        int i = c;
             *        直接就是将c变量对应的ASCII码直接赋值给i.
             *    d.  强制类型转换:
             *        int i = 97;
             *        char c = (char)i;
             *        强转做的事情:  就是把以i为ASCII码对应的字符 赋值给 c 
             *        
             *    
             * 4. 无论是自动类型转换还是强制类型转换,他们类型必须要兼容.
             *    相互兼容的类型: 数值类型和char
             *    特别字符串和他们不兼容.
             * 
             * 
             * 5. Prase转换:  它将字符串转换为其他的类型.
             *    语法:
             *    要将字符串转换为什么类型就   什么类型.Parse(待转换的字符串);
             *    定义1个对应的类型的变量来接受这句代码的结果.就可以得到转换成功后的数据.
             *    eg:
             *    string str = "456";
             *    int num = int.Parse(str);
             *    num变量中就存储的是转换成功的值了.
             *     
             *    需要注意的细节:
             *    a. 只能将字符串转换为其他的类型. Parse的小括弧中只能是字符串.
             *    b. 什么时候可以转换成功?
             *       当字符串的字面量是1个指定类型的时候,那么这个时候就可以将字符串通过Parse转换为这个类型
             *       字面量:字符串去掉双引号的部分.
             *       比如：我要判断1个字符串能否转换为int类型。
             *             将这个字符串去掉双引号后 看它是不是1个int类型的,如果是ok 否则nook
             *    
             * 
             */
             
            ////请写1个程序,让用户输入两个int类型的数 算出他们的和并打印.
            //Console.WriteLine("请输入第1个数:");
            //string strNumA = Console.ReadLine(); //"12"
            //Console.WriteLine("请输入第2个数:");
            //string strNumB = Console.ReadLine();//"20" 
            ////将用户输入的字符串内容转换为数值类型.
            //int numA = int.Parse(strNumA);
            //int numB = int.Parse(strNumB);  
            //Console.WriteLine(numA+numB);



            //string str = "中国";
            //int num =  int.Parse(str);



            //string str = "a";
            //int c = char.Parse(str);//'a' 
            //Console.WriteLine(c);


            //Console.WriteLine(c + 1 - 1);




            //string str = "300";
            //byte s = byte.Parse(str);
            //Console.WriteLine(s);

            //string str = "190.123";
            //double num = double.Parse(str);
            //Console.WriteLine(num);

            //byte b = 12;
            //int i = b;

            //int i1 =  int.Parse(b);



            //string str = "a";
            //char c =  char.Parse(str);
            //Console.WriteLine(c+1);


            //string str = "12";
            //byte b =  byte.Parse(str);
            //Console.WriteLine(b+1);



            //string str = "12.12";
            //double d1 =  double.Parse(str);
            //Console.WriteLine(d1+1);




            //string str = "12";
            //int num = int.Parse(str); 
            //Console.WriteLine(num + 1); 







            //int num = 12;
            //long l = num;

            //short s1 = 30;
            //int i1 = s1;

            //char c = 'b';
            //int i1 = c;

            //double d1 = 12.12;
            //int i = (int)d1;

            //double d1 = 12.12;
            //float f = (float)d1;

            //int i = 98;
            //char c = (char)i;




            //float b = 97.1111f;
            //char c = (char)b;
            //Console.WriteLine(c);



            //char c = 'a';
            //int i = c;  
            //int i1 = 97;
            //char c1 = (char)i1;




            //byte b = 97;
            //char c = (char)b;
            //Console.WriteLine(c);



            //byte i = 65;
            //char c = (char)i;
            //Console.WriteLine(c);



            //string str = "123"; 
            //int i = (int)str;



            //double d1 = 12.999;
            //int i1 = (int)d1;
            //Console.WriteLine(i1);



            //long l = 2200000000;
            //int i1 = (int)l;
            //Console.WriteLine(i1);



            //int i1 = 259;
            //byte b1 = (byte)i1;
            //Console.WriteLine(b1);





            //int i = 12;
            //long l = i;


            //char c = 'A';
            //int i = c;
            //Console.WriteLine(i);


            //char c1 = 'a';
            //long s = c1;



            //short s1 = 30000;
            //int i1 = s1;




            //byte b1 = 12;
            //int i1 = b1; 



            Console.ReadKey();
        }
    }
}
