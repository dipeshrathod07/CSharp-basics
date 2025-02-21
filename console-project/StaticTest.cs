namespace Csharp
{
    class Intern
    {
        static public string companyName = "Casepoint";
        public string studentName;

        public void display1()
        {
            Console.WriteLine("Company Name:"+companyName);
            Console.WriteLine("Student Name:"+studentName);

        }
        public void display2()
        {
            Console.WriteLine("Company Name:"+companyName);
            //Console.WriteLine("Student name : "+studentName);
        }

    }

    static class Test 
    {
        static int a = 5;

        public static void display()
        {
            Console.WriteLine("Value of A:"+a);
        }

    }

    class StaticTest
    {
        public static void StaticMain()
        {
            Intern s1 = new Intern();
            s1.studentName = "ram";
            Console.WriteLine("Name:"+s1.studentName);
           
             //calls static variable
            Console.WriteLine("Company"+Intern.companyName);

            Intern s2 = new Intern();
            s2.studentName = "Shayam";


    //calls Instance variable
    Console.WriteLine("Name:"+s1.studentName);

    //static variable
     Console.WriteLine("Company"+Intern.companyName);

     s1.display2();

     s1.display1();
     s2.display1();

     Test.display();
     Console.ReadLine();
 
        }
    }
}