using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace test
{
    class erpAPP
    {
        static void Main(string[] args)
        {
            ERPRequest reqObj = new ERPRequest();
            #region 接口测试

            #region 登录
            //reqObj.type = "At_Com_User";
            //reqObj.sEquipmentNo = "";
            //reqObj.iSource = 1;
            //reqObj.model = new
            //{
            //    FNumber = "80002860",
            //    FPassword = "",
            //    DXCode = ""
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny1";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 根据员工号发送短信
            //reqObj.sWxOpenId = "";
            //reqObj.sToken = "";
            //reqObj.type = "At_Com_User";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    sNumber = "80002620"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny2";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 修改密码
            //reqObj.sToken = "a304a1585c6629c139fabed18eddbc6f";
            //reqObj.type = "At_Com_User";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    sSMSCode = "6639",
            //    sNewPassWord = "1"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny3";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 员工信息查询
            //reqObj.sToken = "09c2b464c7af253503f82bbb6c483080";
            //reqObj.type = "At_Com_User";
            //reqObj.iSource = 4;
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny4";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 业务员模糊查询
            //reqObj.sToken = "c156c4fac4d296ce6f5b34182e0841c9";
            //reqObj.type = "At_Com_User";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    KeyWords = ""
            //};
            //reqObj.page = new
            //{
            //    PageIndex = 1,
            //    PageSize = 10
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny5";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 单据相关图片信息查询
            //reqObj.sToken = "e7da35ba7c21b2616c15b7fa82b2107a";
            //reqObj.type = "At_DK_Annex";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    FBillType = 30,
            //    FBillID = 8691
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string requestJson = "{\"type\":\"At_DK_Annex\",\"model\":{\"FBillType\":30,\"FBillID\":8800},\"page\":{\"PageIndex\":1,\"PageSize\":0,\"OrderBy\":\"\"},\"sUserNo\":\"\",\"iClientType\":1,\"sAppVersion\":\"1.0\",\"sEquipmentNo\":\"351694067539499\",\"iSource\":4,\"sWxOpenId\":\"\",\"sToken\":\"\"}";
            //string apiName = "api/Base/DoAny1";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 文件管理器图片上传
            //reqObj.sToken = "e7da35ba7c21b2616c15b7fa82b2107a";
            //reqObj.type = "At_DK_Annex";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    FID = 0,
            //    FBillType = 30,
            //    FBillID = 8800,
            //    FName = "大王卡-123.png",
            //    FGUID = "123xxxxxxx",
            //    FKByte = 50000,
            //    FParth = "/ZhiFuERP_APP/IMG/2017//6//6",
            //    FOperator = 3949
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 申请单查询
            //reqObj.sToken = "6507006fd9861ab7be8d0c97b2856091";
            //reqObj.type = "V_DK_IntentApply";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    iFid = 0,
            //    sKeyWord = "",
            //    sFApproval_FK = "",
            //    sFPreset7 = "",
            //    sFApproval = "",
            //};
            //reqObj.page = new
            //{
            //    PageIndex = 1,
            //    PageSize = 10
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string requestJson = "{\"type\":\"V_DK_IntentApply\",\"page\":{\"PageIndex\":1,\"PageSize\":10,\"OrderBy\":\"\"},\"model\":{\"sKeyWord\":\"\",\"sFApproval_FK\":\"审批中\",\"sFPreset7\":\"已弃贷\",\"sFApproval\":\"未通过\"},\"sUserNo\":\"\",\"iClientType\":1,\"sAppVersion\":\"1.0\",\"sEquipmentNo\":\"351694067539499\",\"iSource\":0,\"sWxOpenId\":\"\",\"sToKen\":\"086e7933293fd3da42450708e0dc336e\"}";
            //string apiName = "api/Base/DoAny";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 申请单提交
            //reqObj.sToken = "6507006fd9861ab7be8d0c97b2856091";
            //reqObj.type = "V_DK_IntentApply";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    iFid = 1111,
            //    sKeyWord = "鹏",
            //    sFApproval_FK = "",
            //    sFPreset7 = "",
            //    sFApproval = "",
            //};
            //reqObj.page = new
            //{
            //    PageIndex = 1,
            //    PageSize = 10
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string requestJson = "{\"type\":\"V_DK_IntentApply\",\"model\":{\"Fid\":0,\"FYWType\":46,\"JKRType\":0,\"FLaiYuan\":\"同行转单\",\"FJKLeiBie\":22,\"FYongTu\":13,\"FJKAmount\":100.0,\"FQiXian\":27,\"FJKMiaoShu\":\"1111\",\"FMemo\":\"22222\",\"iFPreset9\":749,\"FName\":\"王佑君\",\"FCardType\":765,\"FCardID\":\"18642077249\",\"FSex\":\"男\",\"FAge\":25,\"FPhone\":\"18817509881\",\"FMarital\":62,\"FGongYang\":7,\"FHJAddress\":\"zhifu\",\"FXueLi\":101,\"FZZTel\":\"17717509881\",\"FZZAddress\":\"baoshan\",\"FQSJZDate\":\"2017年06月07\",\"FLBDYear\":2010,\"FFCLeiBie\":87,\"FYueZu\":10900.0,\"FGYType\":40,\"FYLBaoXian\":0,\"FRSBaoXian\":1,\"FJJCard1\":\"62209888881231456\",\"Z2BankId\":0,\"sEmail\":\"1121927879@qq.com\",\"FPreset3\":\"\",\"FDanWei\":\"Zhifu360\",\"FDWXingZhi\":97,\"FHangYe\":107,\"FZhiWu\":83,\"FBuMen\":\"Yanfabu\",\"FSWDJZNum\":\"4322122\",\"FYYZZNum\":\"212222333\",\"FPosNum\":\"ff3e333\",\"FDGZHNum\":\"2edf33\",\"FQSFWDate\":\"2017-06-09\",\"FGZYear\":34,\"FDWAddress\":\"Baoshanheyuanmingcheng\",\"FDWTel\":\"12306\",\"FXinJin\":100000.0,\"FQTShouRu\":100000.0,\"FZShouRu\":200000.00,\"FSheBao\":1,\"FGongJiJin\":1,\"FPOName\":\"Zyz1\",\"FPOGuanXi\":\"111\",\"FPOPhone\":\"22222\",\"FPODW\":\"33333\",\"FQQName\":\";lkljkj\",\"FQQGuanXi\":\"111\",\"FQQPhone\":\"111\",\"FQQDW\":\"1111\",\"FJJName\":\"Hhh13\",\"FJJGuanXi\":\"4554\",\"FJJPhone\":\"4554\",\"FJJDW\":\"4555\",\"FJRZhiXiao\":0,\"FLiKai\":0,\"FFaDongJiNum\":\"111111\",\"FCheJiaNum\":\"11111\",\"FLicense\":\"1111\",\"FSYXingZhi\":48,\"FGMDate\":\"2017-07-08\",\"FPinPai\":\"本田\",\"FModel\":\"雅阁\",\"CarStyle\":\"2007款\",\"CarType\":\"三厢\",\"FChanDI\":\"广汽本田\",\"FColor\":\"11\",\"FZuoWei\":0,\"FKilometer\":11.0,\"FPaiLiang\":\"2.0L\",\"FRegisterDate\":\"2017-06-09\",\"FBuyPrice\":111.0,\"FPreset1\":\"2007年生产\",\"InsDueDate\":\"2017-06-08\",\"t1_FPreset8\":48,\"FCiShu\":1,\"FReferrer\":\"1\",\"FKeFu\":3927,\"FSalesman\":0,\"FManager\":0},\"page\":{\"PageIndex\":1,\"PageSize\":0,\"OrderBy\":\"\"},\"sUserNo\":\"\",\"iClientType\":2,\"sAppVersion\":\"1\",\"sEquipmentNo\":\"1F56181D-81C3-4260-8315-C449F89EAE02\",\"iSource\":4,\"sWxOpenId\":\"\",\"sToKen\":\"ee862cbb32a57b0b4436c85d4095e612\"}";
            ////int b = requestJson.Length;
            //string apiName = "api/Base/DoAny1";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 单据状态查询
            //reqObj.sToken = "6507006fd9861ab7be8d0c97b2856091";
            //reqObj.type = "V_DK_IntentApply";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    iFid = 1111
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny2";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 金账户开户查询接口
            //reqObj.sToken = "e7da35ba7c21b2616c15b7fa82b2107a";
            //reqObj.type = "V_DK_IntentApply";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    sName = "张亚洲",
            //    sIdNumber = "421181199005287658"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            ////string requestJson = "{\"type\":\"V_DK_IntentApply\",\"model\":{\"sName\":\" 许青\",\"sIdNumber\":\"340823199105170434\"},\"page\":{\"PageIndex\":1,\"PageSize\":0,\"OrderBy\":\"\"},\"sUserNo\":\"\",\"iClientType\":2,\"sAppVersion\":\"1\",\"sEquipmentNo\":\"38E37A2B-11E7-4968-9DF2-112055E66F84\",\"iSource\":4,\"sWxOpenId\":\"\",\"sToKen\":\"ee862cbb32a57b0b4436c85d4095e612\"}";
            //string apiName = "api/Base/DoAny3";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 基础数据查询
            //reqObj.sToken = "6507006fd9861ab7be8d0c97b2856091";
            //reqObj.type = "ConfigInfo";
            //reqObj.iSource = 4;
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 车辆车架号详细查询
            //reqObj.sToken = "6507006fd9861ab7be8d0c97b2856091";
            //reqObj.type = "V_DK_IntentApply";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    VIN = "LHGGK5854G8003829"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny4";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 文件管理器文件小分类信息查询
            //reqObj.sToken = "6507006fd9861ab7be8d0c97b2856091";
            //reqObj.type = "At_DK_Annex";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    iLoanTypeId = 1,
            //    iBillType = 30
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny2";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 图片管理器删除图片
            //reqObj.sToken = "6507006fd9861ab7be8d0c97b2856091";
            //reqObj.type = "At_DK_Annex";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    iFid = 961398
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny3";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 图片管理器文件小分类信息查询
            //reqObj.sToken = "23848800a337cab67d4bbecb0836a5ab";
            //reqObj.type = "At_DK_Annex";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    iLoanTypeId = 1,
            //    iBillType = 8779
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny2";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 违章查询
            //reqObj.sToken = "6507006fd9861ab7be8d0c97b2856091";
            //reqObj.type = "V_DK_IntentApply";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    CarDriveNumber = "27294631974198",  //发动机
            //    CarCode = "WDDNG5EB5CA440714",
            //    CarNumber = "苏E238TU"
            //};
            ////string requestJson = "{\"type\":\"V_DK_IntentApply\",\"model\":{\"VIN\":\"LSGJT5D167H106722\"},\"page\":{\"PageIndex\":1,\"PageSize\":0,\"OrderBy\":\"\"},\"sUserNo\":\"\",\"iClientType\":1,\"sAppVersion\":\"1.0\",\"sEquipmentNo\":\"357523059879361\",\"iSource\":0,\"sWxOpenId\":\"\",\"sToken\":\"abac50ce23b864e02c9180b3d8837896\"}";
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny4";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 业务员业绩排名
            //reqObj.sToken = "d436b0e755b0878ac6a2ca6c72af6b47";
            //reqObj.type = "V_DK_SalesRanking";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //{
            //    iTimeType = 3,
            //    iRangeType = 1,
            //    iRangeId = 26,
            //    bSale = true
            //};
            //reqObj.page = new
            //{
            //    PageIndex = 1,
            //    PageSize = 10
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            ////string requestJson = "{\"type\":\"V_DK_SalesRanking\",\"model\":{\"bSale\":false,\"iTimeType\":3,\"iRangeType\":0,\"iRangeId\":2},\"page\":{\"PageIndex\":1,\"PageSize\":10,\"OrderBy\":\"\"},\"sUserNo\":\"\",\"iClientType\":1,\"sAppVersion\":\"1.0\",\"sEquipmentNo\":\"357523059879361\",\"iSource\":0,\"sWxOpenId\":\"\",\"sToKen\":\"eb7d1285a4b8871ff3f6b9a203b32e19\"}";
            //string apiName = "api/Base/DoAny";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 代码测试
            //DateTime startTime = GetTimeStartByType(2);
            //Console.WriteLine(startTime);

            //DateTime dateTime;
            //DateTime.TryParse("2017-05-08 00:00:11.000", out dateTime);

            //DateTime beginDate = DateTime.Parse("2017-05-08");
            //DateTime db = DateTime.Parse("2017-05-08 00:00:11.000");
            //if (dateTime < beginDate)
            //{
            //    Console.WriteLine("xx");
            //}
            //else
            //{
            //    Console.WriteLine("dddd");
            //}
            ////int dqfq = ConvertHelper.StrToInt("12".Substring("12".Length - 2), 0) - 10;
            //List<string> list = new List<string>
            //{
            //    "98457,61567","123","sfsdfsdf","98457,61567,6797","98457,61567"
            //};
            //var list2 = list.Distinct();
            //string a = string.Join(",", list2);
            //var list3 = a.Split(',').Distinct();
            #endregion

            #region 还款服务测试
            //DK_RepaymentDetailService pDK_RepaymentDetailService = new DK_RepaymentDetailService();
            //string s = "";
            //t_DK_Z1Repayment_In sQin = JsonConvert.DeserializeObject<t_DK_Z1Repayment_In>(s);
            //pDK_RepaymentDetailService.Repayment(sQin);
            #endregion

            #region 违章查询
            //reqObj.sToken = "";
            //reqObj.type = "Che300_BuyReport_In";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //    {
            //        car_no = "琼A72L56"
            //    };
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 权限模块
            //reqObj.sToken = "23848800a337cab67d4bbecb0836a5ab";
            //reqObj.type = "V_UserPositionModelRight";
            //reqObj.iSource = 4;
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 文件管理器
            //reqObj.sToken = "";
            //reqObj.type = "At_DK_Annex";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //    {
            //        car_no = "琼A72L56"
            //    };
            //string requestJson = "{\"type\":\"At_DK_Annex\",\"model\":{\"FID\":0,\"FBillType\":0,\"FBillID\":0,\"FName\":\"31身份证8620950260330991496223267000.jpg\",\"FKByte\":0,\"FParth\":\"ZhiFuERP_APP/IMG/2017//05\",\"FOperator\":0,\"FGUID\":\"6e54ca86-b28b-42b1-aee4-b56247627765\"},\"page\":{\"PageIndex\":1,\"PageSize\":0,\"OrderBy\":\"\"},\"sUserNo\":\"\",\"iClientType\":1,\"sAppVersion\":\"1.0\",\"sEquipmentNo\":\"862095026033099\",\"iSource\":4,\"sWxOpenId\":\"\",\"sToken\":\"086e7933293fd3da42450708e0dc336e\"}";
            //string apiName = "api/Base/DoAny";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region doany
            //reqObj.sToken = "";
            //reqObj.type = "CxyPeccancyQuery_In";
            //reqObj.iSource = 4;
            //reqObj.model = new
            //    {
            //        //name = "111",
            //        //idnum = "465464",
            //        //mobile = "1212313"

            //        CarDriveNumber = "LDCP11245H4008080",
            //        CarCode = "9088453",
            //        CarNumber = "皖CZY545"
            //    };
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            //DateTime st = DateTime.Parse("2017-5-27 14:55:00");
            //DateTime et = DateTime.Parse("2017-5-27 15:58:00");
            //string f = (et - st).TotalMinutes.ToString("N0");
            #endregion

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
            //string baseAddress = "http://10.1.32.73:7080/";//本地IIS地址
            string baseAddress = "http://10.1.39.202:60001/";//测试服
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

        //发送消息到服务器
        private static string HttpConnectToServer(string ServerPage, string postData)
        {
            byte[] dataArray = Encoding.Default.GetBytes(postData);
            //创建请求
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(ServerPage);
            request.Method = "POST";
            request.ContentLength = dataArray.Length;
            request.ContentType = "application/x-www-form-urlencoded";
            //创建输入流
            Stream dataStream = null;
            try
            {
                dataStream = request.GetRequestStream();
            }
            catch (Exception e)
            {
                return null;//连接服务器失败
            }
            //发送请求
            dataStream.Write(dataArray, 0, dataArray.Length);
            dataStream.Close();
            //读取返回消息
            string res = string.Empty;
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                res = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception ex)
            {
                return null;//连接服务器失败
            }
            return res;
        }

        #region 获取 本周、本月、本年的开始时间或结束时间
        /// <summary>
        /// 获取结束时间
        /// </summary>
        /// <param name="TimeType">Week、Month、Year</param>
        /// <returns></returns>
        public static DateTime GetTimeStartByType(int TimeType)
        {
            DateTime now = DateTime.Now;
            switch (TimeType)
            {
                case 1:
                    //本周开始时间
                    return now.AddDays(-(int)now.DayOfWeek + 1);
                case 2:
                    //本月开始时间
                    return now.AddDays(-now.Day + 1);
                case 3:
                    //本年开始时间
                    return now.AddDays(-now.DayOfYear + 1);
                default:
                    break;
            }
            return now;
        }

        /// <summary>
        /// 获取结束时间
        /// </summary>
        /// <param name="TimeType">Week、Month、Year</param>
        /// <returns></returns>
        public static DateTime GetTimeEndByType(int TimeType)
        {
            DateTime now = DateTime.Now;
            switch (TimeType)
            {
                case 1:
                    //本周结束时间
                    return now.AddDays(7 - (int)now.DayOfWeek);
                case 2:
                    //本月结束时间
                    return now.AddMonths(1).AddDays(-now.AddMonths(1).Day + 1).AddDays(-1);
                case 3:
                    //本年结束时间
                    var time2 = now.AddYears(1);
                    return time2.AddDays(-time2.DayOfYear);
                default:
                    break;
            }
            return now;
        }
        #endregion
    }

}
