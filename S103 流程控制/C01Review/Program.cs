using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C01Review
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 数据应该使用什么样的类型的变量来存储
             *    要存储的数据是1个什么样式.
             *    如果数据本身就不是1个数值.那么就使用string或者char
             *    数据本身看起来是一个数值.
             *       如果数据要参与算术运算,那么使用数值类型存储.
             *       如果数据不参与算术运算,那么使用string就可以了.
             * 2. 交换变量的值
             *    a. 交换的前提是可以交换.
             *    交换的方式,对于所有类型的变量来将.声明1个第3方临时变量.转圈.
             *    对于数值类型的.两数相加再相减.
             * 3. 读取用户从控制台的输入
             *    Console.ReadLine();
             *    让用户从控制台输入内容,将用户输入的内容通过字符串的形式返回给程序.
             *    定义1个字符串类型的变量 来接收这句代码的结果就可以了.
             *    
             *    无论在控制台输入什么样的内容,那么都是以字符串的形式返回给程序的.
             *    所以我们必须声明1个字符串类型的变量来接收用户的输入.
             *    
             * 4. 字符串的转义符
             *    \"
             *    \\
             *    \r\n
             *    \t
             *    
             *    @符号
             * 5. 占位符
             *    
             * 6. 注释
             * 7. 算术运算符与算术表达式
             *    + - * / %
             *    a. 算术表达式: 由算术运算符连接起来的式子.
             *    b. 算术表达式的结果的类型:
             *       1). int short byte互相参与的时候结果都是int。
             *       2). 如果参与算术表达式的数据的类型一致,那么结果的类型就是这个类型.
             *       3). 如果不一致,那么结果的类型就是范围最大的那个类型.
             *    c. / 除法运算.
             *       10/3 
             *    d. % 求模运算, 是求余数.
             *      10%3  1
             *    e. 参与算术表达式的数据 只能是数值类型和char类型.
             *       如果是char类型参与 首先会将其转换为其所对应的ASCII码 然后再参与运算.
             *    f. decimal类型的数据不能和其他的浮点型数据参与算术运算,因为会丢失精度.
             *       
             * 8. 自动类型转换
             * 9. 强制类型转换
             * 10.Parse转换.
             * 
             * 
             */


            char c = 'c';
            int num =  c + 1;


            Console.WriteLine(10.0/3);

            //string name = "jack";
            //int age = 19;
            //char gender ='男';


            //Console.WriteLine("大家好,我叫{0},我有{1}岁了,我是{2}的",name,age);




            //Console.WriteLine("AAAAAAAAA");
            //string input = Console.ReadLine();//"100"  100



            //Console.WriteLine("AAAAAAAAAAA");
            //Console.WriteLine(input);


            Console.ReadKey();
        }
    }
}
