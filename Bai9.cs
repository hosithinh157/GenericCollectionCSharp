using System;
using System.Collections.Generic;

namespace ThuchanhCS
{
    class Bai9
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

            List<int> uniqueList = new List<int>();

            foreach (int num in numbers)
            {
                if (!uniqueList.Contains(num))
                {
                    uniqueList.Add(num);
                }
            }

            Console.WriteLine("\nDanh sach sau khi loai bo trung lap:");

            foreach (int num in uniqueList)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}