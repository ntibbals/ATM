using System;

namespace Lab02_ATM
{
    class Program
    {
        public static decimal Balance = 5000;
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                MainMenu();
            }
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Do you want to use the ATM? y/n");
            string start = Console.ReadLine();
            if (start == "y")
            {
                Console.Clear();
                Console.WriteLine("What transaction would you like to make?");
                Console.WriteLine();
                Console.WriteLine("1) View Balance ");
                Console.WriteLine("2) Withdraw Money");
                Console.WriteLine("3) Deposit Money ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ViewBalance();
                        Console.ReadLine();
                        break;
                    case "2":
                        WithdrawMoney();
                        Console.WriteLine($"You're current account balance is ${Balance}.");
                        Console.ReadLine();
                        break;
                    case "3":
                        DepositMoney();
                        Console.WriteLine($"You're current account balance is ${Balance}.");
                        Console.ReadLine();
                        break;
                }
            }
            else if (start == "n")
                Environment.Exit(0);
        }

        public static decimal ViewBalance()
        {
            decimal currentBalance = Balance;
            Console.WriteLine($"Current balance: {currentBalance}");
            return currentBalance;
        }
        public static decimal WithdrawMoney()
        {
            Console.WriteLine("How much money would you like to withdraw?");
            string input = Console.ReadLine();
            decimal withdraw = Int32.Parse(input);
            Balance = Balance - withdraw;
            return Balance;
        }

        public static decimal DepositMoney()
        {
            Console.WriteLine("How much money would you like to deposit?");
            string input = Console.ReadLine();
            decimal deposit = Int32.Parse(input);
            Balance = Balance + deposit;
            return Balance;
        }
    }
}
