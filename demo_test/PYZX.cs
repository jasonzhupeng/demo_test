using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace test
{
    class PYZX
    {
        static void Main(string[] args)
        {
            #region 无证书测试
            //string path = Directory.GetParent("..\\").Parent.FullName + "\\reqXml\\全国车辆信息核查.xml";
            //string info = File.ReadAllText(path);
            //try
            //{
            //    com.pycredit.test.WebServiceSingleQueryOfUnzipService ws = new com.pycredit.test.WebServiceSingleQueryOfUnzipService();
            //    var result = ws.queryReport("zfwsquery", "zVefnCwynGo3fLRhp3lJew==", info, "xml");
            //    Console.WriteLine(result);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.ReadKey();
            #endregion

            #region 有证书测试
            /*********得到请求xml中的字符串内容*******/
            string path = Directory.GetParent("..\\").Parent.FullName + "\\reqXml\\test.xml";
            string xmlData = File.ReadAllText(path, Encoding.Default);

            //result<personCarProductionValue> res = JsonHelper.XmlDeserialize<result<personCarProductionValue>>(xmlData, Encoding.UTF8);

            //personCarProductionValue ps = new personCarProductionValue();
            //ps = JsonHelper.jxXMl<personCarProductionValue>(ps, res.returnValue);

            //res.Data = ps;
            //result res = new result();

            //try
            //{
            //    //证书路径
            //    string zslj = Directory.GetParent("..\\").Parent.FullName + "\\reqZs\\zf.pfx";
            //    //读取证书
            //    X509Certificate2 cert = new System.Security.Cryptography.X509Certificates.X509Certificate2(zslj, "123456", X509KeyStorageFlags.MachineKeySet);
            //    //调用服务
            //    com.pycredit.test.WebServiceSingleQueryOfUnzipService ws = new com.pycredit.test.WebServiceSingleQueryOfUnzipService();
            //    ws.ClientCertificates.Clear();//清空证书
            //    ws.ClientCertificates.Add(cert);//添加证书
            //    //得到结果集，注：接口文档时三参数，最后一个参数是方法重载
            //    var result = ws.queryReport("zfwsquery", "zVefnCwynGo3fLRhp3lJew==", b, "xml");
            //    //打印结果
            //    //Console.WriteLine(result);
            //    var xmlss = JsonHelper.XmlDeserialize<result>(result, Encoding.UTF8);
            //    JsonHelper.jxXMl(result);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.ReadKey();
            #endregion
        }

        /// <summary>
        /// 接口调用帮助
        /// </summary>
        /// <param name="requestJson">请求参数</param>
        /// <param name="apiName">接口名</param>
        /// <returns></returns>
        private static String GetStringHttpClientJson(String requestJson, String apiName, bool isGetRequest = false, bool isDecode = true)
        {
            //string baseAddress = "http://localhost:4493/";//本地IIS地址
            string baseAddress = "http://10.1.32.73:7080/";//本地IIS地址
            //string baseAddress = "http://10.1.39.202:60001/";//测试服
            //string baseAddress = "http://117.74.133.36:50001";//正式地址
            String result = String.Empty;
            try
            {
                HttpClient _httpClient = new HttpClient();
                _httpClient.BaseAddress = new Uri(baseAddress);//站点根路径，可以使用配置文件
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string strUtf8Condition = requestJson;//进行UTF8编码
                string resultStr = string.Empty;
                if (isGetRequest)
                {
                    HttpResponseMessage response = _httpClient.GetAsync(apiName).Result;
                    resultStr = response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    HttpResponseMessage response = _httpClient.PostAsJsonAsync(apiName, strUtf8Condition).Result;
                    resultStr = response.Content.ReadAsStringAsync().Result;
                }
                if (isDecode)
                {
                    result = HttpUtility.UrlDecode(resultStr).Trim('"');
                }
                else
                {
                    result = resultStr;
                }
            }
            catch (Exception ex)
            {
                //LogHelper.LogError(String.Format("PlatformHelper.GetStringHttpClientJson:米钢集市平台接口调用，{0}", ex.Message), ex);
            }
            return result;
        }
    }

}
