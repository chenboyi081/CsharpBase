using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C04保护字段
{
    class Student
    {
        string name;

        private int age;

        public void SetAge(int age)
        {
            if (age >= 0 && age <= 100)
            {
                this.age = age;
            }
            else
            {
                this.age = 19;
            }
          
        } 



        ///// <summary>
        ///// 为age字段赋值
        ///// </summary>
        ///// <param name="value"></param>
        //public void SetAge(int value)
        //{
        //    age = value >= 0 && value <= 100 ? value : 19;
        //}

        //public int GetAge()
        //{
        //    return age;
        //}


        //private int _English;
        //private int _Chinese;
        //private int math;


        //public void SetEnglish(int value)
        //{
        //    _English = value >= 0 && value <= 100 ? value : 10;
        //}
        //public int GetEnglish()
        //{
        //    return _English;
        //}



    }
}
