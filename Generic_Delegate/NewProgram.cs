namespace Generic_Delegate;

public class NewProgram
{
    static int Sum(int x, int y) => x + y;
    static void Print(string msg) => Console.WriteLine(msg.ToLower());
    public static void Main()
    {
        int a = 15, b = 25, s;
        string strResult = "Lol";

        Func<int, int, int> sumFunc = Sum;

        s = sumFunc(a, b);
        Console.WriteLine(s);
        Action<string> action = Print;
        action(strResult);
        
    }
}