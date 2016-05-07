using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03结构体
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string  Gender { get; set; }

        public void SayHi()
        {
            Console.WriteLine("hello.");
        }
    }
}
