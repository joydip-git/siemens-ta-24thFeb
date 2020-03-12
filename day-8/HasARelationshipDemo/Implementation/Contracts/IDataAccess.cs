using System.Collections.Generic;

namespace Implementation.Contracts
{
    public interface IDataAccess<T>
    {
        bool Add(T item);
        List<T> GetAll();
        List<T> GetById(int id);
    }
}
