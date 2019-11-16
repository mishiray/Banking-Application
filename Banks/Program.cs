
using System;
using System.Collections.Generic;
using System.Linq;


namespace Banks

{
    /// <summary>
    /// Starter class is the main class that does all the banking transactions
    /// </summary>
    public class Starter : Interactive
    {

        string name;

        int idd = 1;

        /// <summary>
        /// List cus is a new List that has the customer class as data type
        /// </summary>
        public static List<Customer> cus = new List<Customer>();

        /// <summary>
        /// Method to allows user enter their name and then move to next transaction 
        /// </summary>
        public void WelcomeUser()
        {
            Console.WriteLine("\nAI>> Good day!!! How may I be of help to you today?");
            think();
            Console.WriteLine("AI>> Ah yes Pardon me,  what do i call you");
            Console.Write("Unknown" + ">>");
            name = Console.ReadLine();
            Console.WriteLine("AI>> Alright thank you " + name.ToUpper() + "\n");
            think();
            two();
        }

        /// <summary>
        /// Gives user choices of possible transactions
        /// </summary>
        public void two()
        {
            int choice = 1;
            Console.WriteLine();
            Console.WriteLine("AI>> Here are your options");
            //Open an account option
            Console.Write("1>> OPEN AN ACCOUNT\n");
            //Make deposit
            Console.Write("2>> MAKE DEPOSIT\n");
            //Make Withdrawal
            Console.Write("3>> MAKE WITHDRAWAL\n");
            //Check Acc Balance
            Console.Write("4>> CHECK ACCOUNT BALANCE\n");
            //Transfer to another acc in list
            Console.Write("5>> TRANSFER FUNDS\n");
            //Print out all accounts in Bank
            Console.Write("6>> View All accounts in the bank\n");
            //exit
            Console.Write("7>> Exit App\n");

            //Enter choice
            Console.Write(name.ToUpper() + ">>");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong Choice");
                two();
            }

            Console.WriteLine();
            //method that contains transactions
            three(choice);
        }

        /// <summary>
        /// The method uses switch method to access different transaction options as methods
        /// </summary>
        /// <param name="ch">Takes the choice of users as int</param>
        /// <return>Returns the different methods</return>
        public void three(int ch)
        {
            switch (ch)
            {
                case 1:
                    //get info method
                    getInfo();
                    break;
                case 2:
                    //deposit funds method
                    dposit_main();
                    break;
                case 3:
                    //withdraw funds method
                    withdrawal_main();
                    break;
                case 4:
                    //get account balance method
                    accBal();
                    break;
                case 5:
                    //transfer funds to accounts on the list 
                    transfer_main();
                    break;
                case 6:
                    //view all accounts;
                    viewAll();
                    break;
                case 7:
                    //exit app
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Error: Wrong Option");
                    two();
                    break;
            }
        }

