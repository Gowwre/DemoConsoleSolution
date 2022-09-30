namespace Passing_Delegate_as_a_Parameter;

public delegate void MyDelegate(string message);

public class MyClass
{
    public static void Print(string message) => Console.WriteLine(message.ToUpper());
    public static void Show(string message) => Console.WriteLine(message.ToLower());
}