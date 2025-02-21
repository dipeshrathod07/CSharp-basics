
namespace Csharp;

interface i1
{
    //Interface does not contains the fields;
    //Explicitly implement if these interface has multiple names with identical names;
    
   // string name
    void show();
}

interface i2
{
    void show();    
}

interface I1
{
    void Display();
}
interface I2
{
    void Display1();
}
interface I3:I1, I2
{
    void Display2();
}
class Myclass : I3
{
    

    // void i1.show()
    // {
    //     Console.WriteLine("This is the first interface");
    // }
    // void i2.show()
    // {
    //     Console.WriteLine("This is the Second interface");
    // }

  public void Display()
    {
        Console.WriteLine("This is method of first interface");
    }

    public void Display1()
    {
        Console.WriteLine("This is method of second Interface");
    }

    public void Display2()
    {
        Console.WriteLine("This is method of third Interface");
    }
}