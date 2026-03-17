using System;
using System.Collections.Generic;

namespace ThuchanhCS
{
    class Bai6
    {
        public static void Run()
        {
            int n;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");

            Console.Write("\nNhap so luong chuoi: ");
            n = Convert.ToInt32(Console.ReadLine());

            List<string> ds = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap chuoi thu " + (i + 1) + ": ");
                string str = Console.ReadLine();
                ds.Add(str);
            }

            Console.Write("\nNhap chuoi can kiem tra: ");
            string check = Console.ReadLine();

            if (ds.Contains(check))
            {
                Console.WriteLine("Chuoi ton tai trong danh sach.");
            }
            else
            {
                Console.WriteLine("Chuoi khong ton tai trong danh sach.");
            }
            Console.ReadKey();
        }
    }
}