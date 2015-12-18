using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C05属性
{
    class Student
    {
        private string name; 
        public string Name
        {
            get
            {
                return this.name;
            } 
            set
            {
                if (value.Length < 2)
                {
                    this.name = "狗蛋";
                }
                else
                {
                    this.name = value;//"jack"
                }
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value >= 0 && value <= 100 ? value : 19;
            } 
        }


        private bool gender; 
        public string Gender
        {
            get
            {
                return this.gender ? "男" : "女";
            }
            set
            {
                this.gender = value == "男" ? true : false;
            }
        }


        private int _Chinese;
        public int Chinese
        {
            get
            {
                return this._Chinese;
            }
            set
            {
                this._Chinese = value >= 0 && value <= 100 ? value : 10;
            }
        }

    }
}
