using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02猜拳游戏
{
    /// <summary>
    /// 裁判类
    /// </summary>
    class Judge
    {
        public string Name { get; set; }
        public Judge(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// 根据玩家对象和计算机对象各自出的拳头来判断输赢
        /// </summary>
        /// <param name="p1">玩家出的拳头</param>
        /// <param name="p2">计算机出的拳头</param>
        public void PanJue(int p1, int p2)
        {
            //1 剪刀 2石头 3布.
            // 1   3   -2
            // 2   1    1
            // 3   2    1
            if (p1 - p2 == -2 || p1 - p2 == 1)
            {
                Console.WriteLine("裁判{0}判决:玩家胜利.",this.Name);
            }
            else if (p1 == p2)
            {
                Console.WriteLine("裁判{0}判决:平局.", this.Name);
            }
            else
            {
                Console.WriteLine("裁判{0}判决:计算机胜利.", this.Name);
            }

        }


    }
}
