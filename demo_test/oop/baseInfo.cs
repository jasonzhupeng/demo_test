using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_test
{
    class baseInfo : food, IplayGame
    {
        public baseInfo()
        {

        }

        public override string chiShuiGuo()
        {
            return "我在吃水果";
        }

        public override string chiRou()
        {
            return "";
        }

        public string playGame()
        {
            return "我在玩游戏！！";
        }

        public string chiShu(int a)
        {
            return "";
        }

    }
}
