using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C04Break
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. break是跳出当前所在的循环.
             *    
             * 
             * 
             */ 



            int i = 0;
            while (i < 10)
            {

                int j = 0;
                while (j < 10)
                {
                    if (j == 5)
                    {
                        break;
                    }
                    j++;
                }
                break;
                i++;
            }



            Console.ReadKey();
        }
    }
}
