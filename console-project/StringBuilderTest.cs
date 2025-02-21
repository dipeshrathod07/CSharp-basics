using System;
using System.Text;
namespace Csharp
{
    class StringBuilderTest
    {
        public static void StringBuilderMain()
        {
            StringBuilder sb = new StringBuilder("Hello world!");

          //  for(int i = 0 ; i < sb.Length ; i++)
         //   {
            //    Console.Write(sb);
         //   }
               // Console.WriteLine();
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Hello");
            sb1.AppendLine("World!");
            sb1.AppendLine("Hello c#!");
           // Console.WriteLine(sb1);

            StringBuilder sb3 = new StringBuilder("Hello world",50);
            sb3.Remove(0,5);
           // Console.WriteLine(sb3);

            StringBuilder sb4 = new StringBuilder("Hello World!",20);
            sb4.Replace("World","C#");
            //Console.WriteLine(sb4);

        
        }
    }
}