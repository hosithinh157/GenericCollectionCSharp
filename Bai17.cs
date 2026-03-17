using System;
using System.Collections.Generic;

namespace ThuchanhCS
{
    class Bai17
    {
        public static void Run()
        {
            int n;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");

            Console.Write("\nNhap so luong phan tu: ");
            n = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap so thu " + (i + 1) + ": ");
                int num = Convert.ToInt32(Console.ReadLine());
                numbers.Add(num);
            }

            Dictionary<int, int> count = new Dictionary<int, int>();

            foreach (int num in numbers)
            {
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count[num] = 1;
                }
            }

            int maxCount = 0;
            int result = 0;

            foreach (KeyValuePair<int, int> item in count)
            {
                if (item.Value > maxCount)
                {
                    maxCount = item.Value;
                    result = item.Key;
                }
            }

            Console.WriteLine("\nSo xuat hien nhieu nhat la: " + result);
            Console.WriteLine("So lan xuat hien: " + maxCount);

            Console.ReadKey();
        }
    }
}