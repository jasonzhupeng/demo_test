using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace demo_test
{
    class test
    {
        static void Main(string[] args)
        {
            //"^wandawealth-abcdefghjk0987654321-1";
            string zz = "wandawealth-abcdefghjk0987654321-1";   
            string rr = @"^wandawealth-([a-z]{10}[0-9]{10})-1$";
            if (Regex.IsMatch(zz, rr))
            {
                Console.WriteLine("匹配！！！");
            }
            else
            {
                Console.WriteLine("不匹配");
            }
        }
    }
}
