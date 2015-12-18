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
            /* 1. 三元表达式.
             *    a. 语法: bool表达式?值1:值2;
             *    b. 三元表达式的结果.
             *    c. 值1与值2的类型必须要一致或者互相兼容.
             * 
             * 2. switch-case结构. 选择结构.
             *    a. 语法
             *    switch(表达式)
             *    {
             *       case 值1:
             *          执行语句1;
             *          break;
             *       .....
             *       defualt:
             *          默认执行代码
             *          break;
             *    }
             *    b. 执行步骤:
             *    c. 细节:
             *       1). switch表达式的结果不能为浮点型.
             *       2). case块后面的break绝大多数情况下是必不可少的.
             *       3). case块可以有任意个.
             *       4). defualt可以省略.
             *       5). case后面的值的数据类型 必须要和 switch表达式的结果的类型一致.
             *       6). 如果多个case块的处理逻辑是一样的 那么可以简写.
             *       7). case块后面可以写1个表达式,但是这个表达式不能有变量参与.
             */


            Console.ReadKey();
        }
    }
}
