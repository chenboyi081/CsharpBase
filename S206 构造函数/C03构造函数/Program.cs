using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 对象初始化器
             *    允许在创建对象的同时就为对象的属性赋值.
             *    在大括弧中,轻敲空格键 会提示可以为这个对象赋值的属性,每1个赋值表达式用逗号分开.
             *    
             * 2. 对象的初始化器不能起到强制的效果.
             *    创建对象的人可以用初始化器为属性赋值 也可以 不用.
             *    就算用也不一定要每1个属性赋值.
             * 
             * 
             * 3. 创建对象的时候,new后面的小括弧是个什么意思?
             *    a. 改变运算的优先级.
             *    b. 定义方法
             *    c. 调用方法的时候.
             *    
             *    小括弧是在调用方法 ---> 构造方法
             *    
             *   
             */

            Person p1 = new Person("jack",19,"男");



            //Dog wangCai = new Dog();


            //Student s1 = new Student("小明", 19, "男", 90, 100, 67);

            //Student s2 = new Student("小花花",18);
            //Person p1 = new Person("jack", 19, "男");



            //  p1.SayHi();



            Console.ReadKey();
        }
    }
}
