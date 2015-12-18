using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02Demo
{
    /// <summary>
    /// 学生类
    /// </summary>
    class Student
    {
        /// <summary>
        /// 姓名字段
        /// </summary>
        public string name;

        /// <summary>
        /// 年龄字段
        /// </summary>
        public int age;

        /// <summary>
        /// 性别字段
        /// </summary>
        public bool gender;

        /// <summary>
        /// 语文成绩字段
        /// </summary>
        public int _Chinese;

        /// <summary>
        /// 数学成绩字段
        /// </summary>
        public int math;

        /// <summary>
        /// 英语成绩字段
        /// </summary>
        public int _English;


        /// <summary>
        /// 打招呼的方法
        /// </summary>
        public void SayHi()
        { 

            Console.WriteLine("大家好,我叫{0},我今年{1}岁,我是{2}的",
                name,
                age,
                gender ? '男' : '女'
                );
        }

        /// <summary>
        /// 显示成绩的方法.
        /// </summary>
        public void ShowScore()
        {
            int totalScore = _Chinese + math + _English;
            int avg = totalScore / 3;
            Console.WriteLine("大家好,我叫{0},我的总成绩为{1},平均成绩为{2}", name, totalScore, avg);
        }

    }
}
