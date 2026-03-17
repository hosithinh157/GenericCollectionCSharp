using System;
using System.Collections.Generic;

namespace ThuchanhCS
{
    class Bai2
    {
        public static void Run()
        {
            int n;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");

            Console.Write("\nNhap so luong phan tu n: ");
            n = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap so thu " + (i + 1) + ": ");
                int num = Convert.ToInt32(Console.ReadLine());
                numbers.Add(num);
            }

            Console.WriteLine("\nDay so vua nhap:");

            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine("\nTong cac phan tu trong danh sach: " + sum);

            Console.ReadKey();
        }
    }
}
