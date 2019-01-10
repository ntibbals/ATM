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
            decimal testValue = 500;
            decimal expectedValue = 4500;
            Program.Balance = 5000;
            Assert.Equal(expectedValue, Program.WithdrawMoney(testValue));

        }
        [Fact]
        public void TestDoesWithdrawMoreThanBalance()
        {
            decimal testValue = 5500;
            decimal expectedValue = 5000;
            Program.Balance = 5000;
            Assert.Equal(expectedValue, Program.WithdrawMoney(testValue));

        }
    }
}
