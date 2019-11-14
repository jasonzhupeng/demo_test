using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_test
{
    class SqlServerDal : IDBAccess
    {
        public void Add()
        {
            Console.WriteLine("SqlServer数据库添加一条订单");
        }
    }
}
