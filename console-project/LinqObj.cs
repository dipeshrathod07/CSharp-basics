
using System;
using System.Linq;
using System.Collections.Generic;


namespace Csharp
{
    class LinqObj
    {
        public static bool IsTeenAger(LinqObj.Student stud)
        {
            return stud.Age > 12 && stud.Age < 20;
        }

        public class Student
        {
            public int StudentId{get; set;}

            public string StudentName{get;set;}

            public int Age{get; set;}

        }

        public static void LinqObjMain()
        {
            IList<Student> studentList = new List<Student>(){
            new Student(){StudentId = 1,StudentName = "Dipak",Age = 13},
            new Student(){StudentId = 2,StudentName = "Rahul",Age = 20},
            new Student(){StudentId = 3,StudentName = "Jinal",Age = 18},
            new Student(){StudentId = 4,StudentName = "Dinky",Age = 15},
            new Student(){StudentId = 5,StudentName = "Mayank",Age =15},
            new Student(){StudentId = 6,StudentName = "Dhruti",Age =20},
            new Student(){StudentId = 7,StudentName = "Bony",Age =12},
            new Student(){StudentId = 8,StudentName = "Sunil",Age = 15}
            };

           // var filterdResult = from s in studentList select s;

          // var filteredResult = from s in studentList 
                             //   where s.Age >= 12 && s.Age <= 18
                              //  select s;

                // Func<Student,bool> IsTeenAger = delegate (Student s)
                // {
                //     return s.Age > 12 && s.Age < 18;
                // };

               // var filteredResult = from s in studentList where IsTeenAger(s) select s;

                // var filterdResult = studentList.Where((s)=>
                // s.Age > 12 && s.Age < 20
                // );

        /*
                var std = (from s in studentList 
                                        where s.Age > 12 && s.Age < 20 
                                        select s).FirstOrDefault();
                var std = (from s in studentList
                            where s.Age > 12 && s.Age < 20
                            select s).LastOrDefault();

                var std = (from s in studentList
                    where s.Age == 12
                    select s).SingleOrDefault();

               if(std != null)
               {
                Console.WriteLine($"ID:{std.StudentId} Name: {std.StudentName} Age:{std.Age}");
               }
               else
               {
                Console.WriteLine("No Student Found");
               }
        */

        /*
            var filterdResult = from s in studentList group s by s.Age;
           
            foreach(var student in filterdResult)
            {   
                Console.WriteLine(student.Key);
                Console.WriteLine("Count {0}:",student.Count());

                foreach(var student2 in student)
                {
                   Console.WriteLine($"ID:{student2.StudentId} Name: {student2.StudentName} Age:{student2.Age}");
                }
            }
        */

            Console.WriteLine(studentList.Sum(s => s.Age));
            Console.WriteLine(studentList.Max(s => s.Age));
            Console.WriteLine($"Min: {studentList.Min(s => s.Age)}");
            Console.WriteLine(studentList.Count());
            Console.WriteLine(studentList.Average(s => s.Age));
        }
    }
}