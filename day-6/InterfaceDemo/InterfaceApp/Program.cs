using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    //pure abstract class
    //everything inside interface is abstract
    //methods and properties only can be written
    //no constructor
    //no data member
    //by default interface members are public and abstract, so don't declare them with either public access specifier or abstract keyword
    //interface can be eithre public or internal
    interface ITest
    {
        string Print();
        string Name { set; get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //SqlDbDataAccess dbDataAccess = new SqlDbDataAccess();
            ////implicit invocation
            //dbDataAccess.GetData();
            //dbDataAccess.PrintDbData();


            //upcasting
            //IDataAccess dataAccess = dbDataAccess;
            //explicit invocation
            //dbDataAccess.GetData();

            Console.WriteLine("1. File\n2. Database");
            Console.Write("Choose[1/2]: ");
            int choice = int.Parse(Console.ReadLine());

            Factory creator = new Factory(choice);
            IDataAccess dataAccess = creator.CreateObject();
            GetDataFromResource(dataAccess);
        }
        static void GetDataFromResource(IDataAccess dataAccess)
        {
            dataAccess.GetData();
        }
    }
}
