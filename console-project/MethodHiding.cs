namespace Csharp;

class Base
{
    public void Show()
    {
        Console.WriteLine("This the base class method");
    }

}

class Child : Base
{
    public new void Show()
    {
        // base.Show();
        Console.WriteLine("This is the Child class method");
    }
    
}