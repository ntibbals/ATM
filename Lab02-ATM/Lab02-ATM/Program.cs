using System;

namespace Lab02_ATM
{
    class Program
    {
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
                        Console.WriteLine("View Balance");
                        Console.ReadLine();
                        break;
                }
            }
            else if (start == "n")
                Environment.Exit(0);
        }
    }
}
