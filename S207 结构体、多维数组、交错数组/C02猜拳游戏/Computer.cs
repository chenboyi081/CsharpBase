using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02猜拳游戏
{
    /// <summary>
    /// 计算机类
    /// </summary>
    class Computer
    {
        public string Name { get; set; }
        public Computer(string name)
        {
            this.Name = name;
            this.random = new Random();
        }

        private Random random;


        /// <summary>
        /// 计算机出拳的方法
        /// </summary>
        public int ShowFist()
        {
            //1. 随机的产生1个  1-3 的随机数.
            int comSelect = this.random.Next(1, 4);
            //2. 显示计算机随机出的拳头. 
            Console.WriteLine("计算机{0}出了1个{1}", this.Name, this.IntToFist(comSelect));
            return comSelect;
        }


        /// <summary>
        /// 将整型的数转换为其所对应的拳头类型
        /// </summary>
        /// <param name="userSelect"></param>
        /// <returns></returns>
        private string IntToFist(int userSelect)
        {
            switch (userSelect)
            {
                case 1:
                    return "剪刀";
                case 2:
                    return "石头";
                case 3:
                    return "布";

            }
            return "";
        }
    }
}
