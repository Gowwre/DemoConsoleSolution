namespace OOP;

public class MyClass
{
    public int x { get; init; }
    public int y { get; }

    public MyClass()
    {
        x = 10;
        y = 20;
    }

    public MyClass(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}