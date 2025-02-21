
using System;

namespace Csharp
{

    static class StringExtension
    {
        public static int WordCount(this String s)
        {
            return s.Split(new char[]{' ','.','?'},StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string MyConcat(this String str,string strtail)
        {
            return str+" "+strtail;
        }
    }
    class ExtMethodExample
    {

        public static  void ExtMethodExampleMain()
        {
            string s = "The quick brown fox jumped over the lazy dog";

            int i = s.WordCount();
            System.Console.WriteLine("{0} Word count of s is {1}",s,i);
            System.Console.WriteLine("Dipesh".MyConcat("Rathod"));

        }
    }
}