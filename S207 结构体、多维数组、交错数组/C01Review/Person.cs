using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C01Review
{
    class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        //代表当前Person对象所面朝的方向
        public Direction dir;



         
        public Person(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }
        public Person(string name, int age,double weight)
            :this(name,age)
        { 
            this.Weight = weight;
        }

        public Person()
        {
            Console.WriteLine("无参数的构造函数");
        }


    }
}