        /// <summary>
        /// This creates a new customer object and allows users enter valid details,
        /// stores each user data in rewuired fields.
        /// </summary>
        /// <return>Returns new customer</return>
        public void getInfo()
        {
            //create new customer object
            Customer customer = new Customer();

            //variables to be used to hold user details 
            string firstName, lastName, mobileNumber, date, sex, email, pin;

            //Use rand class to generate random digits for the account number
            Random rand = new Random();
            string acc = "419" + rand.Next(1111, 9999) + "666";
            string accountNumber = acc;

            Console.WriteLine("ENTER YOUR VALID DETAILS");

            //Firstname
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            customer.FirstName = firstName;
            name = firstName;

            //Lastname
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            customer.LastName = lastName;

            //Date of birth
            //Use DateTime formatting to get user age 
            Console.Write("Date of birth (yyyy,mm,dd): ");
            date = Console.ReadLine();
            DateTime e = DateTime.Now;
            int y = e.Year;
            DateTime f;
            try
            {
                f = (Convert.ToDateTime(date));
            }
            catch (Exception)
            {
                f = new DateTime(1999, 01, 01);
            }
            int x = f.Year;
            int z = y - x;
            customer.DateOfBirth = date;
            customer.DateOfAcctCreation = e.ToString();
            customer.Age = z.ToString();

            //Mobile NUmber
            Console.Write("Mobile Number: ");
            mobileNumber = Console.ReadLine();
            customer.MobileNumber = mobileNumber;

            //Sex
            Console.Write("Sex: ");
            sex = Console.ReadLine();
            customer.Sex = sex;

            //Email
            Console.Write("Email: ");
            email = Console.ReadLine();
            customer.Email = email;

            //Account Type
            Console.Write("Account Type: [1] Savings    [2] Current:        ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    customer.Acctyp = "Savings";
                    break;
                case 2:
                    customer.Acctyp = "Current";
                    break;
                default:
                    customer.Acctyp = "Savings";
                    break;
            }


            //User Pin
            Console.Write("Enter pin or password: ");
            pin = Console.ReadLine();
            customer.Pin = pin;

            //Account Number
            customer.AccountNumber = accountNumber;
            cus.Add(customer);

            int t = cus.Count();

            customer.ID = "0" + idd;
            idd++;

            think();
            Console.WriteLine("AI>> Registration successful");
            Console.WriteLine("AI>> Your Account number is " + customer.AccountNumber);
            Console.WriteLine();

            Console.WriteLine("AI>> Press [1] Print account information [2] Perform another transaction\n\n");
            Console.Write(name.ToUpper() + ">>");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    printAccInfo(t - 1);
                    break;
                case 2:
                    two();
                    break;
            }


        }


        /// <summary>
        /// cheacc method checks if the accounts exists
        /// </summary>
        /// <param name="acc">takes in the account number</param>
        /// <param name="pin">takes in the account pin</param>
        /// <returns>Returns the index of the customer in the list if found</returns>
        public int checacc(string acc,string pin)
        {
            int cnt = cus.Count();
            int index = 0;
            bool z = false;
            //Loop through customers.AccountNumber in cus list and return true if user account number is found 
            for (int i = 0; i < cnt; i++)
            {
                if (acc == cus[i].AccountNumber)
                {
                    index = i;
                    z = true;
                    break;
                }
            }

            //else print not found and then..allowmuser choose another option
            if (z == false)
            {
                Console.WriteLine("AI>> Account not found..Do you wish to open an account? \nAI>>[1]YES\t[2]NO");
                Console.Write(name.ToUpper() + ">>");
                int d = Convert.ToInt32(Console.ReadLine());
                switch (d)
                {
                    case 1:
                        getInfo();
                        break;
                    case 2:
                        two();
                        break;
                    default:
                        WelcomeUser();
                        break;
                }

            }

            Console.WriteLine("AI>> Account number Ok");
            try
            {
                if (pin == cus[index].Pin)
                {
                    think();
                    Console.WriteLine("AI>> Pin Ok");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("AI>> Account not found..Do you wish to open an account? \nAI>>[1]YES\t[2]NO");
                Console.Write(name.ToUpper() + ">>");
                int c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        getInfo();
                        break;
                    case 2:
                        two();
                        break;
                    default:
                        WelcomeUser();
                        break;
                }

            }

            return index;
        }

        /// <summary>
        /// Deposit_main method gets user details then calls depo method
        /// </summary>
        public void dposit_main()
        {
            String acc, pin;
            double y = 0;
            think();
            Console.WriteLine("AI>> Enter Your Account Number");
            Console.Write(name.ToUpper() + ">>");
            acc = Console.ReadLine();
            think();
            Console.WriteLine("AI>> Enter Your pin");
            Console.Write(name.ToUpper() + ">>");
            pin = Console.ReadLine();
            think();
            Console.WriteLine("AI>> Enter amount");
            Console.Write(name.ToUpper() + ">>");
            try
            {
                y = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nTry Again: ");

                dposit_main();
            }

            double[] details = depo(acc, pin, y);
            printDetails(Convert.ToInt32(details[1]));
        }

        /// <summary>
        /// depo does the validation of account detailsand then deposits into the account
        /// </summary>
        /// <param name="acc">this param takestheaccount number</param>
        /// <param name="pin">this param takes the pin of the acc</param>
        /// <param name="amount">this param takes the amount to be deposited</param>
        /// <returns>returns new acc balance and customer index</returns>
        public double[] depo(String acc, string pin, double amount)
        {
            int index = 0;
            double[] tempacc = new double[2];

            index = checacc(acc, pin);

            if (cus[index].Acctyp == "Savings")
            {
                Savings s = new Savings();
                cus[index].AccountBalance = s.deposit(amount, cus[index].AccountBalance);
                tempacc[0] = cus[index].AccountBalance;
            }
            else if (cus[index].Acctyp == "Current")
            {
                Current c = new Current();
                cus[index].AccountBalance = c.deposit(amount, cus[index].AccountBalance);
                tempacc[0] = cus[index].AccountBalance;
            }
            else
            {
                Console.WriteLine("Account Not Found");
                two();
            }

            tempacc[1] = index;
            //Done!
            return tempacc;
        }

        /// <summary>
        /// withdraws virtual cash from the user account and then calls withdraw method
        /// </summary>
        public void withdrawal_main()
        {
            String acc, pin;
            double y = 0;
            
            think();
            Console.WriteLine("AI>> Enter Your Account Number");
            Console.Write(name.ToUpper() + ">>");
            acc = Console.ReadLine();
            think();
            Console.WriteLine("AI>> Enter Your pin");
            Console.Write(name.ToUpper() + ">>");
            pin = Console.ReadLine();
            think();
            Console.WriteLine("AI>> Enter amount");
            Console.Write(name.ToUpper() + ">>");
            try
            {
                y = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nTry Again: ");

                withdrawal_main();
            }
            //details collects results from withdraw
            double[] details = withdraw(acc, pin, y);
            Console.WriteLine("Transaction successful");
            printDetails(Convert.ToInt32(details[1]));
        }

        /// <summary>
        /// withdraw does the validation of account detailsand then deposits into the account
        /// </summary>
        /// <param name="acc">this param takestheaccount number</param>
        /// <param name="pin">this param takes the pin of the acc</param>
        /// <param name="amount">this param takes the amount to be withdrawn</param>
        /// <returns>returns new acc balance and index of customer</returns>
        public double[] withdraw(String acc, string pin, double amount)
        {
            int index = 0;

            double[] tempacc = new double[2];

            index = checacc(acc, pin);
            if (cus[index].Acctyp=="Savings")
                {
                    Savings s = new Savings();
                    cus[index].AccountBalance = s.withdraw(amount, cus[index].AccountBalance);
                    
                    tempacc[0] = cus[index].AccountBalance;
                }
                else if (cus[index].Acctyp=="Current")
                {
                Current c = new Current();
                cus[index].AccountBalance = c.withdraw(amount, cus[index].AccountBalance);
                tempacc[0] = cus[index].AccountBalance;
                }
                else
                {
                Console.WriteLine("Account Not Found");
                }
            
            tempacc[1] = index; 
            //Done!
            return tempacc;
        }

        /// <summary>
        /// withdraw method validates acc num and pin and then withdraws virtual cash from the user account 
        /// </summary>
        /// <variable name="acc">Holds the account number of the destination account</variable>
        /// <variable name="pin">Holds the pin that the user inputs</variable>
        public void accBal()
        {
            String acc, pin;
            int index = 0;
            think();
            Console.WriteLine("AI>> Enter Your Account Number");
            Console.Write(name.ToUpper() + ">>");
            acc = Console.ReadLine();
            think();
            int cnt = cus.Count();
            bool y = false;

            for (int i = 0; i < cnt; i++)
            {
                if (acc == cus[i].AccountNumber)
                {
                    index = i;
                    y = true;
                    break;
                }
            }

            if (y == false)
            {
                Console.WriteLine("AI>> Account not found..Do you wish to open an account? \nAI>>[1]YES\t[2]NO");
                Console.Write(name.ToUpper() + ">>");
                int d = Convert.ToInt32(Console.ReadLine());
                switch (d)
                {
                    case 1:
                        getInfo();
                        break;
                    case 2:
                        two();
                        break;
                    default:
                        WelcomeUser();
                        break;
                }

            }

            Console.WriteLine("AI>> Account number Ok");
            try
            {
                Console.WriteLine("AI>> Enter Account Pin");
                Console.Write(name.ToUpper() + ">>");
                pin = Console.ReadLine();
                if (pin == cus[index].Pin)
                {
                    think();
                    Console.WriteLine("AI>> Pin Ok");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("AI>> Account not found..Do you wish to open an account? \nAI>>[1]YES\t[2]NO");
                Console.Write(name.ToUpper() + ">>");
                int d = Convert.ToInt32(Console.ReadLine());
                switch (d)
                {
                    case 1:
                        getInfo();
                        break;
                    case 2:
                        two();
                        break;
                    default:
                        WelcomeUser();
                        break;
                }

            }

            //Display account balance
            Console.WriteLine("Your account balance is: " + cus[index].AccountBalance);

            Console.WriteLine("AI>> Do you wish to perform another transaction \nAI>>[1]YES\t[2]NO");
            Console.Write(name.ToUpper() + ">>");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    two();
                    break;
                case 2:
                    WelcomeUser();
                    break;
                default:
                    WelcomeUser();
                    break;
            }

        }

        /// <summary>
        /// transfer method makes user transfer funds from account to another account in the list
        /// </summary>
        public void transfer_main()
        {
            String acc, acc2, pin;
            double y = 0;
            think();
            Console.WriteLine("AI>> Enter Your Account Number");
            Console.Write(name.ToUpper() + ">>");
            acc = Console.ReadLine();
            think();
            Console.WriteLine("AI>> Enter Your pin");
            Console.Write(name.ToUpper() + ">>");
            pin = Console.ReadLine();
            think();
            Console.WriteLine("AI>> Enter amount");
            Console.Write(name.ToUpper() + ">>");
            try
            {
                y = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nTry Again: ");
                transfer_main();
                
            }

            Console.WriteLine("Accounts Present: ");

            foreach (Customer cusr in cus)
            {
                Console.WriteLine("Customer Id:" + cusr.ID + " \t Acc Type: " + cusr.Acctyp + " \tAcc Number: " + cusr.AccountNumber + " \tFirst Name: " + cusr.FirstName.ToUpper() + " \tLast Name: " + cusr.LastName.ToUpper());
            }
            

            Console.WriteLine("\n\nAI>> Enter account number of recipient");
            Console.Write(name.ToUpper() + ">>");
            acc2 = Console.ReadLine();

            double[] details = transfer(acc, pin, y, acc2);

            Console.WriteLine("Transaction successful");
            printDetails(Convert.ToInt32(details[2]));
        }

        /// <summary>
        /// transfer does transfer of money from acc to acc2
        /// </summary>
        /// <param name="acc">this param takes the account number of customer</param>
        /// <param name="pin">this param takes the pin of the acc</param>
        /// <param name="amount">this param takes the amount to be transferred</param>
        /// <param name="acc2">this param takes the account number of reciepient</param>
        /// <returns>returns new acc balance of the two customers in an array and the index of the customer</returns>
        public double[] transfer(String acc, string pin, double amount, String acc2)
        {
            int cnt = cus.Count();
            double[] result = new double[3];
            double tempacc;
            int index = 0;
            int index2 = 0;
            bool z = false;

            index = checacc(acc, pin);

            //validate second account
            for (int j = 0; j < cnt; j++)
            {
                if (acc2 == cus[j].AccountNumber)
                {
                    index2 = j;
                    z = true;
                    break;
                }
            }

            //else print not found 
            if (z == false)
            {
                Console.WriteLine("AI>> Reciepient account not found");
                two();
            }

                if (cus[index].Acctyp == "Savings")
                {
                    Savings s = new Savings();
                    cus[index2].AccountBalance = s.deposit(amount,cus[index2].AccountBalance);
                    cus[index].AccountBalance = s.withdraw(amount, cus[index].AccountBalance);
                    tempacc = cus[index].AccountBalance;
                }
                else if (cus[index].Acctyp == "Current")
                {

                    Current c = new Current();
                    cus[index2].AccountBalance = c.deposit(amount, cus[index2].AccountBalance);
                    cus[index].AccountBalance = c.withdraw(amount, cus[index].AccountBalance);
                    tempacc = cus[index].AccountBalance;
                }
                else
                {
                    Console.WriteLine("Account Not Found");
                    two();

                }

                result[0] = cus[index].AccountBalance;
                result[1] = cus[index2].AccountBalance;
                result[2] = index;
                Console.WriteLine("Transfer Successful");


            return result;
        }

        /// <summary>
        /// Prints out customer details 
        /// </summary>
        /// <param name="t">gets the index of desired customer</param>
        public void printDetails(int t)
        {

            Customer cusr = cus[t];
            DateTime d = DateTime.Now;
            think();
            Console.WriteLine();
            Console.WriteLine("Account Details: ");
            Console.WriteLine("Customer Id: 00{0}", cusr.ID);
            load();
            Console.WriteLine("Account Type: {0}", cusr.Acctyp);
            load();
            Console.WriteLine("Account Number: {0}", cusr.AccountNumber);
            load();
            Console.WriteLine("Account Balance: {0}", cusr.AccountBalance);
            load();
            Console.WriteLine("First Name: {0}", cusr.FirstName.ToUpper());
            load();
            Console.WriteLine("Last Name: {0}", cusr.LastName.ToUpper());
            load();
            Console.WriteLine("Date of Transaction: {0}", d.ToString());
            Console.WriteLine();
            //break;

            two();
        }

        /// <summary>
        /// prints out account info of customer
        /// </summary>
        /// <param name="t">getsthe index of customer in list</param>
        public void printAccInfo(int t)
        {
            Customer cusr = cus[t];
            Console.WriteLine("Account Information: \n\n");
            Console.WriteLine("Customer Id: 00{0}", cusr.ID);
            Console.WriteLine("Account Type: {0}", cusr.Acctyp);
            Console.WriteLine("Account Number: {0}", cusr.AccountNumber);
            Console.WriteLine("First Name: {0}", cusr.FirstName.ToUpper());
            Console.WriteLine("Last Name: {0}", cusr.LastName.ToUpper());
            Console.WriteLine("Account Balance: {0}", cusr.AccountBalance);
            Console.WriteLine("Mobile Number: {0}", cusr.MobileNumber);
            Console.WriteLine("Date of Birth: {0}", cusr.DateOfBirth);
            Console.WriteLine("Age: {0}", cusr.Age);
            Console.WriteLine("Date of Creation: {0}", cusr.DateOfAcctCreation);
            Console.WriteLine("Email: {0}", cusr.Email);
            Console.WriteLine();
            //break;

            two();
        }

        /// <summary>
        /// Returns all the accouts present in the list
        /// </summary>
        public void viewAll()
        {
            Console.WriteLine("Accounts Present: ");

            foreach (Customer cusr in cus)
            {
                Console.WriteLine("Customer Id:" + cusr.ID + " \t Acc Type: " + cusr.Acctyp + " \tAcc Number: " + cusr.AccountNumber + " \tFirst Name: " + cusr.FirstName.ToUpper() + " \tLast Name: " + cusr.LastName.ToUpper());
            }

            two();
        }

        static void Main(string[] args)
        {
            //Creates dummy accounts in the list
            Customer c1 = new Customer("020", "Mishael", "Abiola", "08167406144", "M", "abiolamish@gmail.com","Savings", "1234", "1998,04,14", 21000, "4191111666");
            Customer c2 = new Customer("021", "Racheal", "Ebong", "08034762389", "M", "rachieggo@gmail.com","Current", "1234", "1999,02,11", 35000, "4192222666");
            Customer c3 = new Customer("023", "Kosi", "Daniels", "08034228945", "F", "fishylady@gmail.com","Savings", "1234", "2001,12,24", 11500, "4193333666");


            //adds them to the list
            cus.Add(c1);
            cus.Add(c2);
            cus.Add(c3);

            Starter start = new Starter();
            start.WelcomeUser();

        }

    }

}