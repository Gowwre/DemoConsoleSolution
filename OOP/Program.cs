// See https://aka.ms/new-console-template for more information

using OOP;
using OOP.Entities;

/*Human jeff = new Human("Vee","VN");
string name = "";
string address = "";
jeff.Deconstruct(out name,out address);
Console.WriteLine(name + " " + address);
Employee employee = new Employee();
employee.Id = 111;
Console.WriteLine(employee.Id);*/


/*
Customer customer = new Customer();
customer.Id = Int32.MaxValue;
Console.WriteLine($"ID: {customer.Id}, Name: {customer.CustomerName}");
customer.Id = 2000;
customer.CustomerName = "Vee";
customer.Print();
*/


/*
MyClass obj1 = new MyClass{x=1};
Console.WriteLine($"x:{obj1.x},{obj1.y}");
MyClass obj2 = new MyClass();
Console.WriteLine($"");
*/

Employee[] employees = new Employee[]
{
    new Employee(1, "Vee", new DateTime(2002, 02, 14), "BT", 250000, 29),
    new Employee(2, "Ton", new DateTime(2000, 02, 14), "PN", 555555, 25)

};
EmployeeManager employeeManager = new EmployeeManager(employees);
Employee employee = new Employee();
employee.Id = 6;
employee.Name = "Gee";
employee.Address = "PVD";
employee.WorkDay = 4;
employeeManager.Add(employee);

employeeManager.PrintAllEmployee();


