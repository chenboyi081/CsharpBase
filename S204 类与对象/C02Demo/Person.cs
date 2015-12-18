using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02Demo
{
    class Person
    {
        public string name;
        public int age;
        public bool gender;

        /// <summary>
        /// 打招呼的方法
        /// </summary>
        public void SayHi()
        {
            Console.WriteLine("大家好,我叫{0},我今年{1}岁,我是{2}的", name, age, gender ? "男" : "女");
        }

        
        public void Run()
        {
            Console.WriteLine("我在跑");
        }


        public void Sing()
        {
            Console.WriteLine("啦啦啦啦啦..");
        }

    }
}
