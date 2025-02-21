using System;

namespace Csharp

{

    //This example is of static constructor.
    //1)Static constructor is use to intialise the variables.
    //2)Static constructor doesnot contains any parameter
    //3)Static constructor is called before the instance constructor

    class Person
    {
        public static string personName;
        public static int personAge;

         static Person()
        {
            personName = "Dipesh";
            personAge = 21;
            Console.WriteLine("This is static Constructor:-");
        }

        public Person()
        {
            personAge++;
            Console.WriteLine("This is public Constructor");
        }

        public void GetDetails()
        {
           // Console.WriteLine("Person Name is:"+personName);
           // Console.WriteLine("Person Age is:"+personAge);
        }
    }
    

    class StatConst
    {
        static int a;
        static int b;


        static StatConst()
        {
            a = 10;
            b = 20;
        }

        public StatConst()
        {

            a++;

            b++;
        }

        public int Display()

        {
            return a + b;
        }

    }
    
    #region  Private Constructor

    class PrivateCons
    {
        public int a;
        public int b;
        private PrivateCons()
        {

        }
        // public PrivateCons(int a,int b)
        // {
        //     this.a = a;
        //     this.b = b;
        // }
        public static int Age(int a)
        {
            return a;
        }
    }
    
    #endregion
    class Addition
    {
        public int a = 10;
        public int b = 20;
        public int c;

        public Addition(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Addition(Addition both, int b)
        {

            a = both.a;
            this.b = both.b;
            c = b;   

        }

        public int Display()
        {
            Console.WriteLine(c);
            return a + b;
        }
    }
}