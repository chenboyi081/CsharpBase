using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C01Review
{
    /// <summary>
    /// 票类
    /// </summary>
    class Ticket
    {
        public string ShiFa { get; set; }
        public string ZhongDian { get; set; }


        /// <summary>
        /// 距离属性
        /// </summary>
        private int distance; 
        public int Distance
        {
            get { return distance; } 
        }
        
        /// <summary>
        /// 价格属性
        /// </summary>
        private decimal price; 
        public decimal Price
        {
            get { return price; } 
        }



        /// <summary>
        /// 构造函数 初始化距离属性
        /// </summary>
        /// <param name="distance"></param>
        public Ticket(int distance)
        {
            //判断传入的距离 是否是负数.
            if (distance < 0)
            {
                this.distance = 0;
            }
            else
            {
                this.distance = distance;
            }
            //根据距离计算价格并赋值. 
        }

        public Ticket(string shiFa, string zhongDian, int distance)
            : this(distance)
        {
            this.ShiFa = shiFa;
            this.ZhongDian = zhongDian;
        }



        /// <summary>
        /// 根据距离计算价格
        /// </summary>
        private void SetPrice()
        {
             //0-100公里        票价不打折
            //101-200公里    总额打9.5折
            //201-300公里    总额打9折
            //300公里以上    总额打8折
            if (distance <= 100)
            {
                this.price = distance;
            }
            else if (distance <= 200)
            {
                this.price = distance*0.95m;
            }
            else if (distance <= 300)
            {
                this.price = distance * 0.9m;
            }
            else
            {
                this.price = distance * 0.8m;
            } 
        }

        public void Show()
        {
            SetPrice();
            Console.WriteLine("***********************");
            Console.WriteLine("*始发站:{0}   终点站:{1}*",this.ShiFa,this.ZhongDian);
            Console.WriteLine("*里程:{0}***************",distance);
            Console.WriteLine("*价格:{0}******************",price);
            Console.WriteLine("***********************");
        }

    }
}
