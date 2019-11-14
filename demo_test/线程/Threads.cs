using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test
{
    class Threads
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(() =>
            {
                Console.WriteLine("我正在运行中~~");
            });

            th.Name = "我是第一个线程";

            //Thread.Sleep(5);
            th.Start();

            Console.WriteLine(Thread.CurrentThread.Name);

            Console.WriteLine("12313");

            //Task task = Task.Run(() =>
            //{

            //});
        }

        public static void zhix()
        {
            Console.WriteLine("entrust console!");
        }

        public delegate void weituo(string a);

        public static void weituody(string a)
        {
            Console.WriteLine(a);
        }
    }
}
