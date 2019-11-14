using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace demo_test
{
    class mianshi
    {
        static void Main(string[] args)
        {
            #region 字符串倒序输出
            //string str2 = "";
            //string str = "hello owrd ajdf fdd";
            //var list = str.ToArray<char>();

            ////1.第一种
            ////for (int i = list.Length - 1; i >= 0; i--)
            ////{
            ////    str2 += list[i];
            ////}
            ////2.第二种
            //list = list.Reverse().ToArray();
            //str2 = string.Join<char>("", list);
            //Console.WriteLine(str2);
            //list = list.Reverse<string>().ToArray();
            //str2 = string.Join<string>(" ", list);
            #endregion

            //List<List<string>> allList = new List<List<string>>
            //{
            //new List<string> { "a" , "b" , "c" } ,
            //new List <string>{ "1","2","3" },
            //    new List<string>{ "A" , "B" , "C","E"}
            //};

            //var m = from a in allList.FirstOrDefault()
            //        from b in allList.Skip(1).FirstOrDefault()
            //        from c in allList.LastOrDefault()
            //        select string.Format("{0}{1}{2},", a, b, c);
            //m.ToList().ForEach(x => Console.WriteLine(x));
            //Console.WriteLine(m.Count());

            string[] arry = { "a", "b", "c", "d", "e", "f", "g", "h" };

            Random rd = new Random();

            List<int> a = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                int b = rd.Next(1, 49);
                if (!a.Contains(b))
                {
                    a.Add(b);
                }
            }

            a.ForEach(x => Console.Write(x + ","));










        }
    }



    public class Singleton
    {
        string GetPageContent(string url)
        {
            System.Net.WebClient client = new System.Net.WebClient();
            Byte[] responseData = client.DownloadData(url);

            return "";
        }
    }
}
