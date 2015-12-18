using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C03Demo
{
    /// <summary>
    /// 计算器类
    /// </summary>
    class Cal
    {
        public int num1;
        public int num2;


        public int GetHe()
        {
            int he = num1 + num2;
            return he;
        }

        public int GetCha()
        {
            int cha = num1 - num2;
            return cha;
        }

        public int GetJi()
        {
            int ji = num1 * num2;
            return ji;
        }


        public int GetShang()
        {
            int shang = num1 / num2;
            return shang;
        }
    }
}
