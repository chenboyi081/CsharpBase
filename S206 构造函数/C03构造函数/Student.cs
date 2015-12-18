using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03构造函数
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }   
        private bool gender;
        public string Gender
        {
            get { return gender ? "男" : "女"; }
            set { gender = value == "男" ? true : false; }
        }
        public int English { get; set; }
        public int Chinese { get; set; }
        public int Math { get; set; }

        public Student(string name,int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
         
        public Student(string name,int age,string gender,int _Chinese,int _English,int math)
            :this(name,age,gender)
        { 
            this.English = _English;
            this.Chinese = _Chinese;
            this.Math = math;
        }

        


    }
}
