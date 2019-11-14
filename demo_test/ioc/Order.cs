using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_test
{
    public class Order
    {
        //private readonly MySqlDal mySqlDal = new MySqlDal();
        //private readonly SqlServerDal sqlDal = new SqlServerDal();
        private IDBAccess _dal;
        //public IDBAccess Dal
        //{
        //    get { return _dal; }
        //    set { _dal = value; }
        //}

        public void Ffzl(IDBAccess dba)
        {
            _dal = dba;
        }

        //public Order(IDBAccess dal)
        //{
        //    _dal = dal;
        //}

        public void Add()
        {
            _dal.Add();
        }
    }
}
