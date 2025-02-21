
namespace Csharp
{
    class FolderOps
    {
        //Create a new folder.
        public static void CreateDir()
        {
            Console.WriteLine("Enter the path were you have to create a directory");
            string path = Console.ReadLine();
            Directory.CreateDirectory(path);
            Console.WriteLine("Directory is created");
        }

        //Create a nested Folder
        public static void CreateNestedDir()
        {
            Console.WriteLine("Enter the Base path:");
            string basePath = Console.ReadLine();
            Console.WriteLine("Enter nested folder name(use / for nesting)");
            string nestPath = Console.ReadLine();

            string fullPath = Path.Combine(basePath, nestPath);

            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
                Console.WriteLine("Nested Directory is created successfully");
            }
            else
            {
                Console.WriteLine("It is already Exist");
            }
        }
        // Delete a folder.
        public static void RemoveDir()
        {
            Console.WriteLine("Enter the path were you have to Delete a directory (including all content)");
            string path = Console.ReadLine();
            Directory.Delete(path);
            Console.WriteLine("Directory is Deleted");
        }

        //Delete a folder and its contents recursively.
        public static void RemoveDirRecursive()
        {
            Console.WriteLine("Enter the path were you have to Delete a directory");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
                Console.WriteLine("Directory is Deleted");
            }
            else
            {
                Console.WriteLine("Directory does not exist");
            }
        }

        //Check if a folder exists.
        public static void CheckDirExist()
        {
            Console.WriteLine("Enter the path");
            string path = Console.ReadLine();
            if (Directory.Exists(path))
            {
                Console.WriteLine("It is exist");
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }

        // Retrieve folder attributes (e.g., creation date, last access date, etc.).
        public static void DirInfo()
        {
            Console.WriteLine("Enter the path");
            string path = Console.ReadLine();


            if (Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                Console.WriteLine("Directory Name: " + di.Name);
                Console.WriteLine("Full Path: " + di.FullName);
                Console.WriteLine("Creation Time: " + di.CreationTime);
                Console.WriteLine("Last Access Time: " + di.LastAccessTime);
            }
            else
            {
                Console.WriteLine("Directory does not exist: " + path);
            }
        }

        //List all files in a folder.
        public static void ListFile()
        {
            Console.WriteLine("Enter the path");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                String[] files = Directory.GetFiles(path);
                Console.WriteLine("Files in the directory");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("Files in the directory not exists");
            }
        }

        // List all subfolders in a folder./
        public static void GetSubFolder()
        {
            Console.WriteLine("Enter the path");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                string[] subFolders = Directory.GetDirectories(path);

                foreach (string subFolder in subFolders)
                {
                    Console.WriteLine(subFolder);
                }

            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }

        }

        //List all files and subfolders.
        public static void ListFilesAndSubfolders()
        {
            Console.WriteLine("Enter the path to list all files and subfolders in the directory:");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                string[] subfolders = Directory.GetDirectories(path);

                Console.WriteLine("Files:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Console.WriteLine("\nSubfolders:");
                foreach (string subfolder in subfolders)
                {
                    Console.WriteLine(subfolder);
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }
        }

        //Rename a folder.
        public static void RenameDir()
        {
            Console.WriteLine("Enter the odl path:");
            string oldPath = Console.ReadLine();
            Console.WriteLine("Enter the new path:");
            string newPath = Console.ReadLine();

            if (Directory.Exists(oldPath))
            {
                Directory.Move(oldPath, newPath);
                Console.WriteLine("Directory renamed successfully from " + oldPath + " to " + newPath);
            }
            else
            {
                Console.WriteLine("Directory Does not exists");
            }
        }

        //Move a folder to a new location.
        public static void MoveDir()
        {
            Console.WriteLine("Enter the odl path:");
            string oldPath = Console.ReadLine();
            Console.WriteLine("Enter the new path:");
            string newPath = Console.ReadLine();

            if (Directory.Exists(oldPath))
            {
                Directory.Move(oldPath, newPath);
                Console.WriteLine("Directory renamed successfully from " + oldPath + " to " + newPath);
            }
            else
            {
                Console.WriteLine("Directory Does not exists");
            }
        }

        //Copy a folder and its contents to another location.
        public static void CopyDir(string sourceDir, string destDir)
        {
            if (!Directory.Exists(destDir))
            {
                Directory.CreateDirectory(destDir);
            }

            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destDir, Path.GetFileName(file));
                File.Copy(file, destFile, true);
            }

            foreach (string subDir in Directory.GetDirectories(sourceDir))
            {
                string destSubDir = Path.Combine(destDir, Path.GetFileName(subDir));
                CopyDir(subDir, destSubDir);
            }
        }
        public static void CopyDirWrapper()
        {
            Console.WriteLine("Enter the source directory path:");
            string sourcePath = Console.ReadLine();
            Console.WriteLine("Enter the destination directory path:");
            string destPath = Console.ReadLine();

            if (Directory.Exists(sourcePath))
            {
                CopyDir(sourcePath, destPath);
                Console.WriteLine("Directory copied successfully to: " + destPath);
            }
            else
            {
                Console.WriteLine("Source directory does not exist.");
            }
        }



        // public static void FileRemove()
        // {
        //     File.Delete("d:/dotnet intern/fileInformation.txt");
        //     Console.WriteLine("File is deleted");
        // }
    }


}