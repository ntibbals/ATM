using System;

namespace Lab02_ATM
{
    public class Program
    {
        public static decimal Balance = 5000;
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                Console.WriteLine("Do you want to use the ATM? y/n");
                string start = Console.ReadLine();
                if (start == "y")
                {
                    MainMenu();
                }
                else if (start == "n")
                {
                    Environment.Exit(0);
                }
        }
        }

        public static void MainMenu()
        {
            Console.Clear();
            try
            {

                    Console.Clear();
                    Console.WriteLine("What transaction would you like to make?");
                    Console.WriteLine();
                    Console.WriteLine("1) View Balance ");
                    Console.WriteLine("2) Withdraw Money");
                    Console.WriteLine("3) Deposit Money ");
                    Console.WriteLine("4) Exit");

                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            decimal vBalance = ViewBalance();
                            Console.WriteLine($"Current balance: ${vBalance}");
                            Console.ReadLine();
                            break;
                        case "2":
                            decimal wMoney = WithdrawMoney(GetWithdrawMoney());
                            Console.WriteLine($"Current balance: ${wMoney}");
                            Console.ReadLine();
                            break;
                        case "3":
                        decimal dMoney = DepositMoney(GetDepositMoney());
                        Console.WriteLine($"Current balance: ${dMoney}");
                        Console.ReadLine();
                        break;
                        case "4":
                            Environment.Exit(0);

                            break;
                    }

            }
            catch (Exception e)
            {
                Console.WriteLine($"You've hit the following exception: {e.Message}.");
                Console.ReadLine();
            }
        }

        public static decimal ViewBalance()
        {
            decimal currentBalance = Balance;
            return currentBalance;
        }
        public static decimal GetWithdrawMoney()
        {
   
            try
            {
                Console.WriteLine("How much money would you like to withdraw?");
                string input = Console.ReadLine();
                decimal invalid = 0;
                decimal withdraw = Int32.Parse(input);
                if (withdraw < 0)
                {
                    Console.WriteLine("I'm sorry but you cannot withdraw negatively. Try again.");
                    return invalid;
                }
                else
                {
                    return withdraw;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static decimal WithdrawMoney(decimal withdraw)
        {
  
            if (Balance - withdraw > 0)
            {
                Balance = Balance - withdraw;
            }
            else if (Balance - withdraw < 0)
            {
                Console.WriteLine("I'm sorry but the follow transactin will result in negative balance. Please deposit money first.");
            }
            return Balance;
        }

        public static decimal GetDepositMoney()
        {
      
            try
            {
                Console.WriteLine("How much money would you like to deposit?");
                string input = Console.ReadLine();
                decimal invalid = 0;
                decimal deposit = Int32.Parse(input);
                if (deposit < 0)
                {
                    Console.WriteLine("I'm sorry but you cannot withdraw negatively. Try again.");
                    return invalid;
                }
                else
                {
                    return deposit;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public static decimal DepositMoney(decimal deposit)
        {

                Balance = Balance + deposit;
                return Balance;         
        }
    }
}
