using Implementation.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.IOC
{
    public class DataAccessObjectProvider
    {
        public IDataAccess<TInterface> Create<TClass, TInterface>(TClass type)
        {
            return null;
        }
    }
}
