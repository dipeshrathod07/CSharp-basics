using System;
using System.IO;

namespace Csharp
{
    class FileOps
    {
        public static void CreateFile()
        {
            string path = "d:/dotnet intern/EmptyFile.txt";
            File.Create(path);
            Console.WriteLine("File is created");  
            //to write the initial content
            
            File.WriteAllText(path,"This file is Created and Information is inserted");
        }



        public static void DeleteFile()
        {

            Console.WriteLine("Enter the path where you have to delete the file");
            string path  = Console.ReadLine();
            if(File.Exists(path))
            {
            File.Delete(path);
            Console.WriteLine("File is Deleted");       
            }
            else{
                Console.WriteLine("File not exists");
            }
        }

        public static void CheckFile()
        {
            string path = "d:/dotnet intern/EmptyFile.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File already exists");
            }
            else
            {
                Console.WriteLine("File not Exists");
            }
        }

        public static void FileInfo()
        {
            string path = "d:/dotnet intern/EmptyFile.txt";
            //to get all attributes

            FileInfo fo = new FileInfo(path);
            Console.WriteLine($"Creation Time :{fo.CreationTime}");

            Console.WriteLine($"Last Access Time: {fo.LastAccessTime}");

            Console.WriteLine($"FileSize:{fo.Length} bytes");

            Console.WriteLine($"file name:{fo.Name}");
            
            Console.WriteLine($"Extension:{fo.Extension}");
        }

        public static void FileRead()
        {
            string path = "d:/dotnet intern/EmptyFile.txt";
            //Reduce all text from file
            string content = File.ReadAllText(path);
           // Console.WriteLine($"Content:-{content}");

            //Read all file from an array
            string[] str = File.ReadAllLines(path);
            Console.WriteLine("File lines");

            foreach(string lines in str)
            {
                Console.WriteLine(lines);
            }

            // Read file content in chunks (streaming)
            
            using(FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                    byte[] buffer = new byte[1024]; // 1 KB chunks
                    int bytesRead;

                    while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        Console.WriteLine(System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead));
                    }
            }

        }

        public static void WriteFileOps()
        {
            string path = "d:/dotnet intern/EmptyFile.txt";
              // Write text to a file
            File.WriteAllText(path, "This is some text.");

            // Append text to a file
            File.AppendAllText(path, "\nThis is appended text.");

            // Write binary data to a file
            byte[] binaryData = { 0x01, 0x02, 0x03, 0x04 };
            File.WriteAllBytes("BinaryFile.bin", binaryData);
        }

        public static void FileManipulation()
        {
            string path = "d:/dotnet intern/EmptyFile.txt";

            //Copy a file to another location
            File.Copy(path,"d:/dotnet_intern/CopyOfEmptyFile.txt");

            //Move a file to another Location
            File.Move(path,"d:/dotnet_intern/moveHere.txt");

            //Rename
            File.Move(path,"d:/dotnet intern/renamed.txt");
        }

        public static void FileAdvanceTopic()
        {
            // Open a file in read/write mode
            using (FileStream fs = new FileStream("RenamedFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                Console.WriteLine("File opened in read/write mode.");
            }

            // Lock a file to prevent access by other processes
            using (FileStream fs = new FileStream("RenamedFile.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {         
                Console.WriteLine("File locked.");
                // Perform operations while locked
            }

            // Monitor file changes using FileSystemWatcher
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = Directory.GetCurrentDirectory();
                watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;

                watcher.Changed += (source, e) => Console.WriteLine($"File {e.FullPath} changed.");
                watcher.Created += (source, e) => Console.WriteLine($"File {e.FullPath} created.");
                watcher.Deleted += (source, e) => Console.WriteLine($"File {e.FullPath} deleted.");
                watcher.Renamed += (source, e) => Console.WriteLine($"File {e.FullPath} renamed.");

                watcher.EnableRaisingEvents = true;

                Console.WriteLine("Monitoring file changes...");
                Console.ReadLine(); // Keep the application running to monitor changes
            }

        }

        public static void AllOperations()
        {
           //CreateFile();
           // DeleteFile();
           // CheckFile();
            //FileInfo();
            FileRead();
        }
    }
}