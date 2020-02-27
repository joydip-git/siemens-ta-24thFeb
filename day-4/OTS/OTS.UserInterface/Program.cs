using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OTS.Entities;

namespace OTS.UserInterface
{
    /// <summary>
    /// User interface class
    /// </summary>
    class Program
    {
        /// <summary>
        /// method to create an account object on the basis of values taken from user
        /// </summary>
        /// <returns>
        /// returns the reference of created account object
        /// </returns>
        static Account CreateAccount()
        {
            Account account = new Account();

            Console.Write("\nName: ");
            account.AccountHolderName = Console.ReadLine();

            Console.Write("Id: ");
            account.AccountId = int.Parse(Console.ReadLine());

            Console.Write("Balance: ");
            account.CurrentBalance = decimal.Parse(Console.ReadLine());

            return account;
        }
        static decimal GetAmount()
        {
            Console.Write("\nEnter amount to transfer: ");
            return decimal.Parse(Console.ReadLine());
        }
        static void Main()
        {
            Account debitAccount = CreateAccount();
            Account creditAccount = CreateAccount();

            decimal amountToTransfer = GetAmount();

            TransferAmount(debitAccount, creditAccount, amountToTransfer);

            DisplayBalance(creditAccount);
            DisplayBalance(debitAccount);
        }
        /// <summary>
        /// Method to display balance
        /// </summary>
        /// <param name="account">
        /// account whose balance should be displayed
        /// </param>
        private static void DisplayBalance(Account account)
        {
            Console.WriteLine($"{account.AccountHolderName} has {account.CurrentBalance} as balance");
        }

        /// <summary>
        /// method to transfer amount from one account to another
        /// </summary>
        /// <param name="debitAccount">account where amount should be debited from</param>
        /// <param name="creditAccount">account where amount should be credited to</param>
        /// <param name="amountToTransfer">
        /// amount to transfer
        /// </param>
        private static void TransferAmount(Account debitAccount, Account creditAccount, decimal amountToTransfer)
        {
            bool debitStatus = debitAccount.DebitAmount(amountToTransfer);
            if (debitStatus)
            {
                bool creditStatus = creditAccount.CreditAmount(amountToTransfer);
                if (!creditStatus)
                    debitAccount.CreditAmount(amountToTransfer);
            }
        }
    }
}
