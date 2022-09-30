namespace Multicast_Delegate;

public delegate void MyDelegate(string message);
public class MyClass
{
    public static void Print(string message) => Console.WriteLine(message.ToUpper());
    public static void Display(string message) => Console.WriteLine(message.ToLower());
    public static void Show(string message) => Console.WriteLine(message);
}