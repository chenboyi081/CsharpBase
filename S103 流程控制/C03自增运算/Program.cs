using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03自增运算
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 自增运算.
             *    无论是前自增还是后自增都是将自身的值增加1.
             *    
             * 2. 当后自增参与另外的1个语句的时候.先完成这个语句的功能,在将自身的值增加1.
             *    当前自增参与另外的1个语句的时候.先将自身的值增加1,再完成整个语句的功能.
             *    
             * 3. 优先级.
             *    1元运算符的优先级高于二元运算符.
             *    
             *  4.自减运算 如是.
             *    无论是前自减还是后自减 都将自身的值减1.
             *    
             * 
             * 
             * 
             */



             

            //int i = 2; 
            //i = (++i) + (++i) + (++i);//3+4+5 
            //Console.WriteLine(i); 



            int i = 12;
            i += 3;//i=i+3
            Console.WriteLine(i);



            i -= 2;  //i=i-2;
            i *= 2;  //i=i*2;
            i /= 2;  //i=i/2;

            i %= 2;//i=i%2;







            //int i = 4; 
            //int j = i++ + ++i;
            //Console.WriteLine(j);



            //int i = 5;
            //--i;
            //Console.WriteLine(i);


            //int j = 3;
            //int k = i++ * ++j;



            //Console.WriteLine(k);
            //Console.WriteLine("i={0},j={1}", i, j);


            //int i = 10;
            //int j = ++i;
            //Console.WriteLine("i={0},j={1}", i, j);


            //int i = 10;
            //int j = i++;
            //


            // int k = 10;
            // Console.WriteLine(k++);

            //Console.WriteLine(k);


            Console.ReadKey();
        }
    }
}
