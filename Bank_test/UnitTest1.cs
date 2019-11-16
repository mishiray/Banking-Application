using System;
using Banks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank_test
{
    [TestClass]
    public class UnitTest1 : Starter
    {
        /// <summary>
        /// Deposit test
        /// </summary>
        [TestMethod]
        public void DepositTest()
        {
            Customer c0 = new Customer("020", "Mishael", "Abiola", "08167406144", "M", "abiolamish@gmail.com","Current", "1234", "1998,04,14", 21000, "4191234666");
            cus.Add(c0);
            double[] actual = depo("4191234666","1234",3000);
            double expected = 24000;
            Assert.AreEqual(expected, actual[0]);
            
        }

        /// <summary>
        /// Deposit test 2
        /// </summary>
        [TestMethod]
        public void DepositTest2()
        {
            Customer c1 = new Customer("021", "Racheal", "Ebong", "08034762389", "M", "rachieggo@gmail.com", "Current", "1234", "1999,02,11", 2000, "4193457666");
            cus.Add(c1);
            double[] actual = depo("4193457666", "1234", 30);
            double expected = 2000;
            Assert.AreEqual(expected, actual[0]);

        }

        /// <summary>
        /// Deposit test 3
        /// </summary>
        [TestMethod]
        public void DepositTest3()
        {
            Customer c2 = new Customer("091", "Racheal", "Ebong", "08034762389", "M", "rachieggo@gmail.com", "Savings", "1234", "1999,02,11", 1000, "4193451666");
            cus.Add(c2);
            double[] actual = depo("4193451666", "1234", -7000);
            double expected = 1000;
            Assert.AreEqual(expected, actual[0]);

        }

        /// <summary>
        /// wiithdraw test current account
        /// </summary>
        [TestMethod]
        public void WithdrawTest()
        {
            Customer c3 = new Customer("022", "Racheal", "Ebong", "08034762389", "M", "rachieggo@gmail.com","Current", "1234", "1999,02,11", 0, "4195638666");
            cus.Add(c3);
            double[] actual = withdraw("4195638666", "1234", 30000);
            double expected = 0;
            Assert.AreEqual(expected, actual[0]);
        }

        /// <summary>
        /// wiithdraw test savings account
        /// </summary>
        [TestMethod]
        public void WithdrawTest2()
        {
            Customer c4 = new Customer("023", "Michael", "Jaclson", "08056354211", "M", "micheloo@gmail.com", "Savings", "3214", "1999,02,11", 2000, "4199876666");
            cus.Add(c4);
            double[] actual = withdraw("4199876666", "3214", -50);
            double expected = 2000;
            Assert.AreEqual(expected, actual[0]);
        }

        /// <summary>
        /// wiithdraw test savings account
        /// </summary>
        [TestMethod]
        public void WithdrawTest3()
        {
            Customer c5 = new Customer("023", "Michael", "Jaclson", "08056354211", "M", "micheloo@gmail.com", "Savings", "3214", "1999,02,11", 50000, "4199886666");
            cus.Add(c5);
            double[] actual = withdraw("4199886666", "3214", 40000);
            double expected = 9950;
            Assert.AreEqual(expected, actual[0]);
        }


        /// <summary>
        /// Trnsfer money test sender account savings
        /// </summary>
        [TestMethod]
        public void TransferTest()
        {
            Customer c6 = new Customer("034", "Mishael", "Abiola", "08167406144", "M", "abiolamish@gmail.com","Savings", "1234", "1998,04,14", 21000, "4190000666");
            Customer c7 = new Customer("045", "Racheal", "Ebong", "08034762389", "F", "rachieggo@gmail.com","Savings", "1234", "1999,02,11", 25000, "4195555666");

            cus.Add(c6);
            cus.Add(c7);
            double[] result = transfer("4190000666", "1234", 1000,"4195555666");
            
            double actual = result[0];
            double expected = 19950;
            
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Trnsfer money test sender account current
        /// </summary>
        [TestMethod]
        public void TransferTest2()
        {
            Customer c8 = new Customer("068", "Mishael", "Abiola", "08167406144", "M", "abiolamish@gmail.com","Current", "1234", "1998,04,14", 20000, "4197777666");
            Customer c9 = new Customer("046", "Racheal", "Ebong", "08034762389", "F", "rachieggo@gmail.com", "Savings", "1234", "1999,02,11", 20000, "4197778666");

            cus.Add(c8);
            cus.Add(c9);
            double[] result = transfer("4197777666", "1234", 3000, "4197778666");

            double actual = result[0];//sender
            double expected = 17000;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Trnsfer money test reciepient account 
        /// </summary>
        [TestMethod]
        public void TransferTest3()
        {
            Customer c11 = new Customer("036", "Mishael", "Abiola", "08167406144", "M", "abiolamish@gmail.com", "Current", "1234", "1998,04,14", 30000, "4190009666");
            Customer c12 = new Customer("040", "Racheal", "Ebong", "08034762389", "F", "rachieggo@gmail.com", "Savings", "1234", "1999,02,11", 20000, "4195557666");

            cus.Add(c11);
            cus.Add(c12);
            double[] result = transfer("4190009666", "1234", 5000, "4195557666");

            double actual = result[1];//receiver
            double expected = 25000;

            Assert.AreEqual(expected, actual);
        }
    }
}
