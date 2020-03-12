using System.Collections.Generic;

namespace Implementation.Models
{
    public class EmployeeComparison : IComparer<Employee>
    {
        private EmployeeSortChoice sortChoice;
        public EmployeeComparison() { }
        public EmployeeComparison(EmployeeSortChoice choice)
        {
            this.sortChoice = choice;
        }
        public int Compare(Employee x, Employee y)
        {
            int comparisonResult;
            switch (sortChoice)
            {
                case EmployeeSortChoice.SortById:
                    comparisonResult = x.EmployeeId.CompareTo(y.EmployeeId);
                    break;

                case EmployeeSortChoice.SortByName:
                    comparisonResult = x.EmployeeName.CompareTo(y.EmployeeName);
                    break;

                case EmployeeSortChoice.SortBySalary:
                    comparisonResult = x.Salary.CompareTo(y.Salary);
                    break;

                default:
                    comparisonResult = x.EmployeeId.CompareTo(y.EmployeeId);
                    break;
            }
            return comparisonResult;
        }
    }
}
