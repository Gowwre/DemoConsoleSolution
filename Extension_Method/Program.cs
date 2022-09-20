// See https://aka.ms/new-console-template for more information

using Extension_Method;

int x = 3,y=2;
int r = Utils.Add(x, y);
Console.WriteLine($"{x}+{y}={r}");
r = x.Sub(y);
Console.WriteLine($"{x}-{y}={r}");