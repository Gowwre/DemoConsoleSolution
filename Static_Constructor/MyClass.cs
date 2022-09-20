namespace Static_Constructor;

public class MyClass
{
    public static int x = 1;

    static MyClass()
    {
        x = 2;
        Console.WriteLine("Static constructor: x={0}",x);
    }

    public MyClass()
    {
        x++;
        Console.WriteLine("Object constructor: x={0}",x);
    }
}