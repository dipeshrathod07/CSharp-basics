using System;
using System.Linq;


namespace Csharp
{
    class LinqJoins
    {
        public static void LinqJoinsMain()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() {studentId = 1, studentName ="Dipesh",Age=20,standardId=1},
                new Student() {studentId = 2, studentName ="Sonu",Age=18,standardId=2},
                new Student() {studentId = 3, studentName ="Ram",Age=18,standardId=3},
                new Student() {studentId = 4, studentName ="Rom",Age=21,standardId=1},
                new Student() {studentId = 5, studentName ="Sham",Age=19,standardId=2},
                new Student() {studentId = 6, studentName ="John",Age=17,standardId=3},

            };

            IList<Standard> std = new List<Standard>()
            {
                new Standard() {standardId=1,standardName ="xyz"} ,
               new Standard() {standardId=2,standardName="xyzz"} ,
                new Standard() {standardId=3,standardName="standard1"},
        };
    }
    class Student
    {
        public int studentId{get; set;}
        public string studentName{get; set;}
        public int Age{get; set;}
        public int standardId{get; set;}
    }

    class Standard
    {
        public int standardId{get; set;}
        public string standardName{get; set;}
    }
}
}