namespace EMS.Entities
{
    /// <summary>
    /// class for employee
    /// </summary>
    public class Employee
    {
        #region data members
        private string employeeName;
        private int employeeId;
        private decimal basicPayment;
        private decimal daPayment;
        private decimal hraPayment;
        private string projectName;
        #endregion

        #region constructors
        /// <summary>
        /// default constructor
        /// </summary>
        public Employee()
        {
        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="employeeName">name of an employee</param>
        /// <param name="employeeId">id of an employee</param>
        /// <param name="basicPayment">basic payment of an employee</param>
        /// <param name="daPayment">da payment of an employee</param>
        /// <param name="hraPayment">hra payment of an employee</param>
        /// <param name="projectName">name of project of an employee</param>
        public Employee(string employeeName, int employeeId, decimal basicPayment, decimal daPayment, decimal hraPayment, string projectName = null)
        {
            this.employeeName = employeeName;
            this.employeeId = employeeId;
            this.basicPayment = basicPayment;
            this.daPayment = daPayment;
            this.hraPayment = hraPayment;
            this.projectName = projectName;
        }
        #endregion

        #region properties or property functions
        /// <summary>
        /// sets or gets the name of an employee
        /// </summary>
        public string EmployeeName
        {
            //public void SetEmployeeName(string employeeName)
            set { this.employeeName = value; }
            //public string GetEmployeeName()
            get { return employeeName; }
        }
        /// <summary>
        /// sets or gets the unique id of an employee
        /// </summary>
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        /// <summary>
        /// sets or gets the basic payment of an employee
        /// </summary>
        public decimal BasicPayment
        {
            get => basicPayment;
            set => basicPayment = value;
        }
        /// <summary>
        /// sets or gets the da payment of an employee
        /// </summary>
        public decimal DaPayment
        {
            get => daPayment;
            set => daPayment = value;
        }
        /// <summary>
        /// sets or gets the hra payment of an employee
        /// </summary>
        public decimal HraPayment
        {
            get => hraPayment;
            set => hraPayment = value;
        }
        /// <summary>
        /// sets or gets the name of project of an employee
        /// </summary>
        public string ProjectName
        {
            set { this.projectName = value; }
            get { return this.projectName; }
        }
        #endregion

        #region methods
        /// <summary>
        /// method to calculate total salary of an employee
        /// </summary>
        /// <returns>
        /// returns calculated total salary
        /// </returns>
        public virtual decimal CalculateSalary()
        {
            decimal total = this.basicPayment + daPayment + hraPayment;
            return total;
        }
        #endregion
    }
}
