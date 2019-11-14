using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    /// <summary>
    /// 时间戳工具
    /// </summary>
    public class TimeStampHelper
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
            long lTime = long.Parse(string.Format("{0}0000000",timeStamp));
            TimeSpan toNow = new TimeSpan(lTime); 
            
            return dateTimeStart.Add(toNow);
        
        }

        /// <summary>
        /// DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name=”time”></param>
        /// <returns></returns>
        public static Int64 ConvertDateTimeInt(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }

        /// <summary>
        /// 对字符串进行编码，类似于js的escape()方法
        ///将小于255的标点等字符变为"%+其16进制ascii码（两位数字，不足前面补0）"的形式，
        ///将大于255的字符变为"%u+其16进制unicode码（四位数字，不足前面补0）"的形式，
        /// </summary>
        /// <param name="message">欲编码的字符串</param>
        /// <returns></returns>
        public static string EncodingByEscape(string message)
        {
            int i;
            char[] charArray = message.ToCharArray();
            int charValue;
            char ch;
            string[] strArray = new string[charArray.GetLength(0)];
            for (i = 0; i < charArray.GetLength(0); i++)
            {
                ch = charArray[i];
                charValue = System.Convert.ToInt32(ch);
                if (charValue < 255)
                {
                    if (ch == '*' || ch == '+' || (ch >= '-' && ch <= '9') || (ch >= '@' && ch <= 'Z') || ch == '_' || (ch >= 'a' && ch <= 'z'))
                    {
                        strArray[i] = ch.ToString();
                    }
                    else
                    {
                        strArray[i] = string.Format("%{0:X2}", charValue);
                    }
                }
                else
                {
                    strArray[i] = string.Format("%u{0:X4}", charValue);
                }
            }
            return string.Concat(strArray);
        }

        #region 3des加密解密

        /// <summary>
        /// 3des加密
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string DES3Encrypt(string data, string key = "ESJPUYgWQDE4RXlRy91RYXcpdJEwQUHi")
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();

            DES.Key = Convert.FromBase64String(key);
            DES.Mode = CipherMode.ECB;
            DES.Padding = PaddingMode.PKCS7;

            ICryptoTransform DESEncrypt = DES.CreateEncryptor();

            byte[] Buffer = Encoding.UTF8.GetBytes(data);
            return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
        }

        /// <summary>
        /// 3des解密
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string DES3Decrypt(string data, string key = "ESJPUYgWQDE4RXlRy91RYXcpdJEwQUHi")
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();

            DES.Key = Convert.FromBase64String(key);
            DES.Mode = CipherMode.ECB;
            DES.Padding = System.Security.Cryptography.PaddingMode.PKCS7;

            ICryptoTransform DESDecrypt = DES.CreateDecryptor();

            string result = "";
            try
            {
                byte[] Buffer = Convert.FromBase64String(data);
                result = Encoding.UTF8.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
            }
            catch (Exception e)
            {

            }
            return result;
        }

        #endregion
    }
}
