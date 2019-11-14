using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace test
{
    class erp
    {
        static void Main(string[] args)
        {
            ERPRequest reqObj = new ERPRequest();

            #region webservice测试

            #region 测试
            //string requestJson = "";
            //string apiName = "/api/ShouXinyi/DoAny";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 通用放款
            //loanDetailService.DK_LoanDetailServiceSoapClient loan = new DK_LoanDetailServiceSoapClient();
            //At_DK2_Account param = new At_DK2_Account
            //{
            //    USER_REG = "13167112233",
            //    MOBILE = "13167112233",
            //    ID_TYPE = "01",
            //    ID_NO = "431026155211151117",
            //    USER_NAME = "jason",
            //    ACC_NAME = "jason",
            //    ACC_BANK = "中国建设银行股份有限公司",
            //    ACC_NUM = "1234567890"
            //};
            //ResObj res = loan.SyncUser(param);
            //DepartmentService s = new DepartmentService();
            //s.GetData();
            #endregion

            #region 智富代垫

            //pDK_ExtensionService.DK_ExtensionServiceSoapClient ex = new pDK_ExtensionService.DK_ExtensionServiceSoapClient();
            //var s= ex.RepaymentByZhiFu(40);

            #endregion

            #region webservicetest
            //testWEb.WeatherWebServiceSoapClient a = new testWEb.WeatherWebServiceSoapClient("WeatherWebServiceSoap");
            //var test = a.getWeatherbyCityName("上海");
            //string b = string.Join(",", test);
            //loanDetailService.DK_LoanDetailServiceSoapClient b = new loanDetailService.DK_LoanDetailServiceSoapClient();
            //var s = b.List(0, string.Empty);

            ////Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("abc","212313");
            //dic.Add("edf", "66666");

            //var a = new
            //{
            //    PageIndex = 1,
            //    CarName = "bmw"
            //};
            //dic.Add("Condition", a.ToString());
            //var s = JsonConvert.SerializeObject(dic);
            //string b = dic["edf"];
            //var c = JsonConvert.DeserializeObject(s);
            //StringBuilder sb = new StringBuilder();
            //sb.AppendFormat("test {0} ssss {1} ", "哈哈", "呵呵");
            //string b = sb.ToString();
            //dkContract.DK_ContractServiceSoapClient a = new dkContract.DK_ContractServiceSoapClient();
            //a.ListData(0, string.Empty);
            //string str = "{\"resp_code\":\"0002\",\"resp_msg\":\"\u8d26\u53f7\u6216\u5bc6\u7801\u9519\u8bef\",\"resp_data\":\"\"}";
            //string v = Regex.Unescape(str);

            #endregion

            #endregion

            #region 接口测试

            #region 登录，注册
            //reqObj.sAppVersion = "8.0.0.0";
            //reqObj.sEquipmentNo = "";
            //reqObj.iSource = 1;
            //reqObj.model = new
            //{
            //    sMobile = "18501746654",
            //    sCode = "",
            //    sPassWord = "123"
            //};
            //reqObj.page = new
            //{
            //    PageIndex = 1,
            //    PageSize = 0,
            //    OrderBy = ""
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny1";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 客户端错误日志上报
            //            reqObj.sAppVersion = "1.0";
            //            reqObj.sEquipmentNo = "xd1dfgar41fxa";
            //            reqObj.sUserNo = "810012816";
            //            reqObj.type = "ClientLogFile";
            //            reqObj.model = new
            //            {
            //                sErrorLog = @"中共中央总书记、国家主席、[wrap]中央军委主席、中央财经领导小组组长习近平12月21日下午主持召开中央财经领导小组第十四次会议，研究“十三五”规划纲要确定的165项重大工程项目进展和解决好人民群众普遍关心的突出问题等工作。习近平发表重要讲话强调，准确把握全面建成小康社会内涵，对实现第一个百年奋斗目标至关重要。全面建成小康社会，在保持经济增长的同时，更重要的是落实以人民为中心的发展思想，想群众之所想、急群众之所急、解群众之所困，在学有所教、劳有所得、病有所医、老有所养、住有所居上持续取得新进展。
            //            　　                          中共中央政治局常委、国务院总理、中央财经领导小组副组长李克强，[wrap]中共中央政治局常委、中央书记处书记、中央财经领导小组成员刘云山，中共中央政治局常委、国务院副总理、中央财经领导小组成员张高丽出席会议。
            //            　　                          会议听取了国家发展改革委关于“十三五”[wrap]规划纲要确定的165项重大工程项目进展 情况的汇报，分别听取了国家能源局关于推进北方地区冬季清洁取暖、浙江省关于普遍推行垃圾分类制度、农业部关于畜禽养殖废弃物处理和资源化、民政部关于提高养老院服务质量、住房城乡建设部关于规范住房租赁市场和抑制房地产泡沫、国家食品药品监管总局关于加强食品安全监管等 的汇报。领导小组成员进行了讨论。"
            //            };
            //            string requestJson = JsonConvert.SerializeObject(reqObj);
            //            string apiName = "api/Base/DoAny1";
            //            string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //            Console.WriteLine(resultJson);
            #endregion

            #region 发送短信验证码
            //reqObj.type = "SMS";
            //reqObj.model = new
            //{
            //    iCaller = 3,
            //    sMobile = "13167119270",
            //    iType = 0,
            //    iSendType = 100,
            //    iTplId = 34013,
            //    sTplVal = "#Name#=许青&#Account#=2583.33&#date#=06月08日&#CardNumber#=9593&#BankName#=上海浦东发展银行"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            ////string requestJson = "{\"type\":\"SMS\",\"page\":{\"PageIndex\":1,\"PageSize\":0,\"OrderBy\":\"\"},\"model\":{\"iCaller\":1,\"sMobile\":13167119270,\"iSendType\":101,\"iType\":0},\"sUserNo\":\"\",\"iClientType\":1,\"sAppVersion\":\"1\",\"sEquipmentNo\":\"868649025985768\",\"iSource\":1,\"sWxOpenId\":\"\"}";
            //string apiName = "api/Base/DoAny1";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //string a = "";
            #endregion

            #region 实名认证
            //reqObj.model = new
            //{
            //    sToken = "ee060b00b32f0ef08e13344e2eeace66",
            //    sRealName = "朱鹏",
            //    sIdNumber = "431026199211191114"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);

            //string requestJson = "{\"type\":\"Member\",\"model\":{\"sToken\":\"\",\"sRealName\":\"董昭壮\",\"sIdNumber\":\"371082197605206716\"},\"page\":{\"PageIndex\":1,\"PageSize\":0,\"OrderBy\":\"\"},\"sUserNo\":\"\",\"iClientType\":4,\"sAppVersion\":\"8.0.1\",\"sEquipmentNo\":\"\",\"iSource\":1,\"sWxOpenId\":\"ogBbSsqhENdF15N2tJTzHv9CXfxQ\",\"sToken\":\"\"}";
            //string apiName = "api/Base/DoAny";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //string b = resultJson;
            #endregion

            #region 邮箱认证
            //reqObj.model = new
            //{
            //    sToken = "e28030c18ea05ecc7c3498c7036d0557",
            //    sEmail = "zhupeng@zhifu360.com",
            //    sCode = "103817"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny2";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 邮箱验证码发送
            //reqObj.model = new
            //{
            //    sToken = "76a32078c6222bbd2590aae04e9612ef",
            //    sEmail = "xuqing01@zhifu360.com"    //zhupeng@zhifu360.com
            //};

            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny4";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 邮箱是否已绑定
            //reqObj.model = new
            //{
            //    sToken = "2da5334370cdccbb4f6a88f4914dd9b5"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny5";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 用户中心
            //reqObj.sWxOpenId = "";
            //reqObj.model = new
            //{
            //    sToken = "1",
            //    PageIndex = 11,
            //    PageSize = 1
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            ////string requestJson = "{\"type\":\"Member\",\"model\":{\"sToken\":\"2da5334370cdccbb4f6a88f4914dd9b5\",\"PageIndex\":0,\"PageSize\":0},\"page\":{\"PageIndex\":1,\"PageSize\":0,\"OrderBy\":\"\"},\"sUserNo\":\"\",\"iClientType\":2,\"sAppVersion\":\"1\",\"sEquipmentNo\":\"720A1EF8-87A1-4939-89A5-20135101B7DA\",\"iSource\":1,\"sWxOpenId\":\"\"}";
            //string apiName = "api/Base/DoAny3";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName, isDecode: false);
            #endregion

            #region 金账户企业开户省市区查询
            //reqObj.type = "ZFDGold";
            //reqObj.model = new
            //{
            //    iProvinceId = 0   //上海 {\"iId\":16,\"sCityName\":\"上海市\",\"sCityCode\":\"310\"}
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny4";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 金账户企业开户支持银行查询
            //reqObj.type = "ZFDGold";
            ////string requestJson = JsonConvert.SerializeObject(reqObj);
            //string requestJson = "{\"type\":\"ZFDGold\",\"model\":{},\"page\":{\"PageIndex\":1,\"PageSize\":0,\"OrderBy\":\"\"}}";
            //string apiName = "api/Base/DoAny5";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 金账户企业信息查询
            //reqObj.type = "ZFDGold";
            //reqObj.model = new
            //{
            //    sToken = "304d76af64caf063621b555b4f7b33d2"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny3";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 金账户企业开户
            //reqObj.type = "ZFDGold";
            //reqObj.model = new
            //{
            //    sToken = "e103f3ecad44e0bdf29d66c363734eb4",
            //    sCustNm = "上海奥莉粑粑碗大科技有限公司",					//企业名称
            //    sArtifNm = "干干",                                //法人名称
            //    sCertifId = "320681199105160833",                //证件号
            //    sMobielNo = "13167119274",                       //手机号
            //    sCityId = "2900",  //"310",                                 //开户行地区码（城市代码）
            //    sParentBankId = "0103",                                 //提现银行卡行别（银行代码） {\"bank_name\":\"中国建设银行\",\"bank_code\":\"0105\"}
            //    sBankNm = "上海建设银行长逸路支行",           //支行名称
            //    sCapAcntNo = "3217502245789744",              //账号（银行账号）
            //    sEmail = "zhupeng@zhifu360.com",                   //邮箱
            //    sPassword = "e10adc3949ba59abbe56e057f20f883e",    //提现密码
            //    sLppassword = "e10adc3949ba59abbe56e057f20f883e",  //登录密码
            //    sRemark = "企业开户！"                            //备注
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny1";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 金账户个人开户
            //reqObj.type = "ZFDGold";
            //reqObj.model = new
            //{
            //    sToken = "76c63e0f60401e499b7e39acf6cb8c6c",
            //    iClient = 1	//1:web端  2：ios 3:Android  4:微信
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny2";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 金账户充值
            //reqObj.type = "ZFDGold";
            //reqObj.model = new
            //{
            //    sToken = "c4cd079718d067c4bd87625deeed9cfd",
            //    //iClient = 3,	//1:web端  2：ios 3:Android  4:微信
            //    dMoney = 300.0
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName, isDecode: false);
            #endregion

            #region 金账户余额查询
            //reqObj.type = "ZFDGold";
            //reqObj.iClientType = 3;
            //reqObj.sAppVersion = "xyz.9.9.9";
            //reqObj.sEquipmentNo = "hahahahahah";
            //reqObj.iSource = 1;
            //reqObj.model = new
            //{
            //    sToken = "76c63e0f60401e499b7e39acf6cb8c6c"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/GetByOther";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName, isDecode: false);
            #endregion

            #region 车300精确估值
            ////reqObj.type = "INFC300";
            ////reqObj.model = new
            ////{
            ////    sModel = "2015款 大7 MPV 2.0T 精英型",
            ////    sDate = "2015年01月",
            ////    dMile = 30000,
            ////    sCity = "上海"
            ////};
            ////string requestJson = JsonConvert.SerializeObject(reqObj);
            //string requestJson = "{\"type\":\"INFC300\",\"model\":{\"sModel\":\"2012款 起亚K5 2.0L 自动 Premium 10周年特别版\",\"sDate\":\"2001-12-09\",\"dMile\":\"1.00\",\"sCity\":\"厦门\"},\"page\":{}}";
            //string apiName = "api/Base/GetByOther";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 门店城市列表
            //reqObj.type = "At_BC_OrganizationUnit";
            //reqObj.model = new
            //{
            //    iStoreType = 1
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 门店列表
            //reqObj.type = "At_BC_OrganizationUnit";
            //reqObj.page = new
            //{
            //    PageIndex = 0,
            //    PageSize = 0,
            //    OrderBy = ""
            //};
            //reqObj.model = new
            //{
            //    Fname = "",
            //    FAddress = "",
            //    city_name = "",
            //    iStoreType = 1
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/GetByOther";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 智1合规上标，智2放款申请借款人设备登录验证
            //reqObj.type = "V_MemberInfo";
            //reqObj.model = new
            //{
            //    sCertiNumber = "431026199211191114",
            //    sNames = "朱鹏",
            //    sMobile = "13167119270"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            //Console.WriteLine(resultJson);
            #endregion

            #region 提现
            //reqObj.type = "FuyouCashout";
            //reqObj.model = new
            //{
            //    sToken = "42fbc50a3d014f404ddc54c9f7f81bce"
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny2";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName, isDecode: false);
            #endregion

            #region T0提现
            //reqObj.type = "FuyouCashout";
            //reqObj.model = new
            //{
            //    sToken = "42fbc50a3d014f404ddc54c9f7f81bce",
            //    amount = 1
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName, isDecode: false);
            #endregion

            #region T1提现
            //reqObj.type = "FuyouCashout";
            //reqObj.model = new
            //{
            //    sToken = "42fbc50a3d014f404ddc54c9f7f81bce",
            //    amount = 1
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/Base/DoAny1";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName, isDecode: false);

            //string sds = "(0,3]";
            //bool c = sds.Contains("0,3");
            #endregion

            #endregion

            #region 图片上传
            //reqObj.type = "At_BC_OrganizationUnit";
            //reqObj.page = new
            //{
            //    PageIndex = 0,
            //    PageSize = 0,
            //    OrderBy = ""
            //};
            //reqObj.model = new
            //{
            //    Fname = "",
            //    FAddress = "",
            //    city_name = "",
            //    iStoreType = 1
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/UploadFile/Upload";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);
            #endregion

            #region 测试
            //reqObj.type = "At_BC_OrganizationUnit";
            //reqObj.page = new
            //{
            //    PageIndex = 0,
            //    PageSize = 0,
            //    OrderBy = ""
            //};
            //reqObj.model = new
            //{
            //    Fname = "",
            //    FAddress = "",
            //    city_name = "",
            //    iStoreType = 1
            //};
            //string requestJson = JsonConvert.SerializeObject(reqObj);
            //string apiName = "api/RemoteFile/UploadFile";
            //string resultJson = GetStringHttpClientJson(requestJson, apiName);

            //DateTime now = DateTime.Parse("2016-12-19 18:48:31");
            //DateTime n2 = DateTime.Parse("2016-12-19 18:55:31");
            //TimeSpan ts = n2 - now;
            //int n = ts.Minutes;//分差
            //string m = ts.TotalMinutes.ToString();//总时间分差


            //string b = "{\"amt\":30000,\"back_notify_url\":\"\",\"login_id\":\"18516268309\",\"mchnt_cd\":\"0002900F0096235\",\"mchnt_txn_ssn\":\"614821502288269480\",\"page_notify_url\":\"http:\\/\\/www.zhifu360.tom\\/Pay\\/app_bfreceive.html\",\"signature\":\"BOA6vLcSjyoWq1vGJbC5ZXXJvi9Sl8fWrGJ8BMwA+1UzmERBq5JKB5tX9tbKCYR+8OkDDqEWFKHmTozQjBsbHs5Tdk47VHGfho514ri0eLKjvB5AxxbIqnQSxrRSjz06sR8Z8bguuliI5O0lq9DdkWE\\/KJLSUjl6\\/PWMSL0i2Vs=\",\"form_url\":\"https:\\/\\/jzh-test.fuiou.com\\/jzh\\/app\\/500002.action\"}";


            //string a = Regex.Unescape(b);


            //string d = HttpUtility.UrlEncode(b);
            //string e = HttpUtility.UrlDecode(d);
            //var c = JsonConvert.DeserializeObject(e, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            //DateTime a = DateTime.Parse("2016-12-28 16:05:00");
            //DateTime b = DateTime.Parse("2016-12-27 16:00:00");
            //TimeSpan ts = a - b;

            //string[] dNames = { "FOrganizationName", "FCPType", "dyfName", "sxyAccount" };
            //int b = Array.IndexOf(dNames, "dyf22Name");

            //DateTime kk = ConvertHelper.ObjectToStartDate("2017-1-16", DateTime.MinValue);
            //int yqDays = (DateTime.Now -kk).Days;//逾期天数
            //string sMobile = "13167119270";
            //if (!Regex.IsMatch(sMobile, @"^1[3,4,5,7,8]\d{9}$"))
            //{
            //    Console.WriteLine("手机号格式错误");
            //}
            //else
            //{
            //    Console.WriteLine("手机号格式正确");
            //}

            //if (!Regex.IsMatch("431026199211140", @"^(\d{16}|\d{19})$"))
            //{
            //    Console.WriteLine("身份证号格式错误");
            //}
            //int fasf = Convert.ToInt32(1123 * 1.5);
            //int sf = fasf;
            //string sdf = "        ";
            //bool b = Equals(sdf.Trim(),"");
            //List<string> st = new List<string> { "测试1", "测试2", "测试3" };
            //List<string> st222 = new List<string>();
            //string sdfs = string.Join("！\r\n", st);
            //string path = Environment.CurrentDirectory + "\\rem.txt";
            //File.WriteAllText(path, "sdfs");

            //string nr = File.ReadAllText(path);

            string xmlss = JsonHelper.XmlSerialize<ERPRequest>(reqObj);

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
            //string baseAddress = "http://localhost:4493/";
            string baseAddress = "http://10.1.32.73:7080/";//本地IIS地址
            //string baseAddress = "http://10.1.39.202:50001";//测试服1
            //string baseAddress = "http://10.1.39.202:60001/";//测试服2
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
                    HttpContent content = new StringContent(strUtf8Condition);
                    HttpResponseMessage response = _httpClient.PostAsync(apiName, content).Result;
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
            //string postData = "strXml=" + strXml + "&strData=" + strData;
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
    }

}
