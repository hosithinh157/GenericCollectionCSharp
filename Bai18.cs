using System;
using System.Collections.Generic;

namespace ThuchanhCS
{
    class Student
    {
        public string Name;
        public double Score;
    }

    class Bai18
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

                Console.Write("Nhap ten: ");
                sv.Name = Console.ReadLine();

                Console.Write("Nhap diem: ");
                sv.Score = Convert.ToDouble(Console.ReadLine());

                students.Add(sv);
            }

            Student maxStudent = students[0];

            foreach (Student sv in students)
            {
                if (sv.Score > maxStudent.Score)
                {
                    maxStudent = sv;
                }
            }

            Console.WriteLine("\nSinh vien co diem cao nhat:");
            Console.WriteLine("Ten: " + maxStudent.Name);
            Console.WriteLine("Diem: " + maxStudent.Score);

            Console.ReadKey();
        }
    }
}
