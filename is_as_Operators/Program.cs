// See https://aka.ms/new-console-template for more information

using is_as_Operators;

Rectangle rectangle = new Rectangle(1.2f, 21.5f);
ICalculate calculate;
if (rectangle is ICalculate)
{
    calculate = rectangle as ICalculate;
    Console.WriteLine("Area: {0:F2}", calculate.Area());
}
else
{
    Console.WriteLine("Interface method not implemented");
}