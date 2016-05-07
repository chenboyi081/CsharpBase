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
            /* 1. 构造函数.
             *    a.语法
             *    访问访问修饰一般情况下是public
             *    没有返回值,并且连void都不要写.
             *    名称与所在的类名一致.
             * 
             *    b.构造函数的执行时机
             *    在创建对象的时候,由new关键字自动调用.
             *    
             *    c.在创建对象的时候,要求必须调用构造函数
             *    d.构造函数可以带参数和重载的.
             *    e.构造函数的作用
             *      一般情况下用来强制初始化对象的属性.
             *    f.隐式的构造函数.
             *    g.构造函数之间的相互调用.
             *       
             * 2. 部分类.
             * 3. null值
             * 4. const与readonly
             * 5. 枚举
             *    a. 什么时候使用枚举./
             *    b. 定义
             *    c. 使用.
             *    d. 整型的数
             *     
             * 
             * 6. 枚举是1个值类型.
             * 
             */


            //Direction dir = Direction.East;
            //Direction newDir = dir;
            //newDir = Direction.West;
            //Console.WriteLine(dir);


            //Person p = new Person();


            //写一个Ticket类,有一个距离属性(本属性只读,在构造方法中赋值),不能为负数,有一个价格属性,价格属性只读,并且根据距离计算价格(1元/公里):
            //0-100公里        票价不打折
            //101-200公里    总额打9.5折
            //201-300公里    总额打9折
            //300公里以上    总额打8折
            //有一个方法,可以显示这张票的信息.
            //测试上面的类.


            Ticket t1 = new Ticket("北京", "广州", 1900); 
            t1.Show();
            t1.Show();
            t1.Show();
            t1.Show();
            t1.Show();
            //Person p = new Person("jack", 19, 78);
            //Dog d = new Dog();
            Console.ReadKey();
        }
    }
}
