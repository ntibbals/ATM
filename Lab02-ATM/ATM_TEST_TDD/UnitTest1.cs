using System;
using Xunit;
using Lab02_ATM;

namespace ATM_TEST_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestSubtractBalance()
        {
            //test to determine if the method subtracts from given balance
            decimal testValue = 500;
            decimal expectedValue = 4500;
            Program.Balance = 5000;
            Assert.Equal(expectedValue, Program.WithdrawMoney(testValue));

        }
        [Fact]
        public void TestWithdrawBalance()
        {
            //test to determine if the method with withdraw more than balance
            decimal testValue = 5500;
            decimal expectedValue = 5000;
            Program.Balance = 5000;
            Assert.Equal(expectedValue, Program.WithdrawMoney(testValue));
        }

        [Fact]
        public void TestAddBalance()
        {
            //test to determine if the method with withdraw more than balance
            decimal testValue = 4000;
            decimal expectedValue = 9000;
            Program.Balance = 5000;
            Assert.Equal(expectedValue, Program.DepositMoney(testValue));
        }

    }
}
