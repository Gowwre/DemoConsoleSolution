// See https://aka.ms/new-console-template for more information

/*static void MyMethod1(int a, ref int b, out int c)
{
    a = 1;
    b = 2;
    c = 3;
}

static void MyMethod2(int a, int b, int c)
{
    a = 1;
    b = 2;
    c = 3;
}

int x = 99, y = 44, z = 55;
MyMethod2(x, y, z);
Console.WriteLine($"x:{x}, y:{y}, z:{z}");
MyMethod1(x, ref y, out z);
Console.WriteLine($"x:{x}, y:{y}, z:{z}");*/

unsafe
{
    int* x = (int*)0;
    Console.WriteLine((int)x);
}