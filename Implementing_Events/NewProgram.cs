namespace Implementing_Events;

public delegate void PrintDetails(string message);

public class NewProgram
{
    event PrintDetails Print;
    void Show(string message) => Console.WriteLine(message.ToUpper());
    public static void Main()
    {
        NewProgram program = new NewProgram();
        program.Print += new PrintDetails(program.Show);
        program.Print("Hello World");
        
    }
}