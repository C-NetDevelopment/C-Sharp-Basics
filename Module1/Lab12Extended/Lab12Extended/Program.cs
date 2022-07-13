using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Extended
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("===========File Operations============");
                Console.WriteLine("1.Create Directory Structure   \n" +
                                  "2.Take Backup \n" +
                                  "3.See File Detials" +
                                  "4.Exit\n");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            FileStructure();
                            break;
                        
                        case 2:
                            Backup();
                            break;
                        case 3:
                            FileDetails();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
            } while (true);
        }

        private static void FileDetails()
        {
            Console.WriteLine("Enter Folder Name");
            string folder = Console.ReadLine();
            Console.WriteLine("Enter Sub Folde Name");
            string folder4 = Console.ReadLine();
            Console.WriteLine("Enter File Name");
            string file1 = Console.ReadLine();
            string fpath = @"D:\Lab\" + folder +@"\"+folder4 + @"\" + file1;
            File.Create(fpath);

            Console.WriteLine("Enter Text to insert in file");
            using (StreamReader sw = new StreamReader(fpath))
            {
                string line = sw.ReadToEnd();
            }

        }

        private static void Backup()
        {
            Console.WriteLine("Enter Folder Name");
            string folder = Console.ReadLine();
            Console.WriteLine("Enter sub Folder Name");
            string folder1 = Console.ReadLine();
            string path1 = @"D:\Lab\" + @"\" + folder + @"\" + folder1;

            Console.WriteLine("Enter Folder Name to create");
            string folder3 = Console.ReadLine();
            Console.WriteLine("Want to create Folder Within Folder\n" +
                "if yes press: 1 \n" +
                "if No press: 2");
            int option = int.Parse(Console.ReadLine());
            do
            {
                if (option == 1)
                {
                    Console.WriteLine("Enter Sub Folde Name");
                    string folder4 = Console.ReadLine();
                    string path = @"D:\Lab\" + @"\" + folder3 + @"\" + folder4;
                    Directory.CreateDirectory(path);

                    Console.WriteLine("Enter File Name");
                    string file1 = Console.ReadLine();
                    string fpath = @"D:\Lab\" + folder3 + @"\" + folder4 + @"\" + file1;
                    File.Create(fpath);

                    File.Move(path1, fpath);
                }
                else
                {
                    Console.WriteLine("Enter File Name");
                    string file1 = Console.ReadLine();
                    string fpath = @"D:\Lab\" + @"\" + folder3 + @"\" + file1;
                    File.Create(fpath);
                    File.Move(path1, fpath);
                    
                }
            } while (true);
            
        }

       

        private static void FileStructure()
        {
            Console.WriteLine("Enter Folder Name to create");
            string folder = Console.ReadLine();
            Console.WriteLine("Want to create Folder Within Folder\n" +
                "if yes press: 1 \n" +
                "if No press: 2");
            int option = int.Parse(Console.ReadLine());
            do
            {
                if (option == 1)
                {
                    Console.WriteLine("Enter Sub Folde Name");
                    string folder1 = Console.ReadLine();
                    string path = @"D:\Lab\" + @"\" + folder+@"\"+folder1;
                    Directory.CreateDirectory(path);

                    Console.WriteLine("Enter File Name");
                    string file1 = Console.ReadLine();
                    string fpath = @"D:\Lab\" + folder + @"\" + folder1 + @"\" + file1;
                    File.Create(fpath);

                    Console.WriteLine("Enter batch Details");
                    string line = Console.ReadLine();
                    using (StreamWriter sw = new StreamWriter(fpath))
                    {
                        sw.Write(line);
                    }
                }
                else
                {
                    Console.WriteLine("Enter File Name");
                    string file1 = Console.ReadLine();
                    string fpath = @"D:\Lab\"+folder+ @"\"+file1;
                    File.Create(fpath);

                    Console.WriteLine("Enter Text to insert in file");
                    string line = Console.ReadLine();
                    using (StreamWriter sw = new StreamWriter(fpath))
                    {
                        sw.Write(line);
                    }
                }
            } while (true);
            
        }
    }
}
