namespace OTS.Entities
{
    /// <summary>
    /// Account class
    /// </summary>
    public class Account
    {
        #region Data Members
        private string accountHolderName;
        private int accountId;
        private decimal currentBalance;
        /// <summary>
        /// fixed minimum balance to be maintained for every account
        /// </summary>
        public const decimal MINIMUMBALANCE = 1000;
        #endregion

        #region Properties
        /// <summary>
        /// gets or sets the current balance
        /// </summary>
        public decimal CurrentBalance
        {
            get { return currentBalance; }
            set { currentBalance = value; }
        }

        /// <summary>
        /// gets or sets the account id
        /// </summary>
        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        /// <summary>
        /// gets or sets the name of account holder
        /// </summary>
        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// default constructor
        /// </summary>
        public Account()
        {

        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="accountName">name of account holder</param>
        /// <param name="accountId">id of the account</param>
        /// <param name="balance">current balance in the account</param>
        public Account(string accountName, int accountId, decimal balance)
        {
            this.accountHolderName = accountName;
            this.accountId = accountId;
            this.currentBalance = balance;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method to credit trnsferred amount into the account
        /// </summary>
        /// <param name="amount">
        /// amount to be credited
        /// </param>
        /// <returns>
        /// returns the status of the operation
        /// </returns>
        public bool CreditAmount(decimal amount)
        {
            //this.currentBalance = this.currentBalance + amount;
            this.currentBalance += amount;
            return true;
        }
        /// <summary>
        /// Method to debit amount from account
        /// </summary>
        /// <param name="amount">
        /// amount to be debited from account
        /// </param>
        /// <returns>
        /// returns the status of the operation
        /// </returns>
        public bool DebitAmount(decimal amount)
        {
            if (amount > 0)
            {
                decimal temp = this.currentBalance - amount;
                if (temp >= MINIMUMBALANCE)
                {
                    this.currentBalance -= amount;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        #endregion
    }
}
