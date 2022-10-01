namespace Lambdas_Expression;

public class NewProgram
{
    static void Main()
    {
        int n1 = 35;
        int n2 = 56;
        Func<int, int, int> addNumber = (a, b) => a + b;
        int result;
        result = addNumber(n1, n2);
        Console.WriteLine(result);
    }
}