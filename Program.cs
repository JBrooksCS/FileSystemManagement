using System;
using System.IO;

namespace ManagingFilesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string rootPath = @"C:\Users\Jason\Pictures";

            //Finding Directory

            bool directoryExists = Directory.Exists(rootPath);

            if (directoryExists) { Console.WriteLine("Directory Exists!"); }
            else { Console.WriteLine("Directory Doesn't Exist!"); }

            //Finding Subdirectories

            //string[] dirs = Directory.GetDirectories(rootPath);
            //foreach(string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            //Creating Directory
            //string newDirectoryPath = "blahblahblah";
            //Directory.CreateDirectory(newDirectoryPath);

            //Finding Files in Directory

            var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            foreach(string file in files)
            {
                Console.WriteLine(file);
                //Console.WriteLine(Path.GetFullPath(file));
            }

            Console.ReadLine();
        }
    }
}
