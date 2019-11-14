using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace test
{
    public class JsonHelper
    {
        public static string XmlSerialize<T>(T obj)
        {
            using (StringWriter sw = new StringWriter())
            {
                Type t = obj.GetType();
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(sw, obj);
                sw.Close();
                return sw.ToString();
            }
        }

        ///
        /// 从XML字符串中反序列化对象
        ///
        /// 结果对象类型
        /// 包含对象的XML字符串 /// 编码方式 /// 反序列化得到的对象
        public static T XmlDeserialize<T>(string s, Encoding encoding)
        {
            if (string.IsNullOrEmpty(s))
                throw new ArgumentNullException("s");
            if (encoding == null)
                throw new ArgumentNullException("encoding");

            XmlSerializer mySerializer = new XmlSerializer(typeof(T));
            using (MemoryStream ms = new MemoryStream(encoding.GetBytes(s)))
            {
                using (StreamReader sr = new StreamReader(ms, encoding))
                {
                    return (T)mySerializer.Deserialize(sr);
                }
            }
        }


        public static T jxXMl<T>(T entity, string xmlData) where T : new()
        {
            string xmlr = xmlData.Replace("<item>", "").Replace("</item>", "");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlr);
            
            //取得属性集合
            PropertyInfo[] pi = typeof(T).GetProperties();

            string nodeName = typeof(T).Name;

            //personCarProductionValue s = entity as personCarProductionValue;

            XmlNode node = xmlDoc.SelectSingleNode("//" + nodeName);

            foreach (PropertyInfo item in pi)
            {
                string value = node.SelectSingleNode("//" + item.Name).InnerText;
                item.SetValue(entity, Convert.ChangeType(value, item.PropertyType));
            }
            return entity;
        }

    }
}
