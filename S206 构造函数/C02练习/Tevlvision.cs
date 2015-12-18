using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02练习
{
    /// <summary>
    /// 电视机类
    /// </summary>
    class Television
    {
        //当前正在播放的频道.
        private string currentChannel = "CCTV-1";
        //当前电视机的音量
        private int vol = 50;
        //电视机的开关机标识
        private bool isOn = false;

        /// <summary>
        ///  电视机开机的方法
        /// </summary>
        public void TurnOn()
        {
            if (this.isOn == false)
            {
                Console.WriteLine("电视机打开了...");
                //改变isOn的值 为true 表示当前电视机对象已经打开了.
                this.isOn = true;
            }
            else
            {
                Console.WriteLine("有病啊,电视机本来就打开的啊..");
            }
        }


        /// <summary>
        /// 电视机关机的方法
        /// </summary>
        public void TurnOff()
        {
            if (this.isOn == true)
            {
                Console.WriteLine("电视机关闭成功...");
                isOn = false;
                return;
            }
            Console.WriteLine("有病啊,电视机本来就是关着的..");
        }

        /// <summary>
        /// 增加音量的方法
        /// </summary>
        public void UpVol()
        {
            //判断当前电视机是否是开机状态
            if (this.isOn == false)
            {
                Console.WriteLine("电视机关闭,无法修改音量");
                return;
            }
            //再次判断音量是否已经到100了.
            if (this.vol >= 100)
            {
                Console.WriteLine("音量已经是最大的了,不能再加了.");
                return;
            }
            //改变音量
            this.vol += 5;
            //显示新的音量
            Console.WriteLine("当前音量:" + this.vol);
        }

        /// <summary>
        /// 减小音量
        /// </summary>
        public void DownVol()
        {
            //判断当前电视机是否是开机状态
            if (this.isOn == false)
            {
                Console.WriteLine("电视机关闭,无法修改音量");
                return;
            }
            //再次判断音量是否已经到100了.
            if (this.vol <= 0)
            {
                Console.WriteLine("音量已经是最小的了,不能再减了.");
                return;
            }
            //改变音量
            this.vol -= 5;
            //显示新的音量
            Console.WriteLine("当前音量:" + this.vol);
        }


        /// <summary>
        /// 换频道的方法
        /// </summary>
        public void ChangeChannel(string channel)
        {
            //判断当前电视机是否是开机状态
            if (this.isOn == false)
            {
                Console.WriteLine("电视机关闭,无法修改音量");
                return;
            } 
            //改变当前电视机正在播放的频道
            this.currentChannel = channel;
            Console.WriteLine("当前正在播放:"+this.currentChannel);
        }


    }
}
