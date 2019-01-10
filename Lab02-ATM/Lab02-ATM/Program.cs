using System;

namespace Lab02_ATM
{
    public class Program
    {
        public static decimal Balance = 5000; //Given account balance for program
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu) //while loop to run on page load. Controls  menu and re-reruns each time
            {
                Console.WriteLine("Do you want to use the ATM? y/n");
                string start = Console.ReadLine();
                if (start == "y") //runs menu if prompted y
                {
                    MainMenu();
                }
                else if (start == "n") //exits program if prompted n
                {
                    Environment.Exit(0);
                }
        }
        }

        /********* ATM MENU *************/
        public static void MainMenu()
        {
            Console.Clear(); //clears main prompt prior to menu load
            try // try statement designed to catch throws from methods
            {
                
                    Console.Clear(); //cleans past activity
                    Console.WriteLine("What transaction would you like to make?");
                    Console.WriteLine();
                    Console.WriteLine("1) View Balance ");
                    Console.WriteLine("2) Withdraw Money");
                    Console.WriteLine("3) Deposit Money ");
                    Console.WriteLine("4) Exit");

                    string input = Console.ReadLine(); //stores user input to pass into switch below to control flow

                    switch (input)
                    {
                        case "1": //runs method to view balance
                            ViewBalance();
                            Console.ReadLine();
                            break;
                        case "2": // runs cascading method call to withdraw money
                            WithdrawMoney(ConvertUserInput(AskWithdraw()));
                            ViewBalance();
                             Console.ReadLine();
                            break;
                        case "3": // runs cascading method call to deposit money
                            DepositMoney(ConvertUserInput(AskDeposit()));
                            ViewBalance();
                            Console.ReadLine();
                            break;
                        case "4": //exits program
                            Environment.Exit(0);

                            break;
                    }

            }
            catch (ArgumentNullException e) //catch null exception
            {
                Console.WriteLine($"You did not enter anything. Please try again.");
                Console.ReadLine();
            } 
            catch (FormatException e) // catch format exception
            {
                Console.WriteLine($"Unable to read format. Please try agian.");
                Console.ReadLine();
            }
            catch (Exception e) // catch all exception(general)
            {
                Console.WriteLine($"You've hit the following exception: {e.Message}.");
                Console.ReadLine();
            }
        }

        /********** VIEW BALANCE METHOD ************/
        public static void ViewBalance()
        {
            Console.WriteLine($"Current balance: ${Balance}");
        }

        /********** PROMPT USER INPUT FOR WITHDRAW ************/
        public static string AskWithdraw()
        {
            ViewBalance();
            Console.WriteLine("How much money would you like to withdraw?");
            string input = Console.ReadLine(); //variable to hold user input in string
            return input; //return string for conversion
        }

        /********** TEST VALIDATY OF USER INPUT  METHOD ************/
        public static decimal ConvertUserInput(string input)
        {
            try
            {
                decimal invalid = 0; // variable to return if invalid negative integer given
                decimal withdraw = Int32.Parse(input); //convert given string from end user to integer
                if (withdraw < 0) // if user input negative, display below and return 0
                {
                    Console.WriteLine("Now processing . . . ");
                    Console.WriteLine("I'm sorry but you cannot input a negative amount. Try again.");
                    return invalid;
                }
                else // if positive integer, return converted user input
                {
                    return withdraw;
                }
            }
            catch (Exception e) // catch all exceptions and handle in main
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Now processing . . . "); //regardless run message
            }
        }

        /********** PERFORM WITHDRAW************/
        public static decimal WithdrawMoney(decimal withdraw)
        {
  
            if (Balance - withdraw >= 0) //validate that withdraw will not result in negative balance
            {
                Balance = Balance - withdraw;
            }
            else // if it will result in negative balance, do not perform action, display message
            {
                Console.WriteLine("I'm sorry but the follow transactin will result in negative balance. Please deposit money first.");
            }
            return Balance;
        }

        /********** PROMPT USER INPUT FOR DEPOSIT ************/
        public static string AskDeposit()
        {
            ViewBalance();
            Console.WriteLine("How much money would you like to deposit?");
            string input = Console.ReadLine(); // variable to store user input
            return input; // return string
        }

        /********** PERFORM DEPOSIT WITH GIVEN DATA************/
        public static decimal DepositMoney(decimal deposit)
        {
                Balance = Balance + deposit; //adds given deposit converted amount to current balance
                return Balance;         
        }
    }
}
