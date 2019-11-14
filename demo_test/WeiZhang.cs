using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    class WeiZhang
    {
        static void Main(string[] args)
        {
            JsonCommon reqObj = new JsonCommon();

            #region 违章城市查询
            //reqObj.Condition = new
            //{
            //    //PageIndex = 1,
            //    //sCityName = ""
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "ZF/Weizhang/WeizhangCity";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 违章车辆统计
            //string requestJson = "{\"Condition\":{\"sUserNo\":\"\",\"sDeviceKey\":\"e67e465b-5386-4dcd-bf01-7b6d18c04dfc\"},\"ClientType\":0,\"RequestTimeStamp\":0,\"UpdateTimeStamp\":0,\"UserId\":\"\",\"ToKen\":\"\",\"AppVersion\":\"\",\"DeviceToKen\":\"\",\"EquipmentNo\":\"\"}";
            //string apiName = "ZF/Weizhang/UserCarWeizhangQuery";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 添加车辆
            //reqObj.EquipmentNo = "867886021836261";
            //reqObj.UserId = "1809324b-4577-4602-85ce-b748b6ee0468";
            //reqObj.ToKen = "SopU3YJagO/bCBEG9JdEIngGeuMYxbsrzS8SyFNngFTKaOsnrA5zQX9XWz1xxlym";
            //reqObj.Condition = new
            //{
            //    sEngineno = "E01D04113",
            //    sFrameNo = "LNBMDLAA6EU009657",
            //    uId = "",
            //    sSeriesId = "98e50db6-9698-4e63-aa34-8230a8310b4b",
            //    sCarNum = "沪F56677",
            //    iUseCity = 120100,
            //    sNote = "老婆的车",
            //    sBrandId = "9a390372-0422-4b00-9222-4e623b97afd0",
            //    sUserNo = "810012609",
            //    sInsuranceDueDate = "2016-08-26",
            //    lCityId = 0,
            //    sOwner = "胡欢"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "ZF/Weizhang/UserCarSave";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 创建违章订单
            //string requestJson = "{\"Condition\":{\"sCarNo\":\"苏KY766M\",\"sBuyName\":\"13167119270\",\"sBuyTel\":\"\",\"iOrderSource\":4,\"dAmount\":296.00,\"dPlatformServiceCharge\":146.00,\"dSaleOff\":0.0,\"lSaleCardPoolId\":0,\"aDetails\":[{\"sRecordId\":\"730376146\",\"sProductCode\":\"ZQW2016063045917\",\"dPlatformServiceCharge\":73.00,\"dAmount\":100.00},{\"sRecordId\":\"730376147\",\"sProductCode\":\"ZQW2016063045918\",\"dPlatformServiceCharge\":73.00,\"dAmount\":50.00}]},\"ClientType\":4,\"RequestTimeStamp\":1474161454,\"UpdateTimeStamp\":0,\"UserId\":\"419308e7-b684-48ce-b4d6-b6a19215c503\",\"ToKen\":\"c9Hb73nMKGqFJ+dnZ0BPVHgGeuMYxbsrzS8SyFNngFTKaOsnrA5zQX9XWz1xxlym\",\"AppVersion\":\"2.0\",\"DeviceToKen\":\"00000000-0000-0000-0000-000000000000\",\"EquipmentNo\":\"a4592366-50b5-4541-bb3e-be99153214fd\"}";
            //string apiName = "ZF/Order/WeizhangOrderCreate";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 违章记录查询
            //reqObj.Condition = new
            //{
            //    sCarNum = "苏KY766M"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "ZF/Weizhang/WeizhangRecordList";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 车300城市查询
            //reqObj.Condition = new
            //{
            //    CityKeyWord = "厦门"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "ZF/INFC300/C300GetCityList";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 车系或车款查询
            //reqObj.Condition = new
            //{
            //    iQuery = 2,
            //    sQueryName = "2000款 PASSAT(进口) 1.8GLI 手动"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "ZF/INFC300/C300GetSeriesOrStyleList";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            //string str = TimeStampHelper.DES3Encrypt("测试");
            //string str2 = TimeStampHelper.DES3Decrypt("jrP3v1OmWfc=");
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
            //string baseAddress = "http://localhost:38923/";//本地local地址

            //string baseAddress = "http://tservice.zhihuiqiche.com";//测试服
            string baseAddress = "http://rest.zhihuiqiche.com/";//正式服
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
