using System;
using System.IO;

namespace Csharp
{
    class FileInformation
    {
        public static void FileInfo()
        {
            // Specify the file path
            FileInfo fo = new FileInfo("d:/dotnet intern/fileInformation.txt");

              //To create a file 
            //fo.Create();

            //Delete a file
           // fo.Delete();

          //Write text in file
            //StreamWriter str = fo.CreateText();
            //str.WriteLine("This is for writting the text");
            //str.Close();

             //Append the text in the file;
            // StreamWriter sw = fo.AppendText();
            // sw.WriteLine("This is used to write or append text in the file ");
            // Console.WriteLine("The file is written");
            // sw.Close();

            //Use to read a text by step by step//

            // StreamReader sr = fo.OpenText();
            // string s = "";
            // while ((s = sr.ReadLine()) != null) {
            // Console.Write(s);
            // }
            
        }
    }
}
