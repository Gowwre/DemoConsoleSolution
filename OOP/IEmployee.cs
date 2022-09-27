using OOP.Entities;

namespace OOP.Repository;

public interface IEmployee<T> where T:Person,new()
{
    List<T> GetAll();
    void Add(T t);
    void Update(T t);
    T GetById(int id);
    void Delete(T t);
}