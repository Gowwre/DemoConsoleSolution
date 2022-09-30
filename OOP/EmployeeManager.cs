using OOP.Entities;
using OOP.Repository;

namespace OOP;

public class EmployeeManager : IEmployee<Employee>
{
    private List<Employee> _employees;
    private int _size;

    public EmployeeManager()
    {
        this._employees = new List<Employee>();
    }

    public EmployeeManager(List<Employee> employees)
    {
        _employees = employees;
    }

    public List<Employee> Employees => _employees;

    public List<Employee> GetAll()
    {
        return this._employees;
    }

    /*public void Display()
    {
        foreach (Person person in _employees)
        {
            Console.WriteLine(person);
        }
    }*/

    public void Add(Employee t)
    {
        this._employees.Add(t);
    }

    public void Update(Employee person)
    {
        /*string currentName = person.Name;
        DateTime currentDob = person.Dob;
        string currentAddress = person.Address;
        double currentRateSalary = person.SalaryRate;
        int currentWorkday = person.WorkDay;

        string? newName = Console.ReadLine();
        DateTime newDob = Convert.ToDateTime(Console.ReadLine());
        string? newAddress = Console.ReadLine();
        double newRateSalary = Convert.ToDouble(Console.ReadLine());
        int newWorkday = Int32.Parse(Console.ReadLine() ?? string.Empty);*/
    }

    public Employee GetById(int id)
    {
        foreach (var employee in Employees)
        {
            if (employee.Id.Equals(id))
            {
                return employee;
            }
        }
        return null;
    }

    public void Delete(Employee person)
    {
        this._employees.Remove(person);
    }
}