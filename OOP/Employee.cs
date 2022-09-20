namespace OOP.Entities;

public class Employee : Person
{
    //Fields
    private int _id;
    private string _name;
    private DateTime _dob;
    //Properties
    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DateTime Dob
    {
        get => _dob;
        set => _dob = value;
    }

    public string Address { get; set; }
    public double SalaryRate { get; set; }
    public int WorkDay { get; set; }

    //Constructor
    public Employee()
    {
    }

    public Employee(int id, string name, DateTime dob, string address, double salaryRate, int workDay)
    {
        Id = id;
        Name = name;
        Dob = dob;
        Address = address;
        SalaryRate = salaryRate;
        WorkDay = workDay;
    }

    //Methods
    private double _calculateSalary()
    {
        return SalaryRate * WorkDay;
    }

    public double GetSalary()
    {
        return this._calculateSalary();
    }

    public override string? ToString()
    {
        return $"Id: {Id}, Name:{Name}, Address:{Address}, Salary: {this._calculateSalary()}";
    }

    public override double GetSalary()
    {
        throw new NotImplementedException();
    }
}