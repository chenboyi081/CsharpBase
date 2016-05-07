using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03结构体
{
    class Program
    {
        static void Main(string[] args)
        {

            Yuan y = new Yuan(12.56);
            Console.WriteLine(y.GetZhouChang());
            Console.WriteLine(y.GetArea());

        //    Point p1 = new Point(20,10);
        //    p1.p.Name = "jack";
        //    Point p2 = p1;
        //    p2.p.Name = "rose";
        //    Console.WriteLine(p1.p.Name);
             
            //Point p2 = new Point(10,20);
            //Point p3 = p2;
            //p3.x = 100;
            //Console.WriteLine(p2.x);

            Console.ReadKey();
        }
    }
}
