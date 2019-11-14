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
    class KeFU
    {
        static void Main(string[] args)
        {
            JsonCommon reqObj = new JsonCommon();

            #region 点击客服上报用户
            //string requestJson = "{\"UserId\":\"c3d9321f-7d4c-4c1d-9f85-5734598aa3e1\",\"RequestTimeStamp\":\"0\",\"condition\":{\"sFromId\":\"810012603\"},\"UpdateTimeStamp\":\"1\",\"AppVersion\":\"2.4\",\"ClientType\":\"2\",\"DeviceToKen\":\"00000000-0000-0000-0000-000000000000\",\"EquipmentNo\":\"994A9267-33FA-4209-BB5A-FFB7840BFE9E\",\"ToKen\":\"/FsZeo/wKB3m8K7kVYkBgXgGeuMYxbsrzS8SyFNngFTKaOsnrA5zQX9XWz1xxlym\"}";
            //string apiName = "ZF/Message/UserReport";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 最新未读消息
            //reqObj.UserId = "419308e7-b684-48ce-b4d6-b6a19215c503";
            //reqObj.ToKen = "";
            //reqObj.RequestTimeStamp = TimeStampHelper.ConvertDateTimeInt(DateTime.Now);
            //reqObj.Condition = new
            //{
            //    sChatterId = "810012555",
            //    lTimeStamp = 0
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            ////string requestJson = "{\"UserId\":\"c3d9321f-7d4c-4c1d-9f85-5734598aa3e1\",\"RequestTimeStamp\":\"0\",\"condition\":{\"sChatterId\":\"810012603\",\"lTimeStamp\":\"0\"},\"UpdateTimeStamp\":\"1\",\"AppVersion\":\"2.4\",\"ClientType\":\"2\",\"DeviceToKen\":\"00000000-0000-0000-0000-000000000000\",\"EquipmentNo\":\"994A9267-33FA-4209-BB5A-FFB7840BFE9E\",\"ToKen\":\"/FsZeo/wKB3m8K7kVYkBgXgGeuMYxbsrzS8SyFNngFTKaOsnrA5zQX9XWz1xxlym\"}";
            //string apiName = "ZF/Message/IMMsgCustomUnreadQuery";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 最新未读消息
            //reqObj.Condition = new
            //{
            //    sChatterId = "810012603",
            //    lTimeStamp = 0
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "ZF/Message/IMMsgCustomUnreadQuery";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            Console.WriteLine("你好，你吃放没有");
            #endregion

            #region 消息发送
            //reqObj.UserId = "419308e7-b684-48ce-b4d6-b6a19215c503";
            //reqObj.ToKen = "";
            //reqObj.RequestTimeStamp = TimeStampHelper.ConvertDateTimeInt(DateTime.Now);
            //reqObj.Condition = new
            //{
            //    sFormat = ".txt",
            //    sTarget_id = "",
            //    sTextString = "<> ''''",
            //    sMessageGroupId = "",
            //    sTitle = "亚洲",
            //    sFrom_id = "810012603",
            //    iMsg_type = 1,
            //    iFromType = 2
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "ZF/Message/IMMsgCustomSend";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 用户全部未读消息
            //reqObj.UserId = "c3d9321f-7d4c-4c1d-9f85-5734598aa3e1";
            //reqObj.RequestTimeStamp = TimeStampHelper.ConvertDateTimeInt(DateTime.Now);
            //reqObj.Condition = new
            //{
            //    sAccount = "18501746654"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "ZF/User/UserSumUnReadMsg";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 客户端错误消息收集上报
            //reqObj.UserId = "c3d9321f-7d4c-4c1d-9f85-5734598aa3e1";
            //reqObj.RequestTimeStamp = TimeStampHelper.ConvertDateTimeInt(DateTime.Now);
            //reqObj.Condition = new
            //{
            //    sAccount = "18501746654"
            //};
            ////string requestJson = JsonConvert.SerializeObject(reqObj);
            //string requestJson = "{\"EquipmentNo\":\"862095026033099\",\"UserId\":\"1809324b-4577-4602-85ce-b748b6ee0468\",\"Condition\":{\"ErrorMsg\":\"SUPPORTED_64_BIT_ABISu003d[Ljava.lang.String;@ea0909enversionCodeu003d22nBOARDu003dmx4nBOOTLOADERu003dunknownnTYPEu003dusernIDu003dLMY47InTIMEu003d1459133668000nBRANDu003dMeizunTAGu003dBuildnSERIALu003d75VBBKS22DG9nHARDWAREu003dmt6595nSUPPORTED_ABISu003d[Ljava.lang.String;@1ea1e77fnCPU_ABIu003darmeabi-v7anRADIOu003dunknownnIS_DEBUGGABLEu003dfalsenMANUFACTURERu003dMeizunSUPPORTED_32_BIT_ABISu003d[Ljava.lang.String;@cbfbed9nTAGSu003dtest-keysnCPU_ABI2u003darmeabinUNKNOWNu003dunknownnUSERu003dflymenFINGERPRINTu003dMeizu/meizu_mx4/mx4:5.1/LMY47I/1459133554:user/test-keysnHOSTu003dMz-Builder-l6nPRODUCTu003dmeizu_mx4nversionNameu003d2.0.8nDISPLAYu003dFlyme OS 5.1.4.0AnMODELu003dMX4nDEVICEu003dmx4njava.lang.RuntimeException: Unable to start receiver com.zhifu.finance.smartcar.receiver.JPushReceiver: java.lang.NullPointerException: Attempt to invoke virtual method u0027java.lang.Object java.util.Stack.lastElement()u0027 on a null object referencentat android.app.ActivityThread.handleReceiver(ActivityThread.java:2914)ntat android.app.ActivityThread.access$1700(ActivityThread.java:178)ntat android.app.ActivityThread$H.handleMessage(ActivityThread.java:1616)ntat android.os.Handler.dispatchMessage(Handler.java:111)ntat android.os.Looper.loop(Looper.java:194)ntat android.app.ActivityThread.main(ActivityThread.java:5773)ntat java.lang.reflect.Method.invoke(Native Method)ntat java.lang.reflect.Method.invoke(Method.java:372)ntat com.android.internal.os.ZygoteInit$MethodAndArgsCaller.run(ZygoteInit.java:1005)ntat com.android.internal.os.ZygoteInit.main(ZygoteInit.java:800)nCaused by: java.lang.NullPointerException: Attempt to invoke virtual method u0027java.lang.Object java.util.Stack.lastElement()u0027 on a null object referencentat com.zhifu.finance.smartcar.AppManager.currentActivity(AppManager.java:44)ntat com.zhifu.finance.smartcar.receiver.JPushReceiver.notifyMsg(JPushReceiver.java:156)ntat com.zhifu.finance.smartcar.receiver.JPushReceiver.onReceive(JPushReceiver.java:56)ntat android.app.ActivityThread.handleReceiver(ActivityThread.java:2907)nt... 9 morenjava.lang.NullPointerException: Attempt to invoke virtual method u0027java.lang.Object java.util.Stack.lastElement()u0027 on a null object referencentat com.zhifu.finance.smartcar.AppManager.currentActivity(AppManager.java:44)ntat com.zhifu.finance.smartcar.receiver.JPushReceiver.notifyMsg(JPushReceiver.java:156)ntat com.zhifu.finance.smartcar.receiver.JPushReceiver.onReceive(JPushReceiver.java:56)ntat android.app.ActivityThread.handleReceiver(ActivityThread.java:2907)ntat android.app.ActivityThread.access$1700(ActivityThread.java:178)ntat android.app.ActivityThread$H.handleMessage(ActivityThread.java:1616)ntat android.os.Handler.dispatchMessage(Handler.java:111)ntat android.os.Looper.loop(Looper.java:194)ntat android.app.ActivityThread.main(ActivityThread.java:5773)ntat java.lang.reflect.Method.invoke(Native Method)ntat java.lang.reflect.Method.invoke(Method.java:372)ntat com.android.internal.os.ZygoteInit$MethodAndArgsCaller.run(ZygoteInit.java:1005)ntat com.android.internal.os.ZygoteInit.main(ZygoteInit.java:800)n\"},\"UpdateTimeStamp\":\"0\",\"ClientType\":\"1\",\"ToKen\":\"SopU3YJagO/bCBEG9JdEIngGeuMYxbsrzS8SyFNngFTKaOsnrA5zQX9XWz1xxlym\",\"AppVersion\":22,\"DeviceToKen\":\"ffffffff-90ee-a700-a1fd-8f5c00000000\",\"RequestTimeStamp\":\"0\"}";
            //string apiName = "ZF/Message/MessageReportingCollectionPost";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);

            //var dt = TimeStampHelper.GetTime(1476341516);
            //var dt2 = TimeStampHelper.GetTime(1476341517);
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
            //string baseAddress = "http://10.1.32.73:9090/";//朱鹏
            //string baseAddress = "http://10.1.32.42/"; //石久银
            string baseAddress = "http://localhost:38923/";//本地local地址

            //string baseAddress = "http://tservice.zhihuiqiche.com";//测试服
            //string baseAddress = "http://int.dpool.sina.com.cn/";
            //string baseAddress = "http://rest.zhihuiqiche.com/";//正式服
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
