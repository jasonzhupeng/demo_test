using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace test
{
    class IMessageTest
    {
        static void Main(string[] args)
        {
            JsonCommon reqObj = new JsonCommon();

            #region 互发消息
            //reqObj.UserId = "82362420-2d40-481e-a74f-62d02b8ebad8";
            //reqObj.ToKen = "TBu1Qvb1bxsyWwz/eEgE5HgGeuMYxbsrzS8SyFNngFTKaOsnrA5zQX9XWz1xxlym";
            ////UserId="446cecfd-5ff2-42e9-9a3c-ae03daf081c4",
            ////ToKen="+oo+Fuupqabs7yo++aXMoHgGeuMYxbsrzS8SyFNngFTKaOsnrA5zQX9XWz1xxlym",
            ////UserId="dbb8f18b-a692-4b3f-97af-a34091d31ba3",
            ////ToKen="SopU3YJagO/bCBEG9JdEIngGeuMYxbsrzS8SyFNngFTKaOsnrA5zQX9XWz1xxlym",
            //reqObj.ClientType = 2;
            //reqObj.Condition = new
            // {
            //     iMsg_type = 1,
            //     sTarget_id = "373b1f7c-c613-418f-ba02-2af5cc987df5",
            //     sTextString = "fadfa去玩儿去玩儿去玩儿去玩儿去玩儿",
            //     sProductId = "EC7E9BF3-397F-4B9D-BBC5-23FEE3D48D0C",
            //     sTitle = "原来标题还可以这么长。。。。长"
            // };
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string resultJson = GetStringHttpClientJson(requestJson, "ZF/Message/IMMsgSend");
            #endregion

            #region 消息发送3.0
            //reqObj.ClientType = 2;
            //reqObj.Condition = new
            // {
            //     sVersion = "V9.99",                            //版本号
            //     sFrom_id = "810012687",                        //发送人编号
            //     sTarget_id = "800888888",                      //接收人编号
            //     sMessageGroupId = Guid.NewGuid(),              //消息组Id
            //     iMsg_type = 1,                                     //消息类型:1文本 2 语音 3 图片
            //     sTextString = "你吃饭了么？",                    //消息文本内容
            //     iDuration = 0,                             //语音时长 秒数
            //     iWidth = 0,                            //图片宽度
            //     iHeight = 0,                               //图片高度
            //     sFormat = ".txt",                       //文件扩展名 .mp3 .jpg .png .txt
            //     iFsize = 0,                            //文件大小
            //     sUrl = string.Empty,               //文件路径
            //     sNarrowUrl = string.Empty,         //缩略图路径
            //     iNarrowWidth = string.Empty,           //缩略图宽度
            //     sTitle = string.Empty,        //标题(发送人昵称/手机号/帐号)
            //     iNarrowHeight = string.Empty       //缩略图高度
            // };
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string resultJson = GetStringHttpClientJson(requestJson, "ZF/Message/IMMsgCustomSend");
            #endregion

            #region 获取个人消息
            //reqObj.UserId = "3cad985f-2fcd-4e8d-9243-e6623e5598bd";
            //reqObj.Condition = new
            //{
            //    LastTime = 0,
            //    Alias = "18817509881",
            //};

            //string requestJson = JsonConvert.SerializeObject(reqObj);
            ////////string requestJson = "{\"Condition\":{\"Alias\":\"15221944906\"},\"DeviceToKen\":\"00000000-0000-0000-0000-000000000000\",\"ToKen\":\"sOW6H/0GLgIA2L8nQAUl0XgGeuMYxbsrzS8SyFNngFTKaOsnrA5zQX9XWz1xxlym\",\"AppVersion\":7,\"EquipmentNo\":\"867640025963260\",\"RequestTimeStamp\":\"0\",\"UserId\":\"373b1f7c-c613-418f-ba02-2af5cc987df5\",\"ClientType\":\"1\",\"UpdateTimeStamp\":\"0\"}";
            //string apiName = "ZF/Message/GetMessageNotify";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 获取消息明细列表
            //reqObj.Condition = new
            //{
            //    PageIndex = 1,
            //    PushType = 103,
            //    Alias = "18817509881",
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            ////string requestJson = "{\"Condition\":{\"Alias\":\"15221944906\",\"PushType\":\"102\"},\"DeviceToKen\":\"00000000-0000-0000-0000-000000000000\",\"ToKen\":\"sOW6H/0GLgIA2L8nQAUl0XgGeuMYxbsrzS8SyFNngFTKaOsnrA5zQX9XWz1xxlym\",\"AppVersion\":7,\"EquipmentNo\":\"867640025963260\",\"RequestTimeStamp\":\"0\",\"UserId\":\"373b1f7c-c613-418f-ba02-2af5cc987df5\",\"ClientType\":\"1\",\"UpdateTimeStamp\":\"0\"}";
            //string apiName = "ZF/Message/GetMsgList";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region Im推送【推送平台】
            //Random rm = new Random();
            //char[] zm = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //string[] hz = { "一", "二", "三", "肆", "五", "六", "麒", "八", "九", "十", "十一", "十二", "十三", "十四", "十五", "十六" };
            //string apiName = "/ZQ/IMessage/SendPushMessage";
            //reqObj.ToKen = "zhihuiqichewang,f845f3658544648ad5c1fa9bf90de39c";
            //reqObj.Condition = new
            //{
            //    Alias = "15221944906",
            //    TextString = string.Format("我是路人{0}{1}现在开始第{2}条推送！！！~~~", zm[rm.Next(zm.Length)], hz[rm.Next(hz.Length)], rm.Next(zm.Length) + 1),
            //    Extras = "PushType:101;Code:",
            //    Title = "小月月"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 获取个人最新消息列表【推送平台】
            //reqObj.Condition = new
            //{
            //    PushType = "102",
            //    Alias = "18321655626",
            //    LastTime = 0
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string requestJson = "{\"ClientType\":3,\"ToKen\":\"\",\"EquipmentNo\":\"\",\"Condition\":{\"PushType\":103,\"Alias\":\"13167119270\",\"LastTime\":0}}";
            //string apiName = "/ZQ/SystemMessage/GetLastMsgInfo";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 获取个人消息明细列表【推送平台】
            //reqObj.Condition = new
            //{
            //    PageIndex = 1,
            //    PushType = "102",
            //    Alias = "18321655626",
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            ////string requestJson = "{\"ClientType\":3,\"ToKen\":\"\",\"EquipmentNo\":\"\",\"Condition\":{\"PushType\":\"102\",\"Alias\":\"15221944906\"}}";
            //string apiName = "/ZQ/SystemMessage/GetMsgList";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 查看自定义消息列表
            //reqObj.Condition = new
            //{
            //    PageIndex = 1,
            //    PageSize = 10,
            //    PushType = "102",
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            ////string requestJson = "{\"ClientType\":3,\"ToKen\":\"\",\"EquipmentNo\":\"\",\"Condition\":{\"PushType\":\"102\",\"Alias\":\"15221944906\"}}";
            //string apiName = "/ZQ/MessageChannel/GetDiyMessagelist";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 单挑消息标记已读
            //reqObj.Condition = new
            //{
            //    PageIndex = 1,
            //    PageSize = 12,
            //    PushType = "102",
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            ////string requestJson = "{\"ClientType\":3,\"ToKen\":\"\",\"EquipmentNo\":\"\",\"Condition\":{\"PushType\":\"102\",\"Alias\":\"15221944906\"}}";
            //string apiName = "/ZQ/MessageChannel/GetDiyMessagelist";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 多条消息标记为已阅读
            //reqObj.Condition = new
            //{
            //    PushType = "10201",
            //    Alias = "18721606896"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "/ZF/Message/ListMsgIsRead";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 杂乱
            //Guid a = Guid.Empty;
            //List<string> a = new List<string> { "1", "2", "3", "4", "5", "6" };
            //List<string> b = new List<string> { "A", "B", "C", "D" };
            //List<string> c = b.Union(a).ToList();

            //string a = string.Empty;
            //object b = JsonConvert.DeserializeObject(a);
            //DateTime drtime = DateTime.Now;
            //drtime = drtime.AddDays(-0);
            //Console.WriteLine(drtime);

            //int a = 5;
            //int b = 3;
            //int c = (Int32)Math.Ceiling((decimal)5 / (decimal)3);
            #endregion
        }

        /// <summary>
        /// 接口调用帮助
        /// </summary>
        /// <param name="requestJson">请求参数</param>
        /// <param name="apiName">接口名</param>
        /// <returns></returns>
        private static String GetStringHttpClientJson(String requestJson, String apiName, bool isGetRequest = false)
        {
            //string baseAddress = "http://10.1.32.73:9090:1010/";//推送平台测试服
            string baseAddress = "http://localhost:24056/"; //推送(本地)
            //string baseAddress = "http://121.41.123.231:912/";//测试服
            //string baseAddress = "http://10.1.32.73:9090/";//二手车平台测试服
            //string baseAddress = "http://10.1.32.42/"; //石久银
            //string baseAddress = "http://localhost:38923/";//二手车(本地)
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

                var responseResult = HttpUtility.UrlDecode(resultStr).Trim('"');
                result = responseResult;
            }
            catch (Exception ex)
            {
                //LogHelper.LogError(String.Format("PlatformHelper.GetStringHttpClientJson:米钢集市平台接口调用，{0}", ex.Message), ex);
            }
            return result;
        }
    }
}
