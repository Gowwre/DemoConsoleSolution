using OOP.Entities;

namespace OOP.Repository;

public interface IPerson
{
    Person[] GetAll();
    void Display();
    void Add(Person person);
    void Update(Person person);
    Person GetById(int id);
    void Delete(Person person);
}