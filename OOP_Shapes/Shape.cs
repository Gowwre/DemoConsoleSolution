namespace OOP_Shapes;

public abstract class Shape
{
    public int Height { get; set; }
    public int Width { get; set; }
    
    //Virtual Method
    public virtual void Draw()
    {
        Console.WriteLine("Performing base class Drawing tasks");
        
    }

    public void Print()
    {
        Console.WriteLine("Performing base class Printing tasks");
    }

    public abstract void Display();
    
}