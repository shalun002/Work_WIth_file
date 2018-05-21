using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* 2.	С помощью класса StreamWriter записать в текстовый файл свое имя, фамилию и возраст. Каждая запись должна начинаться с новой строки. */
namespace Work_WIth_file
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo(Console.ReadLine());
            ////FileStream fs = fi.Create();
            ////fs.Close();
            //M1(fi);

            //string path = Path.Combine(fi.DirectoryName, fi.Name);
            //Console.WriteLine(path);
            ////Console.WriteLine(fi.Directory.FullName);
            ////Console.WriteLine(fi.DirectoryName);

            //using (StreamWriter sw = new StreamWriter(path))
            //{
            //    GetUserInfo(sw);
            //}
            //AppendFile(fi);
            ReadFile(fi);
        }

        static void M1(FileInfo fi)
        {
            if (!fi.Exists)
            {
                using (FileStream fs = fi.Create())
                {
                    Console.WriteLine("Файл создан успешно!!!");
                }
            }

        }

        static void GetUserInfo(StreamWriter sw)
        {
            Console.WriteLine("Введите имя: ");
            sw.Write(Console.ReadLine());
            Console.WriteLine("Введите фамилию: ");
            sw.Write(Console.ReadLine());
            Console.WriteLine("Введите возраст: ");
            sw.Write(Console.ReadLine());
        }

        static void AppendFile(FileInfo fi)
        {
            if (!fi.Exists)
            {
                using (StreamWriter sw = fi.AppendText())
                {
                    GetUserInfo(sw);
                }
            }
        }

        static void ReadFile(FileInfo fi)
        {
            string path = Path.Combine(fi.DirectoryName, fi.Name);

            if (fi.Exists)
            {
                using (StreamReader sr = new StreamReader(path))
                    Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}