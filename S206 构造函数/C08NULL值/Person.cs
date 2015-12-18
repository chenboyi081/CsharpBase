using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C08NULL值
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Dog wangCai;



        public void SayHi()
        {
            Console.WriteLine("hello");
        }


    }
}
