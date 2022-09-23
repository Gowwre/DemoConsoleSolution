using OOP.Entities;
using OOP.Repository;

namespace OOP;

public class EmployeeManager:IPerson
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
        foreach (Person employee in _employees)
        {
           /*if(employee?.Display()!=null)
            Console.WriteLine(employee?.Display()??"Employee doesn't exist");*/
           if (employee!=null)
           {
               employee.Display();
           }
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

    public Person[] GetAll()
    {
        return this._employees;
    }

    public void Display()
    {
        throw new NotImplementedException();
    }

    public void Add(Person person)
    {
        if (this._size >= _employees.Length)
        {
            Employee[] temp = new Employee[this._size * 2];
            Array.Copy(this._employees, 0, temp, 0, this._size);
            this._employees = temp;

        }

        this._employees[this._size++] = employee;
    }

    public void Update(Person person)
    {
        throw new NotImplementedException();
    }

    public Person GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Delete(Person person)
    {
        throw new NotImplementedException();
    }
}

    public void Update(Person person)
    {
        throw new NotImplementedException();
    }

    public Person GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Delete(Person person)
    {
        throw new NotImplementedException();
    }
}