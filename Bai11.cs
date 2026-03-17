using System;
using System.Collections.Generic;

namespace ThuchanhCS
{
    class Student
    {
        public int Id;
        public string Name;
    }

    class Bai11
    {
        public static void Run()
        {
            int n;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");

            Console.Write("\nNhap so luong sinh vien: ");
            n = Convert.ToInt32(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student sv = new Student();

                Console.WriteLine("\nNhap sinh vien thu " + (i + 1));

                Console.Write("Nhap ID: ");
                sv.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhap ten: ");
                sv.Name = Console.ReadLine();

                students.Add(sv);
            }

            Console.WriteLine("\nDanh sach sinh vien:");

            foreach (Student sv in students)
            {
                Console.WriteLine("ID: " + sv.Id + " - Ten: " + sv.Name);
            }

            Console.ReadKey();
        }
    }
}