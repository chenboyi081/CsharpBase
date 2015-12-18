using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C04数组
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 变量名是不能拼接的. 不能使用+号来拼接1个变量.        
             * 
             * 2. 我们希望:
             *    因为1个普通的变量中只能存储1个值.为这个变量重新赋值 新值就会将 老值给覆盖掉.
             *    要是有这个功能就好了.
             *    1个变量中可以存储多个数据. 往这个变量中存储数据的时候,原来的值还在,存进去的新值与老值共同存在.
             * 
             * 3. 数组: 数据的组合  
             *    功能: 用来存储数据的. 与普通的变量不同的是,数组中可以存储多个数据.这多个数据共同存在.
             *    
             *    数组其实就是1个容器. 存储数据的1个容器.
             *    数组存储数据的特点:
             *    a. 可以存储多个数据.
             *    b. 存储的数据的类型必须是相同的: 能够往数组中存储的数据的类型必须相同.
             *       在创建数组的时候.我们就要指定这个数组中存储的多个数据的类型.
             *    c. 数组能够存储的数据的个数是固定的.
             *       数组能够存储多少个数据 是在创建数组的时候指定的, 必须要指定.
             *       一旦指定这个数组能存储的个数就固定了.
             *    
             * 
             * 4. 创建数组:
             *    a. 要确定数组中能存储的数据的类型.
             *    b. 数组可以存储的数据的个数. 
             *    语法:
             *    数组中存储的数据的类型[]  数组的名称 =  new 数组中存储的数据的类型[数组可以存储的数据的个数];
             *    int[] arr = new int[3];
             *    
             *    int[] 是1种数据类型, 读作int数组.
             *    arr是1个变量. 这个变量与之前学的普通的变量不同.
             *    new int[3]; 是1个表达式. new是1个运算符. 会将表达式的结果通过赋值符号赋值给变量arr。
             *    
             *    在内存中发生的事情:
             *    在内存中声明1个int[]类型的变量arr。 
             *    然后将这个arr变量划分成了3个小空间. 划分为多少个是根据 new int[3] 中括弧里面的数来决定的.
             *    每1个小空间的类型是int类型的. 每个小空间的类型是根据 new int[3] new后面的类型来决定的.
             *    
             * 
             * 5. 几个术语:
             *    a.元素:  数组中的每1个小空间, 我们把它叫做数组的元素.
             *    b.元素的下标(索引): 数组内部会为每1个元素编1个号,这个号从0开始 依次的递增, 我们就把这个数叫做元素的下标(索引)
             *    c.数组的长度:  数组中能够存储数据的个数.
             * 
             * 
             * 6. 数组就相当于挖1个大坑, 在这个大坑里面挖小坑.
             * 7. 往数组中存储数据
             *    a. 不能直接把数据赋值给数组变量.
             *       int[] arr= new int[3];
             *       arr = 10;
             *       从赋值表达式的角度讲 错误的 10是int类型 arr是int[]类型. 类型不同且不兼容.
             *    
             *    b. 我们往数组中存储数据的真实目的:
             *       不是把数据赋值给数组. 而是把数据赋值给数组中的元素.
             *        
             *       首先你要确定要把数据赋值给数组中的那1个元素.用下标区分.
             *       数组的名称[元素的下标] = 值;
             *       [] 叫做索引器.
             *       
             *    c. 需要注意的地方
             *        1). 赋的值必须要与元素的类型一致.
             *        2). 索引超出了数组界限.
             *            数组1旦声明,其元素的个数就确定. 元素的最大下标: 数组的长度-1
             *            如果我们访问元素的时候,给的下标在数组中不存在. 就会报这个运行错误.
             *         
             *    d. 数组中的元素本质上是1个变量. 这个变量的类型是根据我们在创建数组的时候new的时候决定的.
             *       所以在为数组的元素赋值的时候. 满足自动类型转换的时候 都是可以直接赋值的.
             *       
             *       数组虽然是可以存储多个数据的,但是数组中的元素仍然是1个普通变量.
             *       数组中的元素仍然只可以存储1个值.为元素重新赋值的时候 元素中如果已经有值 那么新值会将老值给覆盖.
             *        
             * 
             * 8. 创建数组:
             *    a. 语法:
             *       元素的类型[] 数组的名称 = new 元素的类型[数组的长度];
             *    b. int和byte相互兼容 但是int[]和byte[]不兼容.
             *       声明数组的时候.  赋值符号左右两边的元素的类型要一致.
             *    c. 在创建数组的时候,必须要指定数组的长度,否则会报语法错误.
             *       
             * 
             * 9. 取出数组中元素的值.
             *    a. 首先要确定 要取那个元素的值  通过下标来区分.
             *    b. 在需要使用数组的元素的值的地方
             *       数组的名称[元素的下标]
             *       要取元素的值 直接在索引器中写上该元素的下标就可以了.
             *    c. 取值的时候,元素的下标仍然不能越界.
             *       
             * 
             * 10. 遍历:
             *     a. 使用for循环 将0到最大下标中的每1个整数遍历出来. 当做数组的下标取值.
             *        通过 数组名.Length 可以取到这个数组的长度.
             *        for(int i=0;i<arr.Length;i++)
             *        {
             *             arr[i];  把i当做数组的下标取值.
             *        }
             *         
             *     b.使用foreach遍历数组中的元素.
             *       1).语法:
             *       foreach(数据类型 变量 in 数组的名称)
             *       {
             *           这个变量直接就是数组每个元素的值.
             *       }
             *       2).执行步骤:
             *       将数组中的元素从第0个开始依次的赋值给迭代变量 赋值以后,执行循环体
             *       当把最后1个元素拿出来赋值给迭代变量并执行完循环体以后,foreach自动结束.
             *       3).使用foreach遍历数组的时候要注意的地方
             *          迭代变量的名称是可以随意的定义的.
             *          迭代变量的类型要和数组的元素的类型一致.
             *          in关键字是固定的.
             *          要遍历那1个数组,就把这个数组的名字写在in关键字后面.
             *          迭代变量的值 直接就是元素的值 而不是下标 所以直接使用迭代变量的值就可以了.
             *          
             *        4).foreach会将数组中的元素自动的从第0个遍历到最后1个.
             *           当遍历完成以后,循环自动结束.
             *       
             *    c. 使用for循环遍历数组 和 使用foreach遍历数组 他们的区别:
             *       a. for遍历出来的是下标,还要通过下标去取值.
             *          foreach遍历出来的直接就是数组的元素的值.
             *       b. for遍历的时候 可以 "挑三拣四"
             *          foreach必须 “从一而终”
             *       c. for循环可以更改遍历出来的元素的值.
             *          foreach无法更改遍历出来的元素的值.
             *       d. for循环可以拿到当前遍历出来的元素的其他元素.
             *          foreach只能拿到当前遍历出来的元素.其他的元素拿不到.
             *       
             *      foreach: 从头遍历到尾,只能取值不能改值.
             *      for: 可以挑三拣四,并且可以改值.
             *      
             *  11. 所有的数据类型都有对应的数组.
             *      long int short byte decimal double float stirng char bool 
             *      往数组中的元素存储值的时候 要保证存储的数据的类型和元素的类型一致.
             *     
             *   
             *  12. 声明数组,如果没有为数组的元素赋值,那么数组的元素是有默认值的.
             *      如果元素的类型是数值类型 那么默认是0
             *      如果元素是char类型的 那么默认值是'\0' 是'a'的转义
             *      如果元素是bool类型的,那么默认值是false.
             *      如果元素是string类型的,那么默认值是null
             *      
             *  
             * 13. 数组的初始化器: 允许我们在声明数组的同时为数组的元素赋值.
             *     a. int[] arr = new int[3] { 10, 20, 30 };
             *        大括弧中的元素的个数必须要和数组的长度一致.
             *        大括弧中的数据的类型要和元素的类型一致.
             *     b. int[] arr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80 };
             *        不指定数组的长度,让系统自动的根据大括弧中的元素的个数自动确定.
             *     c. int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80 };
             *        甚至我们可以连new都省略了 直接使用大括弧创建数组并为数组的元素赋值.
             * 
             * 14. 数组的长度可以为1个. 还可以为0个.
             *     如果数组的长度为0个,那么这个数组1个数据也存储不了 也就没有什么意义了.
             * 
             * 
             * 
             * 15. 关于数组
             *     a. 这玩意有什么用,什么时候用?
             *        当我们有多个数据,并且他们的类型一致的时候 我们就可以数组存储.
             *     b. 创建数组.
             *        元素的类型[] 数组的名称 =  new 元素的类型[数组的长度];
             *     c. 为数组的元素赋值
             *        通过索引器中传入1个下标就可以为指定的元素赋值
             *     d. 取值:
             *        通过索引器取值
             *     e. 遍历
             *        for foreach
             * 
             * 
             * 16.数组的最常用的N种算法
             *    a. 求整型数组中所有元素的累加和、平均值.
             *       arr.Sum() 得到数组中所有元素的累加和.
             *       arr.Average() 得到数组中的平均值 返回的是1个double
             *    b. 求整型数组中所有元素的最大值、最小值.
             *       arr.Max()得到数组中的最大值.
             *       arr.Min()得到数组中的最小值 
             *    c. 求指定的数在数组中第1次出现的下标.
             *       使用for循环挨个的遍历数组中的每1个元素,将遍历出来的元素的值和要找的值做相等比较
             *       如果相等 说明找到了 那么就把下标取出来就可以了. 
             *       Array.IndexOf(数组的名称,要找的数据);  直接返回要找的数据在数组中第一次出现的下标.
             *       如果没找到返回-1。
             *    d. 判断数组中是否包含指定的元素.
             *       数组的名称.Contains(数据)  就会判断数组中是否包含这个数据.
             *       返回bool类型.
             *     
             */

            int[] arr = { 10, 20, 30, 40, 50, 60, 30, 70, 12, 11 };
            bool b =  arr.Contains(310);
            Console.WriteLine(b);


            //int value = 20;
            //bool isFind = false;
            //foreach (int item in arr)
            //{
            //    if (item == value)
            //    {
            //        Console.WriteLine("找到了...");
            //        isFind = true;
            //        break;
            //    }
            //}
            //if (isFind == false)
            //{
            //    Console.WriteLine("没有找到..");
            //}


            //int[] arr = { 10, 20, 30, 40, 50, 60, 30, 70, 12, 11 };
            //int index = Array.IndexOf(arr, 30);
            //Console.WriteLine(index);

            //int value = 30;
            ////找到打印下标 没找到-1
            //bool isFind = false;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == value)
            //    {
            //        Console.WriteLine(i);
            //        isFind = true;
            //        break;
            //    }
            //}
            //if (isFind == false)
            //{
            //    Console.WriteLine("-1");
            //}




            //练习1：从一个整数数组中取出最大的整数
            //int[] arr = { 12, 11, 56, 78, 14, 90, 14 };
            //int min =  arr.Min();
            //Console.WriteLine(min); 
            ////int max = int.MinValue;
            //foreach (int item in arr)
            //{
            //    if (item > max)
            //    {
            //        max = item;                    
            //    }
            //}
            //Console.WriteLine(max);



            //练习2：计算一个整数数组的所有元素的和。
            //int[] arr = { 12, 11, 56, 78, 14, 90, 14 };
            //double avg = arr.Average();
            //Console.WriteLine(avg);
            //int sum = arr.Sum();
            //Console.WriteLine(sum / arr.Length);

            //int sum = 0; 
            //foreach (int i in arr)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);




            //练习3：将一个字符串数组输出为|分割的形式，比如“梅西|卡卡|郑大世”   ”梅西”   “卡卡”  “郑大世” 
            //string[] strs = { "梅西", "卡卡", "郑大世", "李铁" };
            ////把每1个元素都输出.并且在每1个元素的后面加上1个 |  但是最后1个不加
            //for (int i = 0; i < strs.Length; i++)
            //{
            //    if (i == strs.Length - 1)
            //    {
            //        Console.Write(strs[i]);
            //    }
            //    else
            //    {
            //        Console.Write(strs[i] + "|");
            //    }
            //}




            //练习4：将一个整数数组的每一个元素进行如下的处理：如果元素是正数则将这个位置的元素的值加1，如果元素是负数则将这个位置的元素的值减1,如果元素是0,则不变。

            //int[] arr = { 10, 20, -13, 0, 4, -98, 12 };
            //foreach (int i in arr)
            //{
            //    Console.Write(i + "\t");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0)
            //    {
            //        arr[i]++;
            //    }
            //    else if (arr[i] < 0)
            //    {
            //        arr[i]--;
            //    } 
            //}

            //foreach (int i in arr)
            //{
            //    Console.Write(i+"\t");
            //}














            //string[] strs = {"梅西","卡卡","郑大世" };  

            ////"梅西|卡卡|郑大世"  
            //int[] arr = { 10, 34, 12, 56, 78, 12, 56, 78, 13, 50 }; 
            //int value = 12; 
            //bool isFind = false;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == value)
            //    {
            //        Console.WriteLine(i);
            //        isFind = true;
            //        break;
            //    }
            //}
            //if (isFind==false)
            //{
            //    Console.WriteLine("没有找到..");
            //}



            //int min = int.MaxValue;
            //foreach (int item in arr)
            //{
            //    if (item < min)
            //    {
            //        min = item;
            //    }
            //}
            //Console.WriteLine(min);





            //int sum = 0;
            //foreach (int item in arr)
            //{
            //    sum += item;
            //}
            //Console.WriteLine(sum/arr.Length);



            //int[] arr = new int[0];
            //arr[0] = 10;
            //arr[1] = 11;
            //Console.ReadKey();


            //int[] arr = new int[3]; 
            //int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80 }; 
            //int[] arr = new int[3] { 10.1, 20, 30 };


            Console.ReadKey();

            //int[] arr = new int[3];
            //arr[0] = 12;
            //arr[2] = 13;
            //arr[1] = 19;





            //string[] arr = new string[3];

            //Console.WriteLine(arr[0]);

            //Console.ReadKey();


            //bool[] bs = new bool[3];
            //bs[0] = true;
            //bs[1] = false;
            //bs[2] = true;



            // long[] ls = new long[43];

            //byte[] ages = new byte[43];
            //ages[0] = 290;

            //int[] arr = new int[5];
            //arr[0] = 1;
            //arr[1] = 10;
            //arr[2] = 100;
            //arr[3] = 56;
            //arr[4] = 90;

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("****************************");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i != arr.Length - 1)
            //    {
            //        Console.WriteLine(arr[i + 1]);
            //        continue;
            //    }
            //    Console.WriteLine(arr[i]);
            //}
            //Console.ReadKey();

            //string[] strs = new string[3];
            //strs[0] = "jack";
            //strs[1] = "rose";
            //strs[2] = "Jim";

            //foreach (string str in strs)
            //{
            //    Console.WriteLine(str);
            //}










            //写1个程序,由用户输入班级的人数,然后分别接受每个人的成绩.存储起来.
            //输入成绩完毕以后, 因为考试的难度很大 所以为每1个不及格的分数加5分. 
            //打印整个成绩列表

            //Console.WriteLine("请输入班级的人数:");
            //int num = int.Parse(Console.ReadLine());
            //声明1个长度为num的数组 用来存储每个同学的成绩.
            //int[] score = new int[num];
            //循环接收用户输入每1个同学的成绩 并把成绩存储在数组中.
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine("请输入第{0}个同学的成绩:", i + 1);
            //    score[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //检查成绩  如果有不及格的成绩 给这个成绩+5.
            //for (int i = 0; i < score.Length; i++)
            //{
            //    if (score[i] < 60)
            //    {
            //        score[i] += 5;
            //    }
            //    Console.WriteLine(score[i]);

            //}





            //写1个程序,接收用户输入班级的每位同学的成绩.并将他们存储起来. 5
            //存储完毕以后,将不及格的成绩显示出来. 
            //int[] scores = new int[5];//声明1个数组 5个长度  来存储5个同学的成绩.  
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("请输入第{0}个同学的成绩:",i+1);
            //    scores[i] = int.Parse(Console.ReadLine()); 
            //} 
            //Console.WriteLine("不及格清单:"); 
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] < 60)
            //    {
            //        Console.WriteLine(scores[i]);
            //    }
            //}





            //int[] arr = new int[4];
            //arr[0] = 12;
            //arr[1] = 11;
            //arr[2] = 10;
            //arr[3] = 11; 
            //Console.WriteLine(arr.Length); 
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}








            //Console.WriteLine(arr[3]);

            //int i = 12; 
            //Console.WriteLine("哈哈哈哈哈哈哈.,我来了...");




            // int[] arr = new int[3]; 





            Console.ReadKey();






            ////我想要1个数组, 它可以存数5个数 这5个数都是int类型的数. 
            // //用1个数组 存储3个姓名.  

            //string[] names = new string[3];

            ////int[] arr = new int[5];




            //写1个程序,接收用户输入班级的每位同学的成绩.并将他们存储起来.
            //存储完毕以后,将不及格的成绩显示出来.

            //int s1, s2, s3, s4, s5;//存储5个同学的成绩. 
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("请输入第{0}个人的成绩", i);
            //    s1 = int.Parse(Console.ReadLine());
            //}


            Console.ReadKey();
        }
    }
}

