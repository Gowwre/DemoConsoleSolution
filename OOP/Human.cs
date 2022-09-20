namespace OOP;

public class Human
{
    private string name { get; set; }
    private string address { get; set; }

    public Human()
    {
    }

    public Human(string name, string address)
    {
        this.name = name;
        this.address = address;
    }

    public void Deconstruct(out string name, out string address)
    {
        name = this.name;
        address = this.address;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}