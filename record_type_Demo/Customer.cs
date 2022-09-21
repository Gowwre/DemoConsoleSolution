namespace record_type_Demo;

public record Customer()
{
    public string Name { get; init; } = "New customer";
    public int Age { get; init; } = 20;

    public void Print()
    {
        Console.WriteLine($"Name:{Name}, Age:{Age}");
    }
}