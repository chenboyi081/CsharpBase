using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C06值类型与引用类型
{
    /// <summary>
    /// 圈圈类.
    /// </summary>
    class QuanQuan
    {
        public int Size { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

        public QuanQuan(int size,string color,decimal price)
        {
            this.Size = size;
            this.Color = color;
            this.Price = price;
        }
    }
}
