using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02Demo
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Car benz = new Car();
        //    benz.brand = "奔驰";
        //    benz.model = "S600";
        //    benz.color = "黑色";
        //    benz.wheelNum = 4;
        //    benz.seatNum = 5;
        //    benz.price = 1200000m; 
        //    benz.Run();
        //    benz.Stop();
        //    benz.SayHi();


            Team t1 = new Team();
            t1.teamName = "中国足球队";
            t1.winNum = 1;
            t1.loseNum = 99;
            t1.jiaoLianNum = 10;
            t1.qiuYuanNum = 25;


            t1.SayHi();


            Console.ReadKey();

        }
    }
}

