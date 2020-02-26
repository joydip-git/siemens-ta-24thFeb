using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObject
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Model Name: ");
                string vehicleModelName = Console.ReadLine();

                Console.Write("Chasis No: ");
                string vehicleChasisNo = Console.ReadLine();

                Console.Write("Enter purchase Date: ");
                DateTime purchaseDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Vehicle maruti800 = new Vehicle();
                //maruti800 = null;
                int year = maruti800.CalculateExpiryDate();


            }

        }
    }
}
