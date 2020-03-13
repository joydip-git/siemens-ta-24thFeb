using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using CalculationLibrary;

namespace CalculationLibraryTest
{
    //[Serializable]
    //public class Vehicle
    //{
    //    public int Id { get; set; }
    //    public string ChasisNo { get; set; }
    //    public string ModelName { get; set; }
    //}
    [TestFixture]
    public class CalculationTest
    {
        private Calculation calculation;

        //this method will be called at the begining of everything and once only
        [OneTimeSetUp]
        public void InitializeFirst()
        {
            Console.WriteLine("one time initialization");
        }

        //this method will be called at the end of everything and once only
        [OneTimeTearDown]
        public void Dispose()
        {
            Console.WriteLine("complete clear");
        }

        //this method will be called at the begining of every test case
        [SetUp]
        public void Initialize()
        {
            calculation = new Calculation();
            Console.WriteLine("obj created");
        }

        //this method will be called at the end of every test case
        [TearDown]
        public void Clear()
        {
            calculation = null;
            Console.WriteLine("obj nullified");
        }
        [TestCase]
        public void Divide_When_Values_Are_Proper()
        {
            int actualResult = calculation.Divide(12, 3);
            //CollectionAssert.AreEqual()
            Assert.AreEqual(4, actualResult);
        }

        [TestCase]
        public void Divide_When_Exception_Occurs()
        {
            //TestDelegate test = delegate ()
            //{
            //    Calculation calculation = new Calculation();
            //    calculation.Divide(12, 0);
            //};
            TestDelegate test = () =>
             {
                 Calculation calculation = new Calculation();
                 calculation.Divide(12, 0);
             };
            Assert.Throws<DivideByZeroException>(test);
        }
    }
}
