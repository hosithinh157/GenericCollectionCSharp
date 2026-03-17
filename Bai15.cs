using System;
using System.Collections.Generic;

namespace ThuchanhCS
{
    class Bai15
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("hello", "xin chao");
            dictionary.Add("book", "quyen sach");
            dictionary.Add("computer", "may tinh");
            dictionary.Add("student", "sinh vien");
            dictionary.Add("teacher", "giao vien");

            Console.Write("\nNhap tu tieng Anh can tra: ");
            string word = Console.ReadLine().ToLower();

            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine("Nghia tieng Viet: " + dictionary[word]);
            }
            else
            {
                Console.WriteLine("Khong tim thay tu trong tu dien!");
            }

            Console.ReadKey();
        }
    }
}
