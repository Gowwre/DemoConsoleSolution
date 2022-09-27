using OOP.Entities;

namespace OOP.Extensions;

public static class Utils
{
    public static void Display(this EmployeeManager employeeManager, List<Person> data)
    {
        foreach (var person in data)
        {
            Console.WriteLine(person);
        }
    }
}