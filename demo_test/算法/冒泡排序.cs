using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class 冒泡排序
    {
        static void Main(string[] args)
        {
            int[] arrys = { 9, 0, 54, 1, 3, 2, 22, 12, 2432, 7, 6 };
            
            for (int i = 0; i < arrys.Length; i++)
            {
                for (int j = i; j < arrys.Length; j++)
                {
                    if (arrys[j] < arrys[i])
                    {
                        int d = arrys[i];
                        arrys[i] = arrys[j];
                        arrys[j] = d;
                    }
                }
            }

            Console.WriteLine("============排序后============");
            foreach (var item in arrys)
            {
                Console.WriteLine(item);
            }
        }
    }
}
