using System;
using System.Collections.Generic;

namespace ThuchanhCS
{
    class Student1
    {
        public int Id;
        public string Name;
    }

    class Bai12
    {
        public static void Run()
        {
            int n;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");

            Console.Write("\nNhap so luong sinh vien: ");
            n = Convert.ToInt32(Console.ReadLine());

            List<Student1> students = new List<Student1>();

            for (int i = 0; i < n; i++)
            {
                Student1 sv = new Student1();

                Console.WriteLine("\nNhap sinh vien thu " + (i + 1));

                Console.Write("Nhap ID: ");
                sv.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhap ten: ");
                sv.Name = Console.ReadLine();

                students.Add(sv);
            }

            Console.Write("\nNhap ten sinh vien can tim: ");
            string searchName = Console.ReadLine();

            bool found = false;

            foreach (Student1 sv in students)
            {
                if (sv.Name.ToLower() == searchName.ToLower())
                {
                    Console.WriteLine("Tim thay: ID = " + sv.Id + ", Ten = " + sv.Name);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Khong tim thay sinh vien!");
            }

            Console.ReadKey();
        }
    }
}