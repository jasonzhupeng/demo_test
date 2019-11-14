using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_test
{
    class SingleLi
    {
        private SingleLi()
        {

        }

        private static SingleLi _instance;
        private static object obj = new object();

        public static SingleLi CreateInstance()
        {
            if (_instance == null)
            {
                lock (obj)
                {
                    return new SingleLi();
                }
            }
            else
            {
                return _instance;
            }
        }
    }
}
