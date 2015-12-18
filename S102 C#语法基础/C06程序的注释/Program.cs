using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C06程序的注释
{
    class Program
    {

        /// <summary>
        /// 这是1个方法哈哈哈哈哈哈哈哈.
        /// </summary>
        public static void SayHi()
        {
        }


        static void Main(string[] args)
        {
             

            /* 1. 注释. 程序员在编程的时候 对代码的注解.
             *    注释是给程序员看的.
             *    
             *    一定要养成写注释的习惯.
             *    
             * 2. 单行注释. //后面的这1行的内容都会被当做注释的内容,C#编译器在编译的时候会忽略掉注释的内容
             *    多行注释.
             *    斜杠*  和 *斜杠 中间的内容是注释.
             *    文档注释:
             * 
             * 3. 相关的快捷键:
             *    ctrl+k+c   注释
             *    ctrl+k+u   取消注释.
             *    
             * 
             * 
             */



            //这是1个很牛x的功能 向屏幕打印一句话.console.wriyt("21"); 
            //锄禾日当午
            //汗滴禾下土 
            Console.WriteLine("大家好");


            Console.ReadKey();
        }
    }
}
