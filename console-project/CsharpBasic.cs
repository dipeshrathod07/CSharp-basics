

using System.Data;

namespace Csharp
{
    class CsharpBasic
    {
        public static void Basics()
        {
            // long i = 3425034234235;
            // Console.WriteLine(i);

            string str = "Hello";//using the predefined data types
            String str2 = "Hello";//using the object

            char[] charc = { 'h', 'e', 'l', 'l', 'o' };

            string str3 = new string(charc);
            String str4 = new string(charc);

            Console.WriteLine(str + " " + str2 + " " + str3 + " " + str4);

        }

        public static void DateTimeBasic()
        {
            DateTime dt = new DateTime();
            // Console.WriteLine(dt.ToString());

            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime.ToString("d"));

            DateTime dateTime1 = DateTime.Today;
            //   Console.WriteLine(dateTime1.ToString());

            DateTime maxDateTimeValue = DateTime.MaxValue;
            //  Console.WriteLine(maxDateTimeValue.ToString());

            DateTime minDateTimeValue = DateTime.MinValue;
            // Console.WriteLine(minDateTimeValue.ToString());

            DateTime dt1 = new DateTime(2015, 12, 31);
            TimeSpan ts = new TimeSpan(25, 20, 55);
            DateTime newDate = dt1.Add(ts);
            // Console.WriteLine(newDate);

            DateTime dt2 = new DateTime(2015, 12, 31);
            DateTime dt3 = new DateTime(2016, 2, 2);
            TimeSpan result = dt3.Subtract(dt2);//33.00:00:00
                                                // Console.WriteLine(result);

            /*
                   var str = "20/05/2020";
                   DateTime dt4;
                   var isValidDate = DateTime.TryParse(str,out dt4);//tryparse() method is written because it returns false if the string is not valid!
                   if(isValidDate)
                   {
                     Console.WriteLine(dt4);
                    }
                    else{
                        Console.WriteLine(str+"Cannot convert");
                    }

            */
        }

        public static void VarAndDynamic()
        {
            //var keyword is used implicity and checks the data type value at compile time . If value is assigned then the value can't be type cast because it is assigned on compile time 
            var str = "10";
            var age = 22;
            var num = 10.2;
           // var str = 10.3; //it will show the error

            //dynamic keyword is used to check the data type value at run time . The value can be cast at run time;

            dynamic str1 = "10";
            dynamic age1 = 22;
            dynamic num2 = 22.4;
            dynamic num1 = str1;//it will not show the error.
        }

        public static void TypeCastingAndBoxingUnboxing()
        {
            int i = 10;

            double j = i;//this is implicit type casting;


            double k = 10.2;
            int l = (Convert.ToInt32(k));//this is explicit type casting;

            // Console.WriteLine(l);

            //Boxing
            int a = 10; //converts the data type value into object or any other interface that can be implemented
            object o = a;



            //unboxing
            object obj = 10;
            int b = (int)obj;


            double d = (double)(int)o;//first do unboxing and then do casting;
            Console.WriteLine(d);

        }

        public static void MenuDriven()
        {
            int x = 10;

            switch (x)
            {
                case 5:
                    Console.WriteLine("The value of x is 5");
                    break;
                case 10:
                    Console.WriteLine("The value of x is 10");
                    break;
                case 15:
                    Console.WriteLine("The value of x is 15");
                    break;
                case 20:
                    Console.WriteLine("The value of x is 20");
                    break;
                case 25:
                    Console.WriteLine("The value of x is 25");
                    break;
            }
        }

        public static void CallbyValue()
        {
            
                  int a = 10;
                int b = 20;
            //in call by value the change is not happen in the value of the variable
            Console.WriteLine($"a = {a} \n b ={b}");
            Swap(a,b);
            Console.WriteLine($"a = {a} \n b = {b}");

        }
        public static void Swap(int a,int b)
        {
            int temp = a;
            a = b;
            b = temp;         

            Console.WriteLine($"after update:-\n a ={a} \n b = {b}");
        }

        public static void CallByRef()
        {
            string val = "surat";
            Console.WriteLine(val);
            
            CompareValue( ref val);

            Console.WriteLine(val);

        }


        public static void CompareValue( ref string val)
        {
            if(val == "surat") Console.WriteLine("Checked!");
            
            val = "bharuch";
        }
        
        public static void UseOutKeyWord(out DateTime dt)
        {
            dt = DateTime.Now;
            System.Console.WriteLine("Current Date Time:-{0}",dt);
        }
    }
}