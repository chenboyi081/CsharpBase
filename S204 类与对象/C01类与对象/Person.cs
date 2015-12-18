using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C01类与对象
{
 
     
    class Person
    {
        public string name;
        public int age;
        public bool gender;

        public void Run()
        {
            name = "jack";
            age = 18;
            gender = true;
            Console.WriteLine("我在跑");
        }

        public void Sing()
        {
            Console.WriteLine("啦啦啦啦啦..");
        }

    }
}
