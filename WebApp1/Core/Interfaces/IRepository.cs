using System.Collections.Generic;
using WebApp1.Core.Model;

namespace WebApp1.Core.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
    T GetById(int id);
    List<T> List();
    T Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}