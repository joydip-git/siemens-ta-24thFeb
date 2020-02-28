namespace EMS.Entities
{
    /// <summary>
    /// Hr class
    /// </summary>
    public class Hr : Employee
    {
        #region Data Members
        private decimal gratuityPayment;
        #endregion

        #region Constructors
        /// <summary>
        /// default constructor
        /// </summary>
        public Hr()
        {

        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="empName">name of an hr</param>
        /// <param name="empId">id of an hr</param>
        /// <param name="empBasic">basic payment of an hr</param>
        /// <param name="empDa">da payment of an hr</param>
        /// <param name="empHra">hra payment of an hr</param>
        /// <param name="empGratuity">gratuity payment of an hr</param>
        /// <param name="projectName">project name of an hr</param>
        public Hr(string empName, int empId, decimal empBasic, decimal empDa, decimal empHra, decimal empGratuity, string projectName = null)
            : base(empName, empId, empBasic, empDa, empHra, projectName)
        {
            this.gratuityPayment = empGratuity;
        }
        #endregion

        #region Propertis
        /// <summary>
        /// gets or sets the gratuity payment of an employee
        /// </summary>
        public decimal GratuityPayment { get => gratuityPayment; set => gratuityPayment = value; }
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
            decimal total = base.CalculateSalary() + this.gratuityPayment;
            return total;
        }
        #endregion
    }
}
