using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_test
{
    abstract class food
    {
        public string chiShu()
        {
            return "我是吃素的 !!";
        }

        public static string hahh()
        {
            return "sdfsfd";
        }

        public virtual string chiRou()
        {
            return "我是吃肉的！！";
        }

        public abstract string chiShuiGuo();
    }
}
