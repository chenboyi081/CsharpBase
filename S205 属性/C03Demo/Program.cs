using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 类的成员的名称不能和类的名称相同
             * 
             * 2. 在类的下面,只能定义字段(定义的同时可以为字段赋值)和方法.其他的执行代码只能写在方法中.
             *    cw("") 像这样的代码不能直接写在类的下面,要写在方法中,当方法被调用的时候就会执行.
             *    
             *    声明字段的同时可以为字段赋值,但是声明完了以后,不能直接在类下面为字段赋值.
             *    class Person
             *    {
             *       string name="jack";
             *    }
             *    下面这样是不行的
             *    class Person
             *    {
             *      string name;
             *      name="jack";  因为这是执行代码 CPU执行才会有效果 那如果可以的话 CPU什么时候执行呢?
             *    }
             *    
             *   
             *    
             * 3. 类是1个数据类型 所有的数据类型都有对应的数组.
             *    类 也可以有数组.
             *    
             *    数组中的元素本质上是1个普通类型的变量.
             *    int[] arr = new int[3];
             *    有3个元素 其实这3个元素 是 3个int类型的变量.
             *    
             *    Person[] ps = new Person[3];
             *    有3个元素 这3个元素 其实就是 3个Person类型的变量.
             *    
             *    数组元素的默认值:
             *     如果元素的类型是值类型: 0
             *     如果元素的额类型是引用类型:null
             * 
             * 
             * 4. 如何使用面向对象的思维来解决问题.
             *    经验:
             *    初学者如何用面向对象的思维解决问题:  名词提炼法.
             *    
             *    根据需求.分析业务流程. 找出流程中出现的名词. 将这些名词定义为类.然后再分析每1个类中应该有哪些成员.
             *    
             *    eg: 请使用面向对象模拟人开门的过程.
             *    名词: 人  门
             *    分析类中的成员.
             *    
             *    功能是属于谁的?就要看谁最熟悉这个功能的执行.
             *    
             *    
             *    
             *    eg:请你使用面向对象的思维写1个计算器程序. 这个计算器可以计算两个数的加减乘除.
             *       计算器:
             *       
             * 
             * 
             * 
             */
             
            //Cal c1 = new Cal();
            //c1.num1 = 12;
            //c1.num2 = 10;
            //int ji =  c1.GetJi();
            //Console.WriteLine(c1.GetHe());
            //Console.WriteLine(c1.GetCha());
            //Console.WriteLine(c1.GetJi());
            //Console.WriteLine(c1.GetShang());
            //Console.ReadKey();




            //Human h1 = new Human();
            //Door d = new Door(); 
            //h1.OpenDoor(d);





            //Person[] ps = new Person[3];
            //ps[0] = new Person();
            //ps[1] = new Person();
            //ps[2] = new Person();



            //ps[0].name = "jack";
            //ps[0].age = 10;
            //ps[0].SayHi();
 




            Console.ReadKey();
        }
    }
}
