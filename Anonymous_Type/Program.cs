// See https://aka.ms/new-console-template for more information

var obj1 = new { id = 1000,name = "Vee" };
Console.WriteLine($"id:{obj1.id},name={obj1.name}");

dynamic obj2 = new { id = 2000, name = "Scott", Email = "scott@gmail.com" };
Console.WriteLine($"id ");