using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class 递归
    {
        enum Sj
        {
            ri = 0,
            yi = 1,
            er = 2,
            sa = 3,
            si = 4,
            wu = 5,
            li = 6
        }

        static void Main(string[] args)
        {
            #region 枚举          
            //Console.WriteLine("请输入一个数字:");
            //int i = Convert.ToInt32(Console.ReadLine());
            //switch (i)
            //{
            //    case (int)Sj.ri: Console.WriteLine("星期天");
            //        break;
            //    case (int)Sj.yi: Console.WriteLine("星期1"); 
            //        break;
            //    case (int)Sj.er: Console.WriteLine("星期2"); 
            //        break; 
            //    case (int)Sj.sa: Console.WriteLine("星期3"); 
            //        break; 
            //    case (int)Sj.si: Console.WriteLine("星期4"); 
            //        break; 
            //    case (int)Sj.wu: Console.WriteLine("星期5"); 
            //        break; 
            //    case (int)Sj.li: Console.WriteLine("星期6"); 
            //        break;
            //    default:
            //        Console.WriteLine("输入1-7范围的数");
            //        break;
            //}
            #endregion

            //随机数
            //int[] a = RandomInt();
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            //随机数2
            //char[] b = RandomString();
            //foreach (char item in b)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(GetChickenSum(20));
        }

        //获取小鸡数量
        public static int GetChickenSum(int count)
        {
            if (count == 0)
            {
                return 1;
            }
            else
            {
                return 2 * GetChickenSum(count - 1);
            }
        }

        //递归算法
        public static int Foo(int i)
        {
            if (i == 0)
            {
                return 0;
            }
            else if (i > 0 && i <= 2)
            {
                return 1;
            }
            else
            {
                return Foo(i - 1) + Foo(i - 2);
            }
        }

        //总和
        public static int Sum(int i)
        {
            if (i == 0)
                return 0;
            else
                return Sum(i - 1) + i;
        }

        //阶乘
        public static int Result(int i)
        {
            if (i == 0)
                return 0;
            else if (i == 1)
                return 1;
            else
                return Result(i - 1) * i;
        }

        public static int[] RandomInt()
        {
            int[] arry = new int[10];
            Random rm = new Random();
            for (int i = 0; i < arry.Length; i++)
            {
                arry[i] = rm.Next(0, 100);
            }
            return arry;
        }

        //随机生成1-9 and a-z10个随机数加入一个数组
        public static char[] RandomString()
        {
            char[] str = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] b = new char[10];
            Random rm = new Random();
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = str[rm.Next(0, 35)];
            }
            return b;
        }
    }
}
