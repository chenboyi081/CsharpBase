using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C05属性
{
    class Program
    {
        static void Main(string[] args)
        {
             
            //Person p = new Person(); 
            //p.Age = 29;
            //Console.WriteLine(p.Age);

            Student s1 = new Student();
            //s1.Name = "jack";


            s1.Gender = "男";
            Console.WriteLine(s1.Gender);

            //Person p1 = new Person();
            //p1.Age = 29;
            //Console.WriteLine(p1.Age);



            //Person p1 = new Person();
            //p1.Name = "jack";
            //Console.WriteLine(p1.Name);


            Console.ReadKey();
        }
    }
}
