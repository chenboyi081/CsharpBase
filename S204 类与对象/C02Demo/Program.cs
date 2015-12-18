using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 类是引用类型的.
             *    
             *    字段是属于对象,而对象又在堆中,那么字段自然就应该和对象一起存储在堆空间中
             *    
             *    无论是什么类型的局部变量 这个局部变量都是始终开辟在栈空间中的.
             *    无论是什么类型的成员变量 这个成员变量始终都随着对象开辟在堆空间中.
             * 
             * 
             * 
             * 2. 值类型:
             *        所有的数值类型、bool、char、枚举、结构
             *    引用类型:
             *        数组  string  class
             *     
             *    局部变量:无论是值类型还是引用类型 变量始终开辟在栈中.
             *    成员变量:无论是值类型还是引用类型 变量始终跟随者对象一起开辟在堆中.
             *     
             *    值类型的真实的值 直接存储在这个值类型的变量中.
             *    引用类型的变量的对象存储在堆中,变量中存储的是对象在堆中的地址.
             *    
             * 
             *    变量之间相互赋值 都是将源变量中的值拷贝一份,将这个副本赋值给目标变量.
             *    引用类型的变量之间相互赋值:
             *        因为引用类型的变量中存储的是对象的地址,所以拷贝传递的是地址,赋值完成以后.对1个变量的修改会影响另外的1个变量的值.
             *    值类型的变量之间相互赋值:
             *        因为值类型的变量中存储的是真实的值,所以拷贝传递的是真实的值 赋值完成以后 堆1个变量的修改不会影响另外的1个变量的值.
             *        
             * 
             * 3. 只要看到了new关键字,就表示重新的创建了1个对象.
             *    
             * 4. 在成员方法中访问字段. 方法属于哪1个对象,那么访问的字段就是属于哪1个对象的.
             *    
             * 
             * 5. 类是一种自定义的数据类型,那么我们自然就可以将其当做方法的参数.
             *    
             * 
             * 
             * 
             */


            //Student s1 = new Student();
            //s1.name = "小明";
            //s1.age = 19;
            //s1.gender = true;
            //s1._Chinese = 98;
            //s1._English = 99;
            //s1.math = 30;
            //s1.SayHi();
            //s1.ShowScore();



            //Student s2 = new Student();
            //s2.name = "星星";
            //s2.age = 12;
            //s2.gender = true;

            //s2._Chinese = 99;
            //s2._English = 20;
            //s2.math = 100;

            //s2.SayHi();
            //s2.ShowScore();





            //Person p1 = new Person();
            //p1.name = "桑冰星";
            //p1.gender = false;
            //p1.age = 19; 

            //p1.SayHi();

            //Person p2 = new Person();
            //p2.name = "铁锤妹妹";
            //p2.age = 31;
            //p2.gender = false;
            //p2.SayHi();



            //Person p1 = new Person();
            //p1.name = "jack"; 
            //Person p2 = p1;
            //p2 = new Person();
            //p2.name = "rose"; 
            //Console.WriteLine(p1.name); 


            //Person p1 = new Person();
            //p1.name = "jack";
            //TestPerson(p1);
            //Console.WriteLine(p1.name);


            Person p = ReturnPerson("rose", 19, false);

            Console.ReadKey();
        }


        public static Person ReturnPerson(string name, int age, bool gender)
        {
            Person p = new Person();
            p.name = name;
            p.age = age;
            p.gender = gender;
            return p;
        }



        public static void TestPerson(Person p)
        {
            p.name = "rose";
        }

    }
}

