using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C01Review
{
    class Person
    {
        public int Age { get; set; }


        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value.Length < 2 ? "无名" : value;
            }
        }
         



    }
}
