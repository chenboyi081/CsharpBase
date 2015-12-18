using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C07常量与只读字段
{
    class Person
    {
       
        public readonly string name;


        public Person()
        {
           
        }



        public void Test()
        {
         
            Console.WriteLine(name);
            
        }




        public int Age { get; set; }  
        private Dog wangCai = new Dog();
        public Dog WangCai
        {
            get { return wangCai; }
            set { wangCai = value; }
        }

    }
}
