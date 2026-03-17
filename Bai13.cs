using System;
using System.Collections.Generic;

namespace ThuchanhCS
{
    class Student2
    {
        public int Id;
        public string Name;
    }

    class Bai13
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");

            List<Student2> students = new List<Student2>();

            while (true)
            {
                Console.Write("\nNhap ten sinh vien (nhap 'exit' de dung): ");
                string name = Console.ReadLine();

                if (name.ToLower() == "exit")
                {
                    break;
                }

                Student2 sv = new Student2();

                Console.Write("Nhap ID: ");
                sv.Id = Convert.ToInt32(Console.ReadLine());

                sv.Name = name;

                students.Add(sv);
            }

            Console.WriteLine("\nTong so sinh vien da nhap: " + students.Count);

            Console.WriteLine("\nDanh sach sinh vien:");
            foreach (Student2 sv in students)
            {
                Console.WriteLine("ID: " + sv.Id + " - Ten: " + sv.Name);
            }

            Console.ReadKey();
        }
    }
}