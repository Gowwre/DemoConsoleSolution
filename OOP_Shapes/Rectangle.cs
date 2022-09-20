namespace OOP_Shapes;

public class Rectangle:Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }

    public override void Display()
    {
        Console.WriteLine("Display Rectangle");
    }

    public new void Print()
    {
        Console.WriteLine("Print Rectangle");
    }
}