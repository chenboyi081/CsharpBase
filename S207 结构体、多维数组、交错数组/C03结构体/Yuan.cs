using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03结构体
{
    struct Yuan
    {

        //public int Age { get; set; }

        public double r; 
        public Yuan(double r)
        {
            this.r = r;
            //this.Age = 12;
        } 
        public double GetZhouChang()
        {
            return 2 * Math.PI * r;
        } 
        public double GetArea()
        {
            return Math.PI * r * r;
        }
    }
}
