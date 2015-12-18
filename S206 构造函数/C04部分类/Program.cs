using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C04部分类
{
    partial class Person
    {
        private string name; 
    }

    partial class Person
    {
        private int age;

        public void Test()
        {
            this.age = 12;
            this.name = "jack";
        }
    } 
   

    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 在同1个命名空间中.不允许定义多个名字相同的类
             *    但是如果这些类都被partial关键字修饰,这样是可以的.
             *    
             *    这些被partial修饰的同名称的类型其实是1个类. 我们就把这些类叫做部分类(伙伴类)
             *    所以我们可以在1个部分类中去访问另外的1个部分类中的成员.因为他们本来就是1个类.
             *    
             * 2. 构成部分类的条件
             *    a. 在同1个命名空间中.
             *    b. 这些类都是同1个名字.
             *    c. 都被partial关键字修饰.
             * 
             * 3. 部分类的好处.
             *    将描述类的成员 分类 隔开 方便后期的维护以及管理.
             *    
             * 
             */

            Person p = new Person();

            Console.ReadKey();
        }
    }
}
