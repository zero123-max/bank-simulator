public class BankingView
{
    public static void DisplayATMMenu()
    {
        Console.WriteLine("\n=== ATM System ===");
        Console.WriteLine("1: Check Balance");
        Console.WriteLine("2: Deposit Money");
        Console.WriteLine("3: Withdraw Money");
        Console.WriteLine("4: Print Mini Statement");
        Console.WriteLine("5: Exit");
    }

    public static void DisplayInvalidOptionMessage()
    {
        Console.WriteLine("Invalid option selected. Please try again.");
    }

    public static void DisplayExitMessage()
    {
        Console.WriteLine("Thank you for using the ATM. Goodbye!");
    }
}
