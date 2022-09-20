namespace readonly_const_Keyword;

public class SamplePoint
{
    public int x;

    public readonly int y = 26;
    public readonly int z;

    public const int t = 100;

    public SamplePoint()
    {
        z = 24;
    }

    public SamplePoint(int p1, int p2, int p3, int p4 = 50)
    {
        x = p1;
        y = p2;
        z = p3;
    }
}