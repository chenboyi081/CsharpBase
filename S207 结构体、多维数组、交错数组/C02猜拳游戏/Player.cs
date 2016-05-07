using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02猜拳游戏
{
    /// <summary>
    /// 玩家类
    /// </summary>
    class Player
    {
        /// <summary>
        /// 姓名属性
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 构造函数 用于初始化当前对象的姓名属性
        /// </summary>
        /// <param name="name">玩家对象的姓名</param>
        public Player(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// 玩家出拳的方法
        /// </summary>
        public int ShowFist()
        {
            //1. 提示用户要出什么拳头
            Console.WriteLine("亲爱的玩家:{0}你要出什么拳头呢? 1.剪刀 2.石头 3.布", this.Name);
            //2. 接收用户的选择
            int userSelect = this.ReadInt(1, 3);
            //3. 显示用户出了什么拳头
            Console.WriteLine("玩家{0}出了1个{1}",this.Name,this.IntToFist(userSelect));
            return userSelect;
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



        /// <summary>
        /// 从控制台读取指定范围的整数
        /// </summary>
        /// <param name="min">最小界</param>
        /// <param name="max">最大界</param>
        /// <returns></returns>
        private int ReadInt(int min, int max)
        {
            while (true)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num >= min && num <= max)
                    {
                        return num;
                    }
                    Console.WriteLine("请输入{0}-{1}范围的整型的数:", min, max);
                }
                catch
                {
                    Console.WriteLine("请输入1个整数:");
                }
            }
        }



    }
}
