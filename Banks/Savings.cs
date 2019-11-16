using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks
{
    /// <summary>
    /// Savings Transactions class
    /// </summary>
    public class Savings 
    {
        /// <summary>
        /// Constructor for the class
        /// </summary>
        public Savings()
        {

        }

        /// <summary>
        /// Does deposits of an accout
        /// </summary>
        /// <param name="amount">Takes in the amount to be deposited</param>
        /// <param name="acbalance">takes the present acc balance of the account</param>
        /// <returns>returns the new account balance</returns>
        public double deposit(double amount, double acbalance)
        {
            if (amount < 200)
            {
                Console.WriteLine("Amount to small to deposit");
            }
            else
            {
                double temp = 0.02 * amount;
                acbalance += temp;
                acbalance += amount;
            }

            return acbalance;
        }
        /// <summary>
        /// Does withdrawal of an accout
        /// </summary>
        /// <param name="amount">Takes in the amount to be withdrawn</param>
        /// <param name="acbalance">takes the present acc balance of the account</param>
        /// <returns>returns the new account balance</returns>
        public double withdraw(double amount, double acbalance) {
            if (amount > acbalance+200)
            {
                Console.WriteLine("You cannot withdraw");
            }
            else
            {
                acbalance -= 50;
                acbalance -= amount;
            }
            return acbalance;
        }

    }
}
