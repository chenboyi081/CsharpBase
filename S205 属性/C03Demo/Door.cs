using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03Demo
{
    /// <summary>
    /// 门类
    /// </summary>
    class Door
    {

        public int menZhouJiaoDu = 0;


        /// <summary>
        /// 门开的方法
        /// </summary>
        public void Open()
        {
            menZhouJiaoDu = 90;
            Console.WriteLine("门开了....");
        }


    }
}
