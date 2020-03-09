using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Factory
    {
        int choice;
        public Factory() { }
        public Factory(int choice)
        {
            this.choice = choice;
        }
        public IDataAccess CreateObject()
        {
            IDataAccess dataAccess = null;
            switch (this.choice)
            {
                case 1:
                    dataAccess = new FileDataAccess();
                    break;

                case 2:
                    dataAccess = new SqlDbDataAccess();
                    break;
                    
                default:
                    dataAccess = null;
                    break;
            }
            return dataAccess;
        }
    }
}
