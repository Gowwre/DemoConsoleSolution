// See https://aka.ms/new-console-template for more information

using OOP;
using OOP.Entities;
using OOP.Extensions;

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

List<Employee> employees = new List<Employee>() {
    new Employee(1,"Dong",new DateTime(1983,02,19),"Quan 10",250000,29),
    new Employee(2,"Nam",new DateTime(1983,02,19),"Quan 10",230000,25),
    new Employee(3,"Minh",new DateTime(1983,02,19),"Quan 10",650000,29),
    new Employee(4,"Hai",new DateTime(1983,02,19),"Quan 10",256000,25),
    new Employee(5,"Hong",new DateTime(1983,02,19),"Quan 10",266000,24),

};
EmployeeManager employeeManager = new EmployeeManager(employees);
Employee e = new Employee(6, "Ma Van Meo", new DateTime(1983, 02, 19),
    "Quan 10", 266000, 23);

       
Console.WriteLine(new String('=',10));
employeeManager.Add(e);

//print all
employees.Sort();
employeeManager.Display(new List<Person>(employees)); 
Console.ReadKey();



