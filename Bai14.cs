using System;
using System.Collections.Generic;

namespace ThuchanhCS
{
    class Student3
    {
        public int Id;
        public string Name;
    }

    class Bai14
    {
        public static void Run()
        {
            int n;

            Console.Write("Nhap so luong sinh vien: ");
            n = Convert.ToInt32(Console.ReadLine());

            List<Student3> students = new List<Student3>();

            for (int i = 0; i < n; i++)
            {
                Student3 sv = new Student3();

                Console.WriteLine("\nNhap sinh vien thu " + (i + 1));

                Console.Write("Nhap ID: ");
                sv.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhap ten: ");
                sv.Name = Console.ReadLine();

                students.Add(sv);
            }

            Console.Write("\nNhap ID sinh vien can xoa: ");
            int deleteId = Convert.ToInt32(Console.ReadLine());

            Student3 removeStudent = null;

            foreach (Student3 sv in students)
            {
                if (sv.Id == deleteId)
                {
                    removeStudent = sv;
                    break;
                }
            }

            if (removeStudent != null)
            {
                students.Remove(removeStudent);
                Console.WriteLine("Da xoa sinh vien co ID = " + deleteId);
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien!");
            }

            Console.WriteLine("\nDanh sach sinh vien sau khi xoa:");

            foreach (Student3 sv in students)
            {
                Console.WriteLine("ID: " + sv.Id + " - Ten: " + sv.Name);
            }

            Console.ReadKey();
        }
    }
}