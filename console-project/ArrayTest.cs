namespace Csharp
{
    class ArrayTest{
        
        public static void SingleArrayTest()
        {
            int [] a;
            int n;
            Console.WriteLine("Enter the name");
            n = int.Parse(Console.ReadLine());
            a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("" + i);
             }
        }
    }
}