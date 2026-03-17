using System;
using System.Collections.Generic;

namespace ThuchanhCS
{
    class Bai5
    {
        public static void Run()
        {
            int n;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");

            Console.Write("\nNhap so luong sinh vien: ");
            n = Convert.ToInt32(Console.ReadLine());

            List<string> students = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap ten sinh vien thu " + (i + 1) + ": ");
                string name = Console.ReadLine();
                students.Add(name);
            }

            Console.Write("\nNhap ten sinh vien can xoa: ");
            string deleteName = Console.ReadLine();

            if (students.Contains(deleteName))
            {
                students.Remove(deleteName);
                Console.WriteLine("Da xoa sinh vien khoi danh sach.");
            }
            else
            {
                Console.WriteLine("Khong tim thay ten sinh vien.");
            }

            Console.WriteLine("\nDanh sach sinh vien sau khi xoa:");

            foreach (string name in students)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}