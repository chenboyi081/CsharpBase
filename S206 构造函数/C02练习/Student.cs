using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02练习
{
    class Student
    {
        // ,有姓名、年龄、手机号码、学号四个属性,要求学生的姓名不能为空串,并且长度不能下于2，
        //否则使其默认值为”无名”, 年龄只能在0-100之间,否则默认值为18，手机号码只能为11位的数字。
        //学号要求为10个数字，否则赋值为默认值”0000000000”.再定义1个方法介绍自己,将自己的姓名年
        //龄手机号码打印出来。

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                this.name = value.Length < 2 ? "无名" : value;
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { this.age = value >= 0 && value <= 100 ? value : 18; }
        }


        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                //判断是不是11位
                if (value.Length != 11)
                {
                    this.phoneNumber = "13888888888";
                    return;
                }
                //再判断是不是都是数子.
                try
                {
                    long num = long.Parse(value);
                    this.phoneNumber = value;
                }
                catch
                {
                    this.phoneNumber = "13888888888";
                }

            }
        }

        private string stuNo;
        public string StuNo
        {
            get { return stuNo; }
            set
            {
                //判断是不是11位
                if (value.Length != 10)
                {
                    this.stuNo = "0000000000";
                    return;
                }
                //再判断是不是都是数子.
                try
                {
                    long num = long.Parse(value);
                    this.stuNo = value;
                }
                catch
                {
                    this.stuNo = "0000000000";
                }
            }
        }


        private bool gender; 
        public string Gender
        {
            get { return gender?"男":"女"; }
            set { gender = value=="男"?true:false; }
        }


        public void SayHello()
        {
            Console.WriteLine("大家好,我叫{0},我今年{1}岁,我的电话号码是{2},我的学号是{3},我的性别是{4}",
                this.name,this.age,this.phoneNumber,this.stuNo,this.Gender
                );
        }

    }
}
