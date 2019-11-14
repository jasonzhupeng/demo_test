using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace demo_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //food a = new baseInfo();
            //Console.WriteLine(a.chiShuiGuo());

            //IplayGame b = (IplayGame)Assembly.LoadFrom("demo_test.exe").CreateInstance("demo_test.baseInfo");
            ////new baseInfo();
            //Console.WriteLine(b.playGame());
            //IplayGame c = new IplayGame();
            //SingleLi d = SingleLi.CreateInstance();

            //baseInfo a = new baseInfo();
            //Console.WriteLine(a.playGame());

            //string str = "12323 哈哈哈";
            //var str1 = Encoding.Default.GetBytes(str);
            //Console.WriteLine(str.Length);
            //Console.WriteLine(str1.Length);

            //try
            //{
            //    WebClient MyWebClient = new WebClient();
            //    //MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            //    Byte[] pageData = MyWebClient.DownloadData("https://www.163.com/"); //从指定网站下载数据
            //    string pageHtml = Encoding.Default.GetString(pageData);  //如果获取网站页面采用的是GB2312，则使用这句    
            //                                                             //string pageHtml = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句
            //    Console.WriteLine(pageHtml);//在控制台输入获取的内容
            //    using (StreamWriter sw = new StreamWriter("c:\\test\\ouput.html"))//将获取的内容写入文本
            //    {
            //        sw.Write(pageHtml);
            //    }
            //    Console.ReadLine(); //让控制台暂停,否则一闪而过了    
            //}
            //catch (WebException webEx)
            //{
            //    Console.WriteLine(webEx.Message.ToString());
            //}

            #region 正则表达式
            //string a = "windows7";
            //string b = "windowsxp";
            //string c = "windows8";
            #endregion

            #region 彩票随机数
            Random rd = new Random(3);
            Console.WriteLine(rd.Next());

            #endregion
        }
    }
}
