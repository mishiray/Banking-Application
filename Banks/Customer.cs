using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks
{
    /// <summary>
    /// Class Customer holds the customer inform    ation
    /// </summary>
    public class Customer
    {
        
        private string age;
        private string id;
        private double accountBalance;
        private string firstName;
        private string lastName;
        private string mobileNumber;
        private string dateOfCreation;
        private string dob;
        private string accountNumber;
        private string sex;
        private string email;
        private string pin;
        private string acctype;


        /// <summary>
        /// Overloadable customer constructor 
        /// </summary>
        public Customer()
        {

        }

        /// <summary>
        /// Customer constructor that holds all customer information
        /// </summary>
        /// <param name="id">gets the id of customer</param>
        /// <param name="firstName">gets the firstname</param>
        /// <param name="lastName">gets the lastname</param>
        /// <param name="mobileNumber">gets the mobile number</param>
        /// <param name="sex">gets the gender of customer</param>
        /// <param name="email">cgets the email of customer</param>
        /// <param name="pin">gets the pin of account</param>
        /// <param name="dob">gets the date of birth of customer</param>
        /// <param name="accountBalance">gets the account balance of customer</param>
        /// <param name="accNumber">gets the account number</param>
        /// <param name="accTyp">takes the acctype: savings or current</param>
        public Customer(string id, string firstName, string lastName, string mobileNumber, string sex, string email, string accTyp, string pin, string dob,double accountBalance,string accNumber)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileNumber = mobileNumber;
            this.sex = sex;
            this.email = email;
            this.pin = pin;
            this.dob = dob;
            this.accountBalance = accountBalance;
            this.accountNumber = accNumber;
            this.acctype = accTyp;
        }

        /// <summary>
        /// Mutator and accessor method for age
        /// </summary>
        /// <value>returns the age of the customer</value>
        public string Age
        {
            set
            {
                age = value;
            }

            get

            {
                return age;
            }
        }

        /// <summary>
        /// Mutator and accessor method for accountnumber
        /// </summary>
        /// <value>returns the account number of the customer</value>
        public string AccountNumber
        {

            set
            {
                accountNumber = value;
            }

            get
            {
                return accountNumber;
            }
        }

        /// <summary>
        /// Mutator and accessor method for id
        /// </summary>
        /// <value>returns the id of the customer</value>
        public string ID
        {

            set
            {
                id = value;
            }

            get
            {
                return id;
            }
        }

        /// <summary>
        /// Mutator and accessor method for accountbalance
        /// </summary>
        /// <value>returns the account balance of the customer</value>
        public double AccountBalance
        {

            set
            {
                accountBalance = value;
            }
            get
            {
                return accountBalance;
            }
        }

        /// <summary>
        /// Mutator and accessor method for firstname
        /// </summary>
        /// <value>returns the firstname of the customer</value>
        public string FirstName
        {

            set
            {
                firstName = value;
            }
            get
            {
                return firstName;
            }
        }

        /// <summary>
        /// Mutator and accessor method for lastname
        /// </summary>
        /// <value>returns the lastname of the customer</value>
        public string LastName
        {

            set
            {
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }

        /// <summary>
        /// Mutator and accessor method for mobilenumber
        /// </summary>
        /// <value>returns the mobilenumber of the customer</value>
        public string MobileNumber
        {

            set
            {
                mobileNumber = value;
            }

            get
            {
                return mobileNumber;
            }
        }

        /// <summary>
        /// Mutator and accessor method for sex
        /// </summary>
        /// <value>returns the sex of the customer</value>
        public string Sex
        {

            set
            {
                sex = value;
            }

            get
            {
                return sex;
            }
        }

        /// <summary>
        /// Mutator and accessor method for email
        /// </summary>
        /// <value>returns the email of the customer</value>
        public string Email
        {

            set
            {
                email = value;
            }

            get
            {
                return email;
            }
        }

        /// <summary>
        /// Mutator and accessor method for pin
        /// </summary>
        /// <value>returns the pin of the customer</value>
        public string Pin
        {

            set
            {
                pin = value;
            }

            get
            {
                return pin;
            }
        }

        /// <summary>
        /// Mutator and accessor method for date of creation
        /// </summary>
        /// <value>returns the dateofcreation of the customer</value>
        public string DateOfAcctCreation
        {

            set
            {
                dateOfCreation = value;
            }
            get
            {
                return dateOfCreation;
            }
        }

        /// <summary>
        /// Mutator and accessor method for date of birth
        /// </summary>
        /// <value>returns the date of birth of the customer</value>
        public string DateOfBirth
        {

            set
            {
                dob = value;
            }
            get
            {
                return dob;
            }
        }

        /// <summary>
        /// Mutator and accessor method for account type
        /// </summary>
        /// <value>returns the account type of the account the customer</value>
        public string Acctyp
        {
            set
            {
                acctype = value;
            }
            get
            {
                return acctype;
            }
        }
    }
}
