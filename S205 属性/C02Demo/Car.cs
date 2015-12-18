using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02Demo
{
    class Car
    {
        // 轮子数量 颜色 价格 型号 座位数量 字段,
        public int wheelNum;
        public string color;
        public decimal price;
        public string model;
        public int seatNum;
        public string brand;

        public void Run()
        {
            Console.WriteLine("我在行驶...");
        }

        public void Stop()
        {
            Console.WriteLine("我停止了");
        }

        //还有1个自己介绍自己的方法(显示自己的品牌 轮子 颜色 价格 型号 座位。。信息.);

        public void SayHi()
        {
            Console.WriteLine("大家好,我是1个{0}汽车,型号是{1},颜色是{2},价格是{3},轮子有{4}个,座位有{5}个",
                brand,
                model,
                color,
                price,
                wheelNum,
                seatNum
                );
        }

    }
}
