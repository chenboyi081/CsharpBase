using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02猜拳游戏
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 猜拳游戏:
             *  人机大战.  玩家自己选择1个拳头, 计算机随机的出1个拳头 
             *  
             *  玩家类:
             *     姓名属性.
             *     出拳的方法()
             *        自己选择1个拳头 出拳.
             *  计算机类:
             *     姓名属性.
             *     出拳的方法()
             *        随机的出1个拳头.
             *        
             *  裁判:
             *    裁决的方法() 这个方法根据玩家和计算机出的拳头来判断谁赢谁输.
             * 
             * 
             * 
             */
            Player player = new Player("桑冰星");
            Computer c1 = new Computer("深蓝");
            Judge j1 = new Judge("肖泽武");
            while (true)
            { 
                int p1 = player.ShowFist(); 
                int p2 = c1.ShowFist();
                j1.PanJue(p1, p2);
                Console.WriteLine("再来一盘? y/n");
                if (Console.ReadLine() != "y")
                {
                    break;
                }
            }
            Console.ReadKey();


        }
    }
}
