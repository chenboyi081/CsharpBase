using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C04比较表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 比较运算符.
             *    >   >=   <    <=   ==   !=
             *    
             * 2. 比较运算:比大小
             *    比较表达式: 由比较运算符连接起来的式子.
             *    
             *    > 大于符号.
             * 
             * 3. bool数据类型.
             *    它就是专门用来表示1个条件是否成立的.
             *    其取值只有两种:
             *       true: 代表条件成立
             *       false: 代表条件不成立.
             *    
             * 4.比较表达式的结果是1个bool类型的.
             *   如果比较表达式的结果是成立的 那么结果就是true。
             *   否则就是false
             *   
             *   > 如果左边的数据大于右边的数据 这个比较表达式的结果为true,否则为false。
             *   >= 大于或者等于.  中间没有空格.
             *      左边的数据如果大于右边的数据返回true。或者左边的数据等于右边的数据也返回true。
             *      否则false。
             *      大于或者等于就为true。只有左边的小于右边的才会false。
             *   <    
             *   <= 小于或者等于.
             *   
             * 5. > >= < <=这四种比较运算 只能比较数值类型的数据或者char类型的数据.
             *    如果有char类型的数据参与比较表达式. 首先会将其对应的ASCII取出来,再参与比较.
             *    
             * 
             * 6. == 是比较左右两边的数据是否相等.  两个等号哦 亲.
             *    != 是比较左右两边的数据是否不等. 如果不等返回true，如果相等返回false。
             *    
             *    ==和!= 是可以比较任意类型的数据的相等性和不等性.
             *    如果比的是字符串的话,比的是两个字符串中的内容.
             *    
             * 
             *    参与比较的数据的类型 要么相同。 要么互相兼容.
             *    
             * 7. bool类型.如果某个变量的取值只有2个,不会有第3个,那么这个时候使用bool类型的变量来存储是最合适的.
             *    人的性别.
             *    
             * 8. 
             *  
             * 
             * 
             */

            //true:男  flase:女
            //bool gender = false;



           //string gender = "妖";






            //string str1 = "中国";
            //string str2 = "中國";
            //bool b = str1 == str2;
            //Console.WriteLine(b); 

            //byte b = 12;
            //int i = 11; 

            //bool b1 = b == i;
            //Console.WriteLine(b1);


            //string s1 = "123";


            //int num = 124;


            //bool b = s1 == num;




            //bool b1 = false;
            //bool b2 = true;


            //bool b3 =  b1 == b2;




            //string s1 = "中国";
            //string s2 = "中国";
            //bool b =  s1 != s2;
            //Console.WriteLine(b);



            //int i = 12;
            //int j = 11; 

            //bool b = i == j; 
            //Console.WriteLine(b);



            //int num1 = 12;
            //int num2 = 12;


            //bool b =  num1 == num2;
            // Console.WriteLine(b);


            //char c = 'a';
            //int i = 99;


            //bool b = c > i;
            //Console.WriteLine(b);

            //string str1 = "中国", str2 = "日本";

            //bool b = str1 > str2;

            //int num1 = 4;
            //int num2 = 10; 

            //bool b = num1 <= num2;
            //Console.WriteLine(b);





            //int num1 = 21;
            //int num2 = 21; 
            //bool b = num1 >= num2; 
            //Console.WriteLine(b);


            //bool b = num1 > num2;//  12大于10. 判断这句话的正确性. 
            //Console.WriteLine(b);


            Console.ReadKey();
        }



    }
}
