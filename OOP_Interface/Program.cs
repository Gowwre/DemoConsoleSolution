// See https://aka.ms/new-console-template for more information

using OOP_Interface;

MyClass obj = new MyClass();
obj.Display();
IFirst first = obj;
first.Print();
ISecond second = obj;
second.Print();
