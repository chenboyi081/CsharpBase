using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C02Demo
{
    /// <summary>
    /// 球队类
    /// </summary>
    class Team
    {
        //有球员数量 教练数量 胜利场数  失败场数. 球队名称  字段.
        public int qiuYuanNum;
        public int jiaoLianNum;
        public int winNum;
        public int loseNum;
        public string teamName;

        //再有1个球队自己介绍自己的方法. 
        // 首先基本情况,介绍 球队名称 球员数量 教练数量。 我参加了多少次比赛 胜率是%?
        public void SayHi()
        {
            //20/100
            double rate = winNum * 1.0 / (winNum + loseNum);

            Console.WriteLine("大家好,我们是{0},我们有球员{1}人,教练{2}人,我们参加了{3}次比赛,胜率是{4}%",
                teamName,
                qiuYuanNum,
               jiaoLianNum,
               winNum + loseNum,
               rate * 100
                );
        }
    }
}
