using System;
using System.IO;

namespace Csharp
{
    class FileWrite
    {
        public static void writeFile()
        {

            FileStream fs = new FileStream("d://write.txt",FileMode.Create);
        }
    }
}