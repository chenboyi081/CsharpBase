using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C07常量与只读字段
{
    class Student
    {
        private string name = "jack";
        private int age = 19;
        private bool gender = true; 
        private string stuNo = "itcast001"; 

        public Student()
        {
          
        } 

        public Student(string name)
        { 
            Console.WriteLine("哈哈哈哈哈哈哈哈哈哈..");
        } 

        public void SayHi()
        {
            Console.WriteLine("大家好,我叫{0},我今年{1}岁了",this.name,this.age);
        }
    }
}
