using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C04字符串的转义符
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 在字符串中,有一些字符是具有特殊的意义的.
             *    双引号(") 在字符串中代表1个字符串的开始和结束.
             *    
             * 2. 字符串转义符:  \ 可以改变后面的字符的原本的意义.
             *    \"   字符串的双引号 *
             *    \t   制表符 *
             *    \\   代表字符串的\  *
             *    \b   删除前面的字符
             *    \n   换行  linux
             *    \r\n 换行  windows *
             *    
             * 3. @符号.代表字符串中的\不代表转义,就代表字符串的斜杠(\)
             *    
             *    
             * 
             */

            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\2052\alinkui.dll";


            string str = "我爱\r\n北京\r\n天安门";


            //string path  = "F:\\Muisc\\经典老歌\\：下辈子不做女人 ....mp3";
            //Console.WriteLine(path);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
