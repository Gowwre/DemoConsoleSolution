namespace OOP_Interface;

public class SomeClass:ISomeInterface
{
    public string SomeProperty { get; set; }
    public string SomeMethod()
    {
        return "Lol";
    }

    public void SomethingElse()
    {
        Console.WriteLine(DateTime.Now);
    }
}