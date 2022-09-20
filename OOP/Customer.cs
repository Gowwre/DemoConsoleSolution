namespace OOP;

public class Customer
{
    private int _id;

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string CustomerName { get; set; } = "Unknown";
    public void Print()
    {
        Console.WriteLine($"ID:{Id}, Name:{CustomerName}");
    }
}