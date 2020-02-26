using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObject
{
    class Vehicle
    {
        //data member
        string modelName;
        string chasisNo;
        DateTime purchaseDate;
        decimal price;
        DateTime expiryDate;

        //functions
        public int CalculateExpiryDate()
        {
            int expiryYear = purchaseDate.Year + 15;

            expiryDate = new DateTime(expiryYear, purchaseDate.Month, purchaseDate.Day);
            return expiryYear;
        }
    }
}
