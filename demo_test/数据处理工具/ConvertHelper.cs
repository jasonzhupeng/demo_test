using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace test
{
    public static class ConvertHelper
    {
        #region 常用转换

        /// <summary>
        /// 将字符串转换为数组
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>字符串数组</returns>
        public static string[] GetStrArray(string str, char[] speater = null)
        {
            if (speater == null || speater.Count() == 0)
            {
                speater = new char[] { ',', '，' };//处理中文“,”
            }
            return str.Split(speater);
        }

        /// <summary>
        /// 将字符串转换为List数组
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>字符串数组</returns>
        public static List<string> GetStrLst(string str)
        {
            List<string> list = new List<string>();
            string[] strary = GetStrArray(str);
            if (strary != null)
            {
                list = new List<string>(strary);
            }
            return list;
        }

        /// <summary>
        /// 将数组转换为字符串
        /// </summary>
        /// <param name="list">List</param>
        /// <param name="speater">分隔符</param>
        /// <returns>String</returns>
        public static string GetArrayStr(List<string> list, string speater)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                {
                    sb.Append(list[i]);
                }
                else
                {
                    sb.Append(list[i]);
                    sb.Append(speater);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 将对象转换为字符串
        /// </summary>
        /// <param name="obj">要转换的对象</param>
        /// <returns>转换后的string类型结果</returns>
        public static string ObjectToStr(object obj)
        {
            String result = String.Empty;
            //if (obj == null)
            //    return "";
            //return obj.ToString().Trim();
            try
            {
                if (obj != null)
                {
                    result = obj.ToString().Trim();
                }
            }
            catch
            {
                result = String.Empty;
            }
            return result;
        }

        /// <summary>
        /// object型转换为bool型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的bool类型结果</returns>
        public static bool ObjToBool(object expression, bool defValue)
        {
            if (expression != null)
                return StrToBool(expression.ToString(), defValue);

            return defValue;
        }
        public static bool? ObjToBoolWithNull(object expression, bool? defValue)
        {
            if (expression != null)
            {
                string strBool = expression.ToString();
                if (string.Compare(strBool, "true", true) == 0)
                    return true;
                else if (string.Compare(strBool, "false", true) == 0)
                    return false;
            }

            return defValue;
        }

        /// <summary>
        /// string型转换为bool型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的bool类型结果</returns>
        public static bool StrToBool(string expression, bool defValue)
        {
            if (expression != null)
            {
                if (string.Compare(expression, "true", true) == 0)
                    return true;
                else if (string.Compare(expression, "false", true) == 0)
                    return false;
            }
            return defValue;
        }

        /// <summary>
        /// 将对象转换为Int32类型
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static int ObjToInt(object expression, int defValue)
        {
            if (expression != null)
                return StrToInt(expression.ToString(), defValue);

            return defValue;
        }
        /// <summary>
        /// 将对象转换为Int64类型
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static Int64 ObjToInt64(object expression, Int64 defValue)
        {
            if (expression != null)
                return StrToInt64(expression.ToString(), defValue);

            return defValue;
        }
        public static int? ObjToIntWithNull(object expression, int? defValue)
        {
            int? tempInt = defValue;
            if (expression != null)
            {
                string strInt = expression.ToString();
                if (defValue != null)
                {
                    tempInt = StrToInt(strInt, defValue.Value);
                }
                else
                {
                    tempInt = StrToInt(strInt, Int16.MaxValue);//不能确定结果Int16.MaxValue是“strInt=Int16.MaxValue”还是“defValue=null”
                    if (tempInt == Int16.MaxValue)
                    {
                        tempInt = StrToInt(strInt, Int16.MinValue);
                        if (tempInt == Int16.MinValue)
                            tempInt = null;
                    }
                }
            }

            return tempInt;
        }

        /// <summary>
        /// 将字符串转换为Int32类型
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static int StrToInt(string expression, int defValue)
        {
            if (string.IsNullOrWhiteSpace(expression) || expression.Trim().Length >= 11 || !Regex.IsMatch(expression.Trim(), @"^([-]|[0-9])[0-9]*(\.\w*)?$"))
                return defValue;

            int rv;
            if (Int32.TryParse(expression, out rv))
                return rv;

            return Convert.ToInt32(StrToFloat(expression, defValue));
        }
        /// <summary>
        /// 将字符串转换为Int64类型
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static Int64 StrToInt64(string expression, Int64 defValue)
        {
            if (string.IsNullOrWhiteSpace(expression) || expression.Trim().Length >= 11 || !Regex.IsMatch(expression.Trim(), @"^([-]|[0-9])[0-9]*(\.\w*)?$"))
                return defValue;

            int rv;
            if (Int32.TryParse(expression, out rv))
                return rv;

            return Convert.ToInt64(StrToFloat(expression, defValue));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static ulong StrUlong(string expression, ulong defValue)
        {
            if (string.IsNullOrWhiteSpace(expression) || !Regex.IsMatch(expression.Trim(), @"^([-]|[0-9])[0-9]*(\.\w*)?$"))
                return defValue;

            ulong rv;
            if (ulong.TryParse(expression, out rv))
                return rv;

            return defValue;
        }

        /// <summary>
        /// Object型转换为decimal型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的decimal类型结果</returns>
        public static decimal ObjToDecimal(object expression, decimal defValue)
        {
            if (expression != null)
                return StrToDecimal(expression.ToString(), defValue);

            return defValue;
        }

        /// <summary>
        /// string型转换为decimal型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的decimal类型结果</returns>
        public static decimal StrToDecimal(string expression, decimal defValue)
        {
            if ((expression == null))
                return defValue;

            decimal intValue = defValue;
            if (expression != null)
            {
                bool IsDecimal = Regex.IsMatch(expression, @"^([-]|[0-9])[0-9]*(\.\w*)?$");
                if (IsDecimal)
                    decimal.TryParse(expression, out intValue);
            }
            return intValue;
        }
        public static decimal? StrToDecimalWithNull(string expression, decimal? defValue)
        {
            if ((expression == null))
                return defValue;

            decimal? intValue = null;
            try
            {
                bool IsDecimal = Regex.IsMatch(expression, @"^([-]|[0-9])[0-9]*(\.\w*)?$");
                if (IsDecimal)
                    intValue = decimal.Parse(expression);
            }
            catch { }
            return intValue;
        }

        /// <summary>
        /// Object型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static float ObjToFloat(object expression, float defValue)
        {
            if (expression != null)
                return StrToFloat(expression.ToString(), defValue);

            return defValue;
        }

        /// <summary>
        /// string型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static float StrToFloat(string expression, float defValue)
        {
            if ((expression == null) || (expression.Length > 10))
                return defValue;

            float intValue = defValue;
            if (expression != null)
            {
                bool IsFloat = Regex.IsMatch(expression, @"^([-]|[0-9])[0-9]*(\.\w*)?$");
                if (IsFloat)
                    float.TryParse(expression, out intValue);
            }
            return intValue;
        }


        public static decimal ToFixedWeight(decimal number)
        {
            int precision = 4;//重量保留“4”位
            decimal result = Math.Round(number, precision);
            return result;
        }
        public static decimal ToFixedMoney(decimal number)
        {
            int precision = 2;//金额保留“2”位
            decimal result = Math.Round(number, precision);
            return result;
        }

        public static decimal ToFixedTaxUnitPrice(decimal number)
        {
            int precision = 6;
            decimal result = Math.Round(number, precision);
            return result;
        }

        #endregion

        #region   字符串长度区分中英文截取
        /// <summary>   
        /// 截取文本，区分中英文字符，中文算两个长度，英文算一个长度
        /// </summary>
        /// <param name="str">待截取的字符串</param>
        /// <param name="length">需计算长度的字符串</param>
        /// <returns>string</returns>
        public static string GetSubString(string str, int length)
        {
            string temp = str;
            int j = 0;
            int k = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (Regex.IsMatch(temp.Substring(i, 1), @"[\u4e00-\u9fa5]+"))
                {
                    j += 2;
                }
                else
                {
                    j += 1;
                }
                if (j <= length)
                {
                    k += 1;
                }
                if (j > length)
                {
                    return temp.Substring(0, k) + "...";
                }
            }
            return temp;
        }


        /// <summary>
        /// 获取字符串长度，中文算2个字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int GetFullLength(string str)
        {
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Regex.IsMatch(str.Substring(i, 1), @"[\u4e00-\u9fa5]+"))
                {
                    j += 2;
                }
                else
                {
                    j += 1;
                }
            }
            return j;
        }

        #endregion

        #region GUID操作

        /// <summary>
        /// 转换为为GUID
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static Guid ObjectToGuidValue(object expression)
        {
            if (expression != null)
            {
                try
                {
                    return new Guid(expression.ToString());
                }
                catch { }
            }
            return Guid.Empty;
        }

        /// <summary>
        /// object转换为GUID 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Guid? ObjectToGuid(object expression)
        {
            if (expression != null)
            {
                try
                {
                    return new Guid(expression.ToString());
                }
                catch { }
            }
            return null;
        }

        /// <summary>
        /// 字符串列表转化成Guid列表
        /// </summary>
        /// <param name="stringList"></param>
        /// <returns></returns>
        public static List<Guid> ToGuidList(List<string> stringList)
        {
            List<Guid> guidList = new List<Guid>();
            List<string> tempList = new List<string>();
            if (stringList != null && stringList.Count > 0)
            {
                tempList = stringList.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            }
            if (tempList != null && tempList.Count > 0)
            {
                Guid? temp;
                foreach (var str in tempList)
                {
                    temp = ObjectToGuid(str);
                    if (temp != null)
                    {
                        guidList.Add(temp.Value);
                    }
                }
            }
            return guidList;
        }

        public static List<Guid> ToGuidList(string str, char[] speater = null)
        {
            List<Guid> guidList = new List<Guid>();
            if (!string.IsNullOrWhiteSpace(str))
            {
                guidList = ToGuidList(GetStrArray(str, speater).ToList());
            }
            return guidList;
        }

        /// <summary>
        /// 将字符串转换成List数组
        /// </summary>
        /// <param name="str"></param>
        /// <param name="speater"></param>
        /// <returns></returns>
        public static List<string> ToStringList(string str, char[] speater = null)
        {
            List<string> list = new List<string>();

            try
            {
                if (!string.IsNullOrWhiteSpace(str))
                {
                    list = GetStrArray(str, speater).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        #endregion

        #region 时间类转货及格式

        /// <summary>
        /// 将对象转换为日期时间类型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static DateTime StrToDateTime(string str, DateTime defValue)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                DateTime dateTime;
                if (DateTime.TryParse(str, out dateTime))
                    return dateTime;
            }
            return defValue;
        }

        //可以为空的日期
        public static DateTime? StrToDateTimeWithNull(string str, DateTime? defValue)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                DateTime dateTime;
                if (DateTime.TryParse(str, out dateTime))
                    return dateTime;
            }
            return defValue;
        }

        /// <summary>
        /// 将对象转换为日期时间类型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <returns>转换后的int类型结果</returns>
        public static DateTime StrToDateTime(string str)
        {
            return StrToDateTime(str, DateTime.Now);
        }

        /// <summary>
        /// 将对象转换为日期时间类型
        /// </summary>
        /// <param name="obj">要转换的对象</param>
        /// <returns>转换后的int类型结果</returns>
        public static DateTime ObjectToDateTime(object obj)
        {

            return obj == null ? DateTime.Now : StrToDateTime(obj.ToString());
        }

        /// <summary>
        /// 将对象转换为日期时间类型
        /// </summary>
        /// <param name="obj">要转换的对象</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static DateTime ObjectToDateTime(object obj, DateTime defValue)
        {
            return obj == null ? defValue : StrToDateTime(obj.ToString(), defValue);
        }

        /// <summary>
        /// 将对象转换为日期时间类型并格式化
        /// </summary>
        /// <param name="obj">要转换的对象</param>
        /// <returns>转换后的格式</returns>
        public static DateTime ToDateTime(this object obj, string format = "")
        {
            string inTime = obj == null ? string.Empty : obj.ToString();
            if (string.IsNullOrEmpty(format))
            {
                return StrToDateTime(inTime);
            }
            else
            {
                string formatTime = StrToDateTime(inTime).ToString(format);
                return Convert.ToDateTime(formatTime);
            }
        }

        /// <summary>
        /// 开时时间
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defValue"></param>
        /// <returns></returns>
        public static DateTime ObjectToStartDate(object obj, DateTime defValue)
        {
            DateTime date = ObjectToDateTime(obj, defValue);
            string dataStr = date.ToString("yyyy-MM-dd 00:00:00");
            if (dataStr == DateTime.MinValue.ToString("yyyy-MM-dd 00:00:00"))
            {
                return DateTime.MinValue;
            }
            else
            {
                return DateTime.Parse(dataStr);
            }
        }

        /// <summary>
        /// 结束时间
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defValue"></param>
        /// <returns></returns>
        public static DateTime ObjectToEndDate(object obj, DateTime defValue)
        {
            DateTime date = ObjectToDateTime(obj, defValue);
            string dataStr = date.ToString("yyyy-MM-dd 23:59:59");
            if (dataStr == DateTime.MaxValue.ToString("yyyy-MM-dd 23:59:59"))
            {
                return DateTime.MaxValue;
            }
            else
            {
                return DateTime.Parse(dataStr);
            }
        }

        public static DateTime? ObjectToEndDateWithNull(object obj, DateTime? defValue)
        {
            DateTime? tempDate = defValue;
            if (obj != null)
            {
                string strDatetime = obj.ToString();
                tempDate = StrToDateTimeWithNull(strDatetime, defValue);
            }

            if (tempDate != null)
            {
                string dataStr = tempDate.Value.ToString("yyyy-MM-dd 23:59:59");
                if (dataStr == DateTime.MaxValue.ToString("yyyy-MM-dd 23:59:59"))
                {
                    return DateTime.MaxValue;
                }
                else
                {
                    return DateTime.Parse(dataStr);
                }
            }

            return tempDate;
        }

        public static string DateTimeFormat(DateTime? dateTime)
        {
            var rsult = ObjectToDateTime(dateTime, DateTime.Now);

            return rsult.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// 格式化日期
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="defValue"></param>
        /// <returns></returns>
        public static string DateFormat(DateTime? dateTime)
        {
            return DateFormat(dateTime, DateTime.Now);
        }

        /// <summary>
        /// 格式化日期
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="defValue"></param>
        /// <returns></returns>
        public static string DateFormat(DateTime? dateTime, DateTime defValue)
        {
            var rsult = ObjectToDateTime(dateTime, defValue);

            return rsult.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// Jason 2015/07/21
        /// 格式化时间去掉秒
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string TimeFormat(object time)
        {
            string _time = string.Empty;
            if (string.IsNullOrEmpty(ObjectToStr(time)))
            {
                _time = DateTime.Now.ToShortTimeString();
            }
            else
            {
                _time = ObjectToStr(time);
            }
            string lastTime = DateTime.Parse(_time).ToString("HH:mm");
            return lastTime;
        }

        #endregion

        #region 枚举转换成键值列表

        /// <summary>
        /// 枚举转换成List KeyValue
        /// </summary>
        /// <returns></returns>
        public static List<KeyValuePair<string, int>> EnumToListKeyValue(Type enumType)
        {
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
            int i = 0;
            System.Reflection.FieldInfo[] fields = enumType.GetFields();
            string strText = string.Empty;
            string strValue = string.Empty;
            foreach (FieldInfo field in fields)
            {
                if (field.FieldType.IsEnum)
                {
                    if (!field.IsSpecialName)
                    {
                        list.Add(new KeyValuePair<string, int>(field.Name, ConvertHelper.StrToInt(field.GetRawConstantValue().ToString(), 0)));
                    }
                    else
                    {
                        list.Add(new KeyValuePair<string, int>(field.Name, i));
                    }

                    i++;
                }
            }
            return list;
        }

        /// <summary>
        /// 获取枚举Key值列表
        /// </summary>
        /// <returns></returns>
        public static List<int> GetEnumKeyList(Type enumType)
        {
            List<int> list = new List<int>();
            int i = 0;
            System.Reflection.FieldInfo[] fields = enumType.GetFields();
            foreach (FieldInfo field in fields)
            {
                if (field.FieldType.IsEnum)
                {
                    if (!field.IsSpecialName)
                    {
                        list.Add(ConvertHelper.StrToInt(field.GetRawConstantValue().ToString(), 0));
                    }
                    else
                    {
                        list.Add(i);
                    }

                    i++;
                }
            }
            return list;
        }

        #endregion

        #region 周信息

        public static string GetWeek()
        {
            var week = "周一";
            switch (DateTime.Today.DayOfWeek.ToString())
            {
                case "Monday":
                    week = "周一";
                    break;
                case "Tuesday":
                    week = "周二";
                    break;
                case "Wednesday":
                    week = "周三";
                    break;
                case "Thursday":
                    week = "周四";
                    break;
                case "Friday":
                    week = "周五";
                    break;
                case "Saturday":
                    week = "周六";
                    break;
                case "Sunday":
                    week = "周日";
                    break;
            }

            return week;
        }

        #endregion

        #region 转换到List<int>

        /// <summary>
        /// 字符串列表转化成Guid列表
        /// </summary>
        /// <param name="stringList"></param>
        /// <returns></returns>
        public static List<int> ToIntList(List<string> stringList)
        {
            List<int> intList = new List<int>();
            if (stringList != null && stringList.Count > 0)
            {
                foreach (var str in stringList)
                {
                    int rv = -1;
                    Int32.TryParse(str, out rv);
                    if (rv >= 0)
                    {
                        intList.Add(rv);
                    }
                }
            }
            return intList;
        }
        /// <summary>
        /// 字符串数组转化成Guid列表
        /// </summary>
        /// <param name="stringArray"></param>
        /// <returns></returns>
        public static List<int> ToIntList(string[] stringArray)
        {
            List<int> intList = new List<int>();
            if (stringArray != null && stringArray.Length > 0)
            {
                foreach (var str in stringArray)
                {
                    int rv = -1;
                    Int32.TryParse(str, out rv);
                    if (rv >= 0)
                    {
                        intList.Add(rv);
                    }
                }
            }
            return intList;
        }

        public static List<int> ToIntList(string src, char[] chr)
        {
            List<int> intList = new List<int>();
            if (!string.IsNullOrWhiteSpace(src) && chr != null)
            {
                intList = ToIntList(src.Split(chr));
            }
            return intList;
        }
        /// <summary>
        /// 字符串数组转化成Guid列表
        /// </summary>
        /// <param name="stringArray"></param>
        /// <returns></returns>
        public static List<Decimal> ToDecimalList(string[] stringArray)
        {
            List<Decimal> decimalList = new List<Decimal>();
            if (stringArray != null && stringArray.Length > 0)
            {
                foreach (var str in stringArray)
                {
                    decimal rv = -1;
                    decimal.TryParse(str, out rv);
                    if (rv >= 0)
                    {
                        decimalList.Add(rv);
                    }
                }
            }
            return decimalList;
        }
        #endregion

        #region 数组转换
        /// <summary>
        /// 字符串转双精度数组 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="speater"></param>
        /// <returns></returns>
        public static decimal[] GetDecimalArray(string str, char speater = ',')
        {
            decimal[] dsz = { 0, 0 };
            try
            {
                if (!string.IsNullOrEmpty(str))
                {
                    string[] ssz = { };
                    if (!string.IsNullOrEmpty(str))
                    {
                        ssz = str.Split(speater);
                    }
                    else
                    {
                        ssz = str.Split(',');
                    }

                    for (int i = 0; i < ssz.Length; i++)
                    {
                        //dsz[i] = ssz[i].ToDecimal(0);
                    }
                }
            }
            catch
            {
                dsz = new decimal[] { 0, 0 };
            }
            return dsz;
        }
        /// <summary>
        /// 字符串转整型数组 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="speater"></param>
        /// <returns></returns>
        public static int[] GetIntArray(string str, char speater = ',')
        {
            int[] isz = { 0, 0 };
            try
            {
                if (!string.IsNullOrEmpty(str))
                {
                    string[] ssz = { };
                    if (!string.IsNullOrEmpty(str))
                    {
                        ssz = str.Split(speater);
                    }
                    else
                    {
                        ssz = str.Split(',');
                    }

                    for (int i = 0; i < ssz.Length; i++)
                    {
                        //isz[i] = ssz[i].ToInt(0);
                    }
                }
            }
            catch
            {
                isz = new int[] { 0, 0 };
            }
            return isz;
        }
        #endregion

        #region 转义字符串解析

        /// <summary>
        /// jason
        /// 去掉\t\n这样的字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetdeZyString(string str)
        {
            string result = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(str))
                {
                    str = str.Replace("\r", ""); //删除\r
                    str = str.Replace("\n", "");//删除\n
                    str = str.Replace("\t", "");//删除\t
                    str = str.Replace(" ", "");//删除空格
                    str = str.Replace("\"", "");//删除\"
                    str = str.TrimStart('[');
                    str = str.TrimEnd(']');
                    result = str;
                }
            }
            catch
            {
                result = string.Empty;
            }
            return result;
        }

        #endregion
    }
}
