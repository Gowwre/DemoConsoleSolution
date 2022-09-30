namespace Anonymous_Method;

public delegate void MyDele(int value);
public class NewProgram
{
    static void Main(string[] args)
    {
        MyDele printValue = delegate(int value)
        {
            Console.WriteLine("Inside Anonymous method. Value: {0}",value);
        };
        printValue+= delegate
        {
            Console.WriteLine("This is Anonymous Method.");
        };
        printValue(Int32.MaxValue);
    }
}