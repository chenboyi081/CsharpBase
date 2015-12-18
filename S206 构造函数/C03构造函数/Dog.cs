using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03构造函数
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Dog() { }
        public Dog(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
