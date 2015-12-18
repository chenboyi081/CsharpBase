using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02练习
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 在类的内部,我们可以直接访问字段也可以访问属性而得到字段.
             *    
             *    取值: 如果通过属性取值和直接取字段的值,取到的是一样的. 那么建议直接访问字段,因为这样效率会高1点.
             *          但是如果取到的值不一样,那就要看我们希望得到那1个值,如果我们希望得到本来的值那么就直接访问字段
             *          如果我们希望得到经过属性处理以后的值 那么就取属性的值.
             *          
             *    赋值:  属性没有在赋值的时候做任何逻辑验证.这个时候为字段赋值和为属性赋值的效果都是相同的.
             *           那么这个时候建议直接为字段赋值.效率比较高.
             *           但是如果属性在赋值的时候做了逻辑验证.如果在类的内部希望躲过逻辑验证.那么这个时候就为字段赋值.
             *           如果希望我们的值也要经过验证 那么为属性赋值.
             *    
             * 
             * 
             */


            Television t1 = new Television();
            t1.TurnOn();
            for (int i = 0; i < 20; i++)
            { 
                t1.UpVol();
            }
            for (int i = 0; i < 25; i++)
            {
                t1.DownVol();
            }
            t1.ChangeChannel("CCTV-5"); 
            t1.TurnOff();
           

            //Student s1 = new Student();
            //s1.PhoneNumber = "13989891111";
            //s1.Age = 19;
            //s1.Name = "小明";
            //s1.Gender = "男";

            //s1.SayHello();




            Console.ReadKey();
        }



    }
}
