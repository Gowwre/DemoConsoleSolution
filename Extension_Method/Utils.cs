namespace Extension_Method;

static class Utils
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Sub(this int a, int b)
    {
        return a - b;
    }
}