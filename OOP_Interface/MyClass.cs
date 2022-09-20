namespace OOP_Interface;

public class MyClass:IFirst,ISecond
{
    void IFirst.Print()
    {
        Console.WriteLine("IFirst's print method");
    }

    public void Display()
    {
        Console.WriteLine("Display method");
    }

    void ISecond.Print()
    {
        Console.WriteLine("ISecond's print method");
    }
}