using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C09枚举
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 如果某个变量的取值限定在两个中的1个.最佳的解决方案是用bool类型.
             * 
             * 2. 声明1个变量保存1个人的面朝方向.
             *    新的需求: 要限定变量的取值.
             *    
             * 3. 枚举:限定变量的取值.
             * 
             * 4. 定义枚举的语法:
             *    enum 枚举的名称
             *    {
             *       写上要限定的取值,每1个取值使用逗号分隔.
             *    }
             *    
             *    定义枚举的位置:
             *    命名空间下,与类同级别.
             *    
             * 5. 如何使用枚举.
             *    声明1个枚举类型的变量. 为这个变量赋值 
             *    轻敲空格键 VS会自动定位到这个枚举.
             *    选中之后在我们定义的限定的值中,任意选择1个值.
             *    除了我们限定的值之外,别的值是不能给的.
             * 
             * 6. 定义在枚举中的枚举值 不能用双引号引起来,因为枚举不是字符串.
             * 
             * 
             * 7. 每1个枚举值默认情况下都有1个对应的int类型的数,这个数从0开始,依次递增.
             *    可以通过强制转换的语法 将枚举值对应的整型的数取出来.
             *           Direction dir = Direction.West;
             *           int i = (int)dir;
             *    我们也可以将1个整型的数强制转换为其所对应的枚举值.
             *           int i = 3;
             *           Direction dir = (Direction)i;
             *           如果没有对应的枚举值,就原样的输出.
             *           
             *  
             * 8.每1个枚举值对应的int类型的数,默认从0开始并依此的递增.
             *   我们可以手动的去为每1个枚举值指定它所对应的整型的数.
             *   但是请记住,只能是int类型的数.
             *   
             *   我们的建议是:一定要为每1个枚举值指定1个对应的整型的数,
             *   哪怕从0开始 依此的递增.
             *   
             * 9.默认情况下,每1个枚举值对应的整型的数是1个int类型的.
             *   而枚举值对应的整型的类型 其实是可以改变的。
             *   在枚举的名称后面 跟上冒号 写上指定的整型的类型.
             *   但是请记住,类型只能是整型的.
             *    
             * 
             * 10.将字符串转换为枚举类型.
             *    string strDir="East"
             *    Direction dir = (Direction)Enum.Parse(typeof(Direction), strDir);
             *    忽略大小写的转换:
             *    Direction dir = (Direction)Enum.Parse(typeof(Direction), strDir,true);
             * 
             * 
             * 11. 将枚举转换为字符串.
             *     ToString()方法.
             *     
             *     枚举.ToString("d") 将枚举值对应的整型的数转换为字符串 。
             * 
             */


            //Console.WriteLine("请输入你的方向:");
            //string strDir = Console.ReadLine();

            //Direction dir = (Direction)Enum.Parse(typeof(Direction), strDir,true);
            //Console.WriteLine(dir);

            Direction dir1 = Direction.South;
            string s =  dir1.ToString("d");
            Console.WriteLine(s);





            //Console.WriteLine("请选择你的方向:  0.东 1.西  2.南 3.北"); 
            //int i = 2;
            //Direction dir = (Direction)i;
            //Console.WriteLine(dir);

            //Direction dir = Direction.East;
            //int i = (int)dir;
            //Console.WriteLine(i);





            Console.ReadKey();
        }

    }
}
