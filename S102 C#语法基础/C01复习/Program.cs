using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义3个变量,分别存储一个人的姓名(张三),年龄(28),和工资(7600.33).
            //然后在屏幕上显示,我叫XX,今天X岁了,我的工资是XX元.
            //string name = "张三";
            //byte age = 28;
            //decimal salary = 7600.33M;
            //Console.WriteLine("大家好,我叫" + name + ",今天" + age + "岁,我的工资是" + salary);


            //定义一个变量存储一个人的年龄(18),然后发现这个人的年龄不是18岁,
            //要把这个人的年龄修改成20岁(本题体会变量可以被重复多次赋值),最后把这个人的年龄输出到屏幕上?
            //byte age = 18;
            //age = 20;
            //Console.WriteLine("我的年龄是:"+age);



            //定义四个变量,分别存储一个人的姓名、性别、年龄、手机号码(13888888888)。然后打印在屏幕上
            //string name = "思发";
            //char gender = '女';
            //byte age = 18;
            //string phoneNum = "13888888888";
            //Console.WriteLine("大家好,我叫" + name + ",我的性别是" + gender + ",我的年龄是" + age + ",我的手机号码是" + phoneNum);



            //在屏幕上输出：我的手机是philips  型号:998   价格:1500元   重量:0.3kg
            //请定义变量存存储上面的值,并显示在屏幕上.

            //string brand = "nokia";
            //string model = "lumia800";
            //decimal price = 1500m;
            //double weight = 0.3;

            //Console.WriteLine("我的手机的品牌是:" + brand + ",型号是:" + model + ",价格是:" + price + ".重量是:" + weight + "Kg");
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(decimal.MaxValue);

            float d1 = 12.34f;
            float d = 5.6f;
            double res = d1 + d;

            Console.ReadKey();
        }
    }
}
