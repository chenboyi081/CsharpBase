using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C04保护字段
{
    class Person
    {
        private string name; //保护name字段, 赋值的时候要求 长度必须大于等于2  不能为毛泽东 习近平
        //“无名”

        //如果不符合要求  就为name字段赋默认值
        public void SetName(string value)
        {
            if (value.Length < 2 || value == "毛泽东" || value == "习近平")
            {
                name = "无名";
            }
            else
            {
                name = value;
            } 
        }

        /// <summary>
        /// 这个方法返回给调用者 当前对象的name字段的值。
        /// </summary>
        public string GetName()
        {
            return name;
        }




        private int age;

        /// <summary>
        /// 得到age字段的值.
        /// </summary>
        /// <returns></returns>
        public int GetAge()
        {
            return age;
        }

        /// <summary>
        /// 这个方法专门为age字段赋值
        /// </summary>
        public void SetAge(int value)
        {
            if (value >= 0 && value <= 100)
            {
                age = value;
            }
            else
            {
                //默认处理.
                age = 18;
            }
        }



        public void SayHi()
        {
            age = 1900000;
            Console.WriteLine("大家好,我叫{0},我今年{1}岁", name, age);
        }
    }
}
