
using System;
using System.Linq;
using System.Collections.Generic;

namespace Csharp
{
    class LinqTest
    {
        public static void Exam()
        {
         //   List<int> list = new List<int>();

         string[] names = {"Bill","Steve","James","Mohan","KaiKai","Jamanvant",};

         int[] numbers = {23,21,22,34,56,53,45,66,32};

        var a = from i in names where i.Contains("B") select i;

         var b = from num in numbers where num > 20 orderby num ascending select num;

         var query = from name in names where name.Contains("e") select name;

        foreach(var item in a)
        {
            Console.WriteLine(item +" ");
        }
        }
    }

}