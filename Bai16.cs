using System;
using System.Collections.Generic;

namespace ThuchanhCS
{
    class Bai16
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");

            Console.Write("\nNhap chuoi: ");
            string str = Console.ReadLine();

            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (count.ContainsKey(c))
                {
                    count[c]++;
                }
                else
                {
                    count[c] = 1;
                }
            }

            Console.WriteLine("\nSo lan xuat hien cua tung ky tu:");

            foreach (KeyValuePair<char, int> item in count)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.ReadKey();
        }
    }
}
