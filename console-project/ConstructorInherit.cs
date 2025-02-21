

namespace Csharp;

class BaseClass
{
    public BaseClass(string message)
    {
        Console.WriteLine(message);
    }
}

class DerivedClass : BaseClass
{
    public DerivedClass() :base("This is base class Constructor")
    {
        Console.WriteLine("This is the derived class Constructor!");
    }
}