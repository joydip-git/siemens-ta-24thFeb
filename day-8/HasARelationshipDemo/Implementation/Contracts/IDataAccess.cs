using System.Collections.Generic;

namespace Implementation.Contracts
{
    public interface IDataAccess<T>
    {
        bool Add(T item);
        ICollection<T> GetAll();
        ICollection<T> GetById(int id);
    }
}
