using OOP.Entities;
using OOP.Repository;

namespace OOP;

public class EmployeeManager:IPerson
{
    private Person[] _employees;
    private int _size;
    public EmployeeManager()
    {
        this._employees = new Employee[NumberConstant.NumberOfEmployee];
        this._size = default(int);

    }

    public EmployeeManager(Person[] employees)
    {
        _employees = employees;
        this._size = employees.Length;
    }


    public Person[] GetAll()
    {
        return this._employees;
    }

    public void Display()
    {
        foreach (Person person in _employees)
        {
            Console.WriteLine(person);
        }
    }

    public void Add(Person person)
    {
        if (this._size>= _employees.Length)
        {
            Person[] temp = new Employee[this._size * 2];
            Array.Copy(this._employees,0,temp,0,this._size);
            this._employees = temp;
        }

        this._employees[this._size++] = person;//Add this person to the last array index
    }

    public void Update(Person person)
    {
        string currentName = person.Name;
        DateTime currentDob = person.Dob;
        string currentAddress = person.Address;
        double currentRateSalary = person.SalaryRate;
        int currentWorkday = person.WorkDay;
        
        string? newName=Console.ReadLine();
        DateTime newDob=Convert.ToDateTime(Console.ReadLine());
        string? newAddress=Console.ReadLine();
        double newRateSalary=Convert.ToDouble(Console.ReadLine());
        int newWorkday=Int32.Parse(Console.ReadLine() ?? string.Empty);
    }

    public Person GetById(int id)
    {
        Person person;
        foreach (var p in _employees)
        {
            if (p.Id.Equals(id))
            {
                return p;
            }
        }
        return null;
    }

    public void Delete(Person person)
    {
        throw new NotImplementedException();
    }
}