using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C01类与对象
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 类: 是对一群具有相同特征和功能的事物的统称,是抽象的,不能直接使用.
             *    对象:对象是现实生活中的具体存在,看得见摸得着 可以直接拿来使用.
             *    类与对象的关系:类是模板,对象是根据这个模板创建出来的,模板上有什么那么对象上面就有什么,多不得也少不得.
             *    
             *  
             * 2. 定义类
             *    a. 语法
             *       class 类名
             *       {
             *          
             *       }
             *    b. 位置
             *       命名空间的下面,强制规定 1个类独占1个源文件.
             * 
             * 3.类的成员
             *    成员变量: 这类事物的共同的特征. 字段 成员字段
             *    方法:将这类事物共同拥有的行为定义为方法 成员方法
             * 4. 类的名字的规范:有意义&每个单词的首字母大写&是个名词
             * 
             * 5. 因为类是抽象的,所以类是不能直接使用的,如果非要使用.
             *    必须要找到这个类中的1个具体的存在.
             *    
             *    创建类的对象---> 实例化
             *    语法:
             *    类名 对象名 = new 类名();
             * 
             * 6. Person p1 = new Person();
             *    a. Person是我们自定义的数据类型.
             *    b. p1是1个变量,这个变量的类型是Person类型的.
             *    c. new Person()是1个表达式. new 是1个运算符
             *       new运算符做的事情.
             *       1).
             *       
             * 
             * 7. 创建对象中的分配
             * 8. 类的成员访问修饰符
             *    public: 
             *    private:
             *    默认访问修饰符 private
             * 
             * 9. 访问对象的成员.
             *    a.  每1个对象都有独自的成员.
             *    b.  同1个类的多个对象之间毫无关系.唯一的关系就是他们是根据同1个类模板创建出来的.
             *        他们都具有相同的成员.
             *    c.  通过 对象名.成员 来访问.
             *    d.  为对象的字段赋值.
             * 
             * 10.命名空间
             *    
             * 11.类是自定义的数据类型. 那么我们可以把它当做方法的参数和返回值.
             * 
             */


            Person p1 = new Person();
            p1.age = 12;
            p1.age = 12;
            Console.WriteLine(p1.age); 
            p1.SayHi();

            Person p2 = new Person();
            Person p = Test();


            Console.ReadKey();
        }

        public static Person Test()
        {
            Person p = new Person();
            return p;
        }


    }
}
