namespace EMS.Entities
{
    /// <summary>
    /// Developer class
    /// </summary>
    public class Developer : Employee
    {
        #region Data Members
        private decimal incentivePayment;
        #endregion

        #region Constructors
        /// <summary>
        /// default constructor
        /// </summary>
        public Developer()
        {

        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="empName">name of a developer</param>
        /// <param name="empId">id of a developer</param>
        /// <param name="empBasic">basic payment of a developer</param>
        /// <param name="empDa">da payment of a developer</param>
        /// <param name="empHra">hra payment of a developer</param>
        /// <param name="empIncentive">incentive payment of a developer</param>
        /// <param name="projectName">project name of a developer</param>
        public Developer(string empName, int empId, decimal empBasic, decimal empDa, decimal empHra, decimal empIncentive, string projectName = null)
            : base(empName, empId, empBasic, empDa, empHra, projectName)
        {
            this.incentivePayment = empIncentive;
        }
        #endregion

        #region Propertis
        /// <summary>
        /// gets or sets the incentive payment of an employee
        /// </summary>
        public decimal IncentivePayment { get => incentivePayment; set => incentivePayment = value; }
        #endregion

        #region methods
        /// <summary>
        /// method to calculate total salary of an employee
        /// </summary>
        /// <returns>
        /// returns calculated total salary
        /// </returns>
        //public new decimal CalculateSalary()
        public override decimal CalculateSalary()
        {
            decimal total = base.CalculateSalary() + this.incentivePayment;
            return total;
        }
        #endregion
    }
}
