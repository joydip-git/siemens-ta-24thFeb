using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordDemo
{
    class Employee
    {
        string name;
        int id;
        decimal basicPayment;
        decimal hraPayment;
        decimal daPayment;
        //field initialization
        static decimal joiningBonus;// = 1000;
        public const decimal YEARLYBONUS = 2000;

        static Employee()
        {            
            joiningBonus = 1000;
            //YEARLYBONUS = 2000;
            Console.WriteLine($"joining bonus: {joiningBonus}");
        }

        public Employee()
        {

        }

        public Employee(string name, int id, decimal basicPay, decimal daPay, decimal hraPay)
        {
            this.name = name;
            this.id = id;
            this.basicPayment = basicPay;
            this.daPayment = daPay;
            this.hraPayment = hraPay;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public decimal BasicPayment { get => basicPayment; set => basicPayment = value; }
        public decimal HraPayment { get => hraPayment; set => hraPayment = value; }
        public decimal DaPayment { get => daPayment; set => daPayment = value; }

        public static decimal JoiningBonus { get => joiningBonus; }

        public decimal CalculateSalary()
        {
            return this.basicPayment + this.daPayment + this.hraPayment + joiningBonus + YEARLYBONUS;
        }
    }
}
