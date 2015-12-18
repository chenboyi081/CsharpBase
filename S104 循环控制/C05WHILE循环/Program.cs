using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C05WHILE循环
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 变量的作用域
             *    变量可以在那1段范围之内访问.
             *    
             * 2. 定义在1个大括弧中的变量,只能在这个大括弧中访问. 出了这个大括弧,定义在其中的变量就无法访问了.
             *    定义1个变量就是在内存中开辟1块空间.  这个空间是要被回收的
             *    什么时候被回收呢? 当执行完1个大括弧之后,定义在这个大括弧中的变量就会被立即回收.
             *    所以在大括弧的外面是无法访问其中的变量的.
             *    
             * 3. 循环:
             *    1件事情,反复不停的去做.
             *    现实生活中的循环.一定要有停止的条件.
             *    
             *    在C#中,有1段代码需要被反复不停的执行N次.
             *    a. 将这段代码复制粘贴N次.
             *       这样的做的缺点:
             *       1) 代码冗余.
             *       2) 修改维护极度的不方便.
             *          ctrl+h 查找替换.
             * 
             * 4. 循环结构: 可以将1段代码反复不停的执行指定的次数.并且方便维护和修改.
             *    while结构 do-while结构 for结构.
             *    
             * 5. while循环.
             *    a. 语法.
             *    while(bool表达式)
             *    {
             *       那段需要被反复不停的执行的代码.(循环体)
             *    }
             *    b. 执行步骤
             *       1). 计算bool表达式的结果.
             *           1.1) 如果结果为true,就执行循环体.执行完毕以后. 跳回第1步.
             *           1.2) 如果结果为false.就结束while循环结构,继续往下执行.
             *    
             *    c. 写循环的时候务必要确定如下事情.
             *      1). 确定要反复不停的执行的代码 就是需要被反复不停的做的事情.
             *      2). 循环什么时候结束.
             * 
             * 
             * 6. 死循环: 循环没有退出的那1刻. bool表达式的结果永远都是true.
             *    我们在写循环的时候要尽量的去避免死循环,因为死循环的后面的代码永远不可能执行到的.
             *    
             *  
             * 7. 循环应用之一:  循环体确定的,循环的次数也是确定.
             *    声明1个int类型的循环增量i并赋值为0.用来记录循环的次数.每循环1次 将循环增量i的值自增.
             *    写1个while循环. 循环条件 i<次数  在循环体里记得要去改变循环增量i的值.
             *    why?
             *    因为循环增量的值 在每次循环的时候 都会发生改变. 当第(次数+1)次去计算bool表达式的结果的时候.
             *    这个时候i的值就已经使这个bool表达式的结果为false，所以循环就结束了.
             *    eg:
             *    int i = 0;
             *    while(i<次数)
             *    {
             *       循环体.
             *       i++;
             *    }
             *    
             *    注意:
             *    a. 一定要记得在循环体中 修改循环增量的值.
             *       否则,要是第1次可以进入循环的话,那么这就是1个死循环,因为循环增量的值没有发生变化,
             *       第1次是true，后面全是true。
             *    b. 循环的次数 如果循环增量的值默认是0  那么就不需要再等于了. 因为从0开始的.
             *    
             * 
             * 8. 循环的第二种应用: 循环体确定，循环的次数不确定.  但是循环结束的条件是确定.
             *    先写1次循环体,保证至少执行1次.
             *    在写1个循环,循环的条件是 循环要继续的条件. 
             *    在循环体的内部要改参与循环条件的变量的值. 否则如果第1次可以进入循环 那么就是1个死循环.
             *    
             *    一定要注意:
             *    a.我们最清楚的是 循环结束的条件. 而事实上我们要写循环继续的条件.
             *    b.在循环体重要更改循环条件中的变量的值.否则如果第1次可以进入循环 那么就是1个死循环.
             * 
             * 
             * 9. 循环的第三种应用: 遍历.
             *    循环次数确定的循环,循环增量i的值,是每次都在发生变化的. 
             *    而现在我们将循环增量i的值 利用起来.
             *    做法:
             *    遍历n到m之间的每1个整数.
             *    int i = n; //声明循环增量 从n开始.
             *    while(i<=m)//到最大数为止
             *    {
             *       此时循环增量i就是我们要遍历出来的那个数了.
             *       i++;
             *    }
             * 
             * 10.循环的第四种应用: 找指定范围中符合特定条件的数.
             *    a. 先将这个范围中的每1个数遍历出来.
             *    b. 判断遍历出来的是不是符合特定条件的,如果是拿出来,否则算了.
             *    
             *    求n-m之间的 符合特点条件的数.
             *    int i = n;
             *    while(i<=m)
             *    {
             *        if(i是符合特定条件的)
             *        {
             *           i就是我要找的.
             *        }
             *        i++;
             *    }
             * 
             * 11.循环的第五种应用: 求累加和和平均值.
             *    a.声明1个"桶变量"sum 用来存储累加和.
             *    b.将这堆数中的每1个数遍历出来, 将遍历出来的数累加到"桶变量"sum中去.
             *    c.当遍历完成以后,sum变量中存储的就是他们的累加和.
             *   
             * 
             */

            //int i = 1;
            //while (i <= 10)
            //{
            //    int sum = 0;
            //    sum += i;
            //    Console.WriteLine(sum);
            //    i++;
            //}






            //由用户输入班级的人数. 然后依次输入他们的成绩. 输出总成绩.
            //Console.WriteLine("请输入班级的人数:");
            //int num = int.Parse(Console.ReadLine()); 
            //int totalScore = 0; 
            //int i = 0;
            //while (i < num)
            //{
            //    Console.WriteLine("请输入第{0}个人的成绩:", i + 1);
            //    int score = int.Parse(Console.ReadLine());
            //    totalScore += score;
            //    i++;
            //}
            //Console.WriteLine("总成绩:"+totalScore+",平均成绩是"+(totalScore*1.0/num));





            //请求1-10中的每1个整数的累加和. 1+2+3+4+5+6+7+8+9+10 
            //int sum = 0; //3
            //int i = 1;
            //while (i < 11)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);


            //求1000 -- 5000 中 各位数相加等于5的整数.
            //1004 1+0+0+4 5  1023  
            //int i = 1000;
            //while (i <= 5000)
            //{
            //    //3456
            //    int qian = i / 1000;
            //    int bai = i % 1000 / 100;
            //    int shi = i % 100 / 10;
            //    int ge = i % 10;
            //    if (qian + bai + shi + ge == 5)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}



            //将1-100之间能够被7 整除的数列出来.
            //int i = 1;
            //while (i <= 100)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}




            //求1-100中的偶数. 
            //int i = 1;
            //while (i < 101)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //由用户输入1个最小数和1个最大数.
            //Console.WriteLine("请输入最小数:");
            //int min = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入最大数:");
            //int max = int.Parse(Console.ReadLine());

            //int i = min;
            //while (i <= max)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.WriteLine("报告,我已经将{0}-{1}打印完毕",min,max);



            //请将a-z中的每1个字符打印出来.

            //char c = 'a';
            //while (c <= 'z')
            //{
            //    Console.WriteLine(c);
            //    c++;
            //}




            //将20-78之间的每1个整数遍历出来.
            //int i = 20;
            //while (i <= 78)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}





            ////请将1-10中的每1个整数打印出来.
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);



            //请用户输入用户名和密码 只要用户名不是admin并且密码不是888888 就重新输入.
            //如果三次都输入错误,也不给你输入了 结束程序,

            //ctrl+j
            //Console.WriteLine("用户名:");
            //string userName = Console.ReadLine();//"admin"
            //Console.WriteLine("密码:");
            //string password = Console.ReadLine();//"123"
            //int i = 0;//记录循环的次数
            ////(userName != "admin" || password != "888888") && i < 2
            //while ((userName != "admin" || password != "888888") && i < 2)
            //{
            //    Console.WriteLine("用户名:");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("密码:");
            //    password = Console.ReadLine();
            //    i++;//每循环1次 i的值自增.
            //}

            //循环结束的条件:    用户名和密码正确. || 次数大于2次.
            //循环继续的条件:    用户名或者密码错误 &&  次数小于2次



            //反复不停的问用户 你爱我不. 值到回到yes为止. 

            //Console.WriteLine("你爱我吗? y/n");
            //string ans = Console.ReadLine();
            //while (ans != "y")
            //{
            //    Console.WriteLine("你爱我吗? y/n");
            //    ans = Console.ReadLine();
            //}


            //从控制台接收用户输入用户名, 只要用户名不是"admin" 就一直要求用户输入.

            //Console.WriteLine("请输入用户名:");
            //string userName = Console.ReadLine();
            //while (userName != "admin")
            //{
            //    Console.WriteLine("请输入用户名:");
            //    string yongHuMing = Console.ReadLine();
            //}





            //写1个程序,这个程序可以接收用户输入1个数.  再接收输入1句话 。 
            //Console.WriteLine("请输入循环的次数:");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("你要打印那句话?");
            //string msg = Console.ReadLine(); 
            //Console.WriteLine("**************************************");
            //int i = 0;
            //while (i < num)
            //{
            //    Console.WriteLine(msg);
            //    i++;
            //}





            //从控制台接收用户输入5个数.将这5个数的2倍打印出来. 
            //int i = 0;
            //while (i < 5)
            //{ 
            //    Console.WriteLine("请输入1个数:");
            //    int num = int.Parse(Console.ReadLine());
            //    Console.WriteLine(num * 2);
            //    i++;
            //}


            //打印20次 "欢迎你来传智播客学习"

            //int i = 0;
            //while (i < 20)
            //{
            //    Console.WriteLine("欢迎你来传智播客学习");
            //}



            //打印10次,我爱北京天安门. 
            //int i = 0;
            //while (i<5)
            //{
            //    Console.WriteLine("我爱北京天安门");
            //    i++;
            //} 
            //Console.WriteLine("OVER");



            //while (true)
            //{
            //    Console.WriteLine("我爱广州小蛮腰");
            //} 

            //Console.WriteLine("AAAAAAAAAAAA");
            //Console.WriteLine("哈哈哈哈...我来了...");


            Console.ReadKey();
        }



    }
}
