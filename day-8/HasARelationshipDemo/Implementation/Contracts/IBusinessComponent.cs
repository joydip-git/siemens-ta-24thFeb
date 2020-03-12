using Implementation.Models;
using System.Collections.Generic;

namespace Implementation.Contracts
{
    public interface IBusinessComponent<T>
    {
        bool AddRecord(T item);
        ICollection<T> GetRecords();
        ICollection<T> GetRecordById(int id);
        //ICollection<T> SortRecords<TChoice>(ICollection<T> collection, TChoice choice);
        ICollection<T> SortRecords(ICollection<T> collection, EmployeeSortChoice choice);
    }
}
