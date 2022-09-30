// See https://aka.ms/new-console-template for more information
using InstantiatingDelegates;
static int Add(int numOne, int numTwo) => numOne + numTwo;
static int Sub(int numOne, int numTwo) => numOne - numTwo;
int n1 = 25;
int n2 = 15;
MyDelegate obj1 = new MyDelegate(Add);
int result = obj1(n1, n2);
Console.WriteLine(result);
MyDelegate obj2 = Sub;
result = obj2.Invoke(n1, n2);

Console.WriteLine(result);
