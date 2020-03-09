using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingPersonApp.Entities
{
    abstract class Test
    {
        public abstract string Name
        {
            set; get;
        }
        public void Check() { }
        public virtual void Print() { }
        public abstract void Show();
    }
    abstract class Child : Test
    {
        public override void Print()
        {

        }
        public override void Show()
        {

        }
    }
    class Child1 : Child
    {
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
    }

    abstract class Printer
    {
        public abstract void Print();
    }
    class DeskjetPrinter : Printer
    {
        public override sealed void Print()
        {

        }
    }
    class HomeDeskjetPrinter : DeskjetPrinter
    {
        //public override void Print() { }
    }
    class LaserPrinter : Printer
    {
        public override void Print()
        {

        }
    }
    sealed class HomeLaserPrinter : LaserPrinter
    {
        public override void Print()
        {
            base.Print();
        }
    }
    class OfficeLaserPrinter : LaserPrinter
    {
        public override void Print()
        {
            base.Print();
        }
    }
}
