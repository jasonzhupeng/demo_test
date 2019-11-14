using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    /// <summary>
    /// ZF接口请求头
    /// </summary>
    public class JsonCommon
    {
        public int ClientType = 666;
        public string UserId = string.Empty;
        public string ToKen = string.Empty;
        public string AppVersion = string.Empty;
        public string DeviceToKen = string.Empty;
        public long RequestTimeStamp = 0;
        public long UpdateTimeStamp = 0;
        public string EquipmentNo = Guid.NewGuid().ToString();
        public Object Condition { get; set; }
    }

    public class Person
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public string Eat()
        {
            return "我今天吃中餐";
        }
    }

    public class ERPRequest
    {
        private string _type = "Member";
        /// <summary>
        /// 业务类型
        /// </summary>
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        private string _sUserNo = string.Empty;
        /// <summary>
        /// 用户编号
        /// </summary>
        public string sUserNo
        {
            get { return _sUserNo; }
            set { _sUserNo = value; }
        }
        private int _iClientType = 0;
        /// <summary>
        /// 客户端类型
        /// </summary>
        public int iClientType
        {
            get { return _iClientType; }
            set { _iClientType = value; }
        }
        private string _sAppVersion = string.Empty;
        /// <summary>
        /// APP版本号
        /// </summary>
        public string sAppVersion
        {
            get { return _sAppVersion; }
            set { _sAppVersion = value; }
        }
        private string _sEquipmentNo = string.Empty;
        /// <summary>
        /// 设备号
        /// </summary>
        public string sEquipmentNo
        {
            get { return _sEquipmentNo; }
            set { _sEquipmentNo = value; }
        }

        private int _iSource = 0;
        /// <summary>
        /// 来源 1，智富贷 2，智慧汽车网 3，智富360 4，ERP APP
        /// </summary>
        public int iSource
        {
            get { return _iSource; }
            set { _iSource = value; }
        }

        private string _wxopenid = string.Empty;
        /// <summary>
        /// 微信openID
        /// </summary>
        public string sWxOpenId
        {
            get { return _wxopenid; }
            set { _wxopenid = value; }
        }

        private string _stoken = string.Empty;
        /// <summary>
        /// 系统令牌
        /// </summary>
        public string sToken
        {
            get { return _stoken; }
            set { _stoken = value; }
        }

        public Object model { get; set; }

        public Object page { get; set; }
    }

    public class HttpPostHelper
    {
        /// <summary>
        /// 时间戳转为C#格式时间
        /// </summary>
        /// <param name=”timeStamp”></param>
        /// <returns></returns>
        public static DateTime GetTime(Int64 timeStamp)
        {
            //DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));

            //TimeSpan toNow = new TimeSpan(timeStamp); return dtStart.Add(toNow);

            DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(string.Format("{0}0000000", timeStamp));
            TimeSpan toNow = new TimeSpan(lTime);

            return dateTimeStart.Add(toNow);
        }
    }
}
