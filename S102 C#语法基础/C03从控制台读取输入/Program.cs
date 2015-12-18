using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03从控制台读取输入
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 在程序运行的时候 需要从控制台读取用户的输入.
             *    Console.ReadLine();   
             *    当执行到这句代码的时候,程序会暂停.直到用户按下回车键的时候继续往下执行.
             *    在用户按下回车键的时候,会把在回车键之前用户输入的内容以字符串的形式返回给程序.
             *    
             *    在程序中声明1个字符串类型的变量来接收这句代码的结果.
             *    string input = Console.ReadLine();
             *    当执行到这句话的时候,就会将用户输入的内容以字符串的形式赋值给input变量.
             *    
             *  2. 无论用户输入什么内容,返回的数据的类型都是字符串类型的.
             *     所以我们必须使用1个string类型的变量来接收这句代码的结果.
             *     
             * 
             *  
             * 
             */

            string name, age, gender, weight, height; 
            //请编写1个程序,接收用户的姓名、性别、年龄、身高、体重,然后打印自我介绍信息.
            Console.WriteLine("请输入姓名:");
            name = Console.ReadLine();  

            Console.WriteLine("请输入性别:");
            gender = Console.ReadLine(); 
            Console.WriteLine("请输入年龄:");
            age = Console.ReadLine(); 
            Console.WriteLine("请输入身高:");
            height = Console.ReadLine(); 
            Console.WriteLine("请输入体重：");
            weight = Console.ReadLine(); 
            Console.WriteLine("大家好,我叫" + name + ",我的性别是" + gender + ",我的年龄是" + age + ",我的身高是" + height + ",我的体重是," + weight);




            //问用户喜欢吃什么水果,假如用户输入”苹果”,则显示”哈哈,这么巧呀,我也喜欢吃苹果” 
            //1. 提示用户输入喜欢吃的水果 
            //Console.WriteLine("亲,你最爱的水果是什么呢?");
            ////2. 接收用户的输入
            //string like = Console.ReadLine();
            ////3. 显示信息,.
            //Console.WriteLine("这么巧啊,我也最爱:" + like);  

            //请用户输入姓名  然后打个招呼.
            //Console.WriteLine("请输入你的姓名:"); 
            //string name =  Console.ReadLine(); 
            //Console.WriteLine("你好啊"+name);  


            //string input = Console.ReadLine();
            //Console.WriteLine(input+1);
            ////Console.WriteLine("大家好." + input);

            //string name = "jack";
            //byte age = 19;
            //char gender = '男';
            //Console.WriteLine("大家好,我叫" + name + ",我的年龄是" + age + ",我的性别是" + gender);

            Console.ReadKey();
        }
    }
}
