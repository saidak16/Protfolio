using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IGeneric<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(object id);
    }
}
