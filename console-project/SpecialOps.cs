using System;
using System.IO;
using System.IO.Compression;
using System.Security.AccessControl;

namespace Csharp
{
    class SpecialOps
    {
        static string path = "d:/dotnet intern/EmptyFile.txt";

        // 1. Search Operations
        public static void SearchFilesByExtension()
        {
            string folderPath = Path.GetDirectoryName(path);
            string extension = Path.GetExtension(path);
            Console.WriteLine($"Searching for *{extension} files in {folderPath}");
            string[] files = Directory.GetFiles(folderPath, $"*{extension}");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }

         public static void SearchFilesByPattern()
        {
            string folderPath = Path.GetDirectoryName(path);
            string pattern = "*.txt"; // Example wildcard pattern
            Console.WriteLine($"Searching for files matching pattern '{pattern}' in {folderPath}");
            string[] files = Directory.GetFiles(folderPath, pattern);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }

        // 2. File Compression
        public static void CompressFile()
        {
            string zipPath = Path.ChangeExtension(path, ".gz");
            Console.WriteLine($"Compressing {path} into {zipPath}");
            using (FileStream originalFileStream = new FileStream(path, FileMode.Open))
            using (FileStream zipFileStream = new FileStream(zipPath, FileMode.Create))
            using (System.IO.Compression.GZipStream compressionStream = new GZipStream(zipFileStream, CompressionMode.Compress))
            {
                originalFileStream.CopyTo(compressionStream);
            }
            Console.WriteLine("Compression completed.");
        }

        public static void DecompressFile()
        {
            string zipPath = Path.ChangeExtension(path, ".gz");
            string outputPath = Path.ChangeExtension(path, ".decompressed.txt");
            Console.WriteLine($"Decompressing {zipPath} into {outputPath}");
            using (FileStream zipFileStream = new FileStream(zipPath, FileMode.Open))
            using (FileStream outputFileStream = new FileStream(outputPath, FileMode.Create))
            using (GZipStream decompressionStream = new GZipStream(zipFileStream, CompressionMode.Decompress))
            {
                decompressionStream.CopyTo(outputFileStream);
            }
            Console.WriteLine("Decompression completed.");
        }

                // 3. Permissions and Security
        public static void SetPermissions()
        {
            FileInfo fileInfo = new FileInfo(path);
            FileSecurity fileSecurity = fileInfo.GetAccessControl();
            fileSecurity.AddAccessRule(new FileSystemAccessRule(
                Environment.UserName,
                FileSystemRights.FullControl,
                AccessControlType.Allow));
            fileInfo.SetAccessControl(fileSecurity);
            Console.WriteLine($"Permissions updated for {path}");
        }

        public static void CheckPermissions()
        {
            FileInfo fileInfo = new FileInfo(path);
            FileSecurity fileSecurity = fileInfo.GetAccessControl();
            Console.WriteLine($"Checking permissions for {path}:");
            foreach (FileSystemAccessRule rule in fileSecurity.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount)))
            {
                Console.WriteLine($"{rule.IdentityReference}: {rule.FileSystemRights} - {rule.AccessControlType}");
            }
        }




        // 4. Temporary Files and Folders
        public static void CreateTemporaryFile()
        {
            string tempFilePath = Path.GetTempFileName();
            Console.WriteLine($"Temporary file created: {tempFilePath}");
        }

        public static void CreateTemporaryFolder()
        {
            string tempFolderPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempFolderPath);
            Console.WriteLine($"Temporary folder created: {tempFolderPath}");
        }

        // 5. Symbolic and Hard Links
        public static void CreateSymbolicLink()
        {
            string linkPath = path + "_link";
            Console.WriteLine($"Creating symbolic link from {linkPath} to {path}");
            bool success = CreateSymbolicLink(linkPath, path, 0x0); // 0x0 indicates a file link
            if (success) Console.WriteLine("Symbolic link created.");
            else Console.WriteLine("Failed to create symbolic link.");
        }

        public static void CreateHardLink()
        {
            string linkPath = path + "_hardlink";
            Console.WriteLine($"Creating hard link from {linkPath} to {path}");
            bool success = CreateHardLink(linkPath, path, IntPtr.Zero);
            if (success) Console.WriteLine("Hard link created.");
            else Console.WriteLine("Failed to create hard link.");
        }

        // Interop for symbolic and hard links
        [System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        private static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, int dwFlags);

        [System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        private static extern bool CreateHardLink(string lpFileName, string lpExistingFileName, IntPtr lpSecurityAttributes);
    }

 }
