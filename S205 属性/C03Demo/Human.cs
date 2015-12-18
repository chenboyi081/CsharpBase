using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03Demo
{
    /// <summary>
    /// 人类
    /// </summary>
    class Human
    {
        public int power = 100;

        /// <summary>
        /// 人开门的方法 人触发门的开的行为
        /// </summary>
        public void OpenDoor(Door d)
        {
            power -= 10;
            d.Open();

        }


    }
}
