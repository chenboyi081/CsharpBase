using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C06值类型与引用类型
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public QuanQuan gouQuan = new QuanQuan(19, "土豪金", 13); 

    }
}
