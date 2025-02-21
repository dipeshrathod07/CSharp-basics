

namespace Csharp;


//Delegate is type which holds the method reference in an object and aslo known as function pointer
//Delegate can point parameterized and non parameterized functions
class DelegatesTest
{
    public delegate void Calculation(int a,int b);
    public void Addition(int a , int b)
    {
        Console.WriteLine("Addition:"+(a + b));
    }
    public static void Substraction(int a , int b)
    {
        Console.WriteLine("Substraction:"+(a - b));
    }
    public static void Multiplication(int a , int b)
    {
        Console.WriteLine("Addition:"+(a * b));
    }
    public static void Division(int a , int b)
    {
        Console.WriteLine("Addition:"+(a / b));
    }

}