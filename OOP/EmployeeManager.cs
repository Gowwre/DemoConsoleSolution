using OOP.Entities;

namespace OOP;

public class EmployeeManager
{
    private Employee[] _employees;
    private int _size;
    public EmployeeManager()
    {
        this._employees = new Employee[NumberConstant.NumberOfEmployee];
        this._size = default(int);

    }

    public EmployeeManager(Employee[] employees)
    {
        _employees = employees;
        this._size = employees.Length;
    }

    public void PrintAllEmployee()
    {
        foreach (var employee in _employees)
        {
            Console.WriteLine(employee);
        }
    }

    public Employee[] Employees => _employees;

    public void Add(Employee employee)
    {
        if (this._size >= _employees.Length)
        {
            Employee[] temp = new Employee[this._size * 2];
            Array.Copy(this._employees, 0, temp, 0, this._size);
            this._employees = temp;

        }

        this._employees[this._size++] = employee;
    }

    public void Update(Employee employee)
    {

    }

    public void Delete(Employee employee)
    {

    }

    public Employee GetEmployeeByID(string employeeID)
    {
        return null;
    }

}