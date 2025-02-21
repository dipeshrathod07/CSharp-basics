namespace Csharp
{

    //Static class contains only static variables ,static constructor and static methods and doesnot creates the Object of the class 
    //They cannot be intancetiated and inherited and cannot contains instance constructor.
    //
    static class Products
    {
        public  static int productId;
        public static string productName;
        public static int productPrice;

        static Products()
        {
            productId = 111;
            productName = "Piano";
            productPrice = 7000;
        }

        public static void GetProductDetails()
        {
            Console.WriteLine($"Product Id :{productId}");
            Console.WriteLine($"Product Name :{productName}");
            Console.WriteLine($"Product price :{productPrice}");
        }
        public static void Discount()
        {
            int d_amount = productPrice/10;
            Console.WriteLine("Your discount amount is={0}",d_amount);
            Console.WriteLine("Your Total amount is={0}",productPrice-d_amount);
        }

    }
}