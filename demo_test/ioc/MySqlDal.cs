using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_test
{
    class MySqlDal : IDBAccess
    {
        //private MySqlDal()
        //{

        //}

        //public static MySqlDal _instance;

        //public static MySqlDal CreateInstance()
        //{
        //    if (_instance == null)
        //    {
        //        return new MySqlDal();
        //    }
        //    else
        //    {
        //        return _instance;
        //    }
        //}

        public void Add()
        {
            Console.WriteLine("MySql数据库添加一条订单");
        }
    }
}
