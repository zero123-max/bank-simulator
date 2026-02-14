);
            }
        }
    }

    // Withdraw method (using ref to update balance, out to communicate success or failure)
    public static void Withdraw(ref double balance, out bool isSuccessful)
    {
        double withdrawAmount;
        while (true)
        {
            Console.Write("Enter amount to withdraw: ₱");
            if (double.TryParse(Console.ReadLine(), out withdrawAmount) && withdrawAmount > 0)
            {
                if (withdrawAmount <= balance)
                {
                    balance -= withdrawAmount;
                    lastTransactionType = "Withdraw";
                    lastTransactionAmount = -withdrawAmount;
                    Console.WriteLine($"Withdrawal successful.\nUpdated Balance: ₱{balance:F2}");
                    isSuccessful = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Withdrawal failed. Insufficient balance.");
                    isSuccessful = false;
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount. Please enter a positive value.");
                isSuccessful = false;
            }
        }
    }

    // Print Mini Statement method (pass-by-value)
    public static void PrintMiniStatement(double balance)
    {
        Console.WriteLine("--- Mini Statement ---");
        Console.WriteLine($"Current Balance: ₱{balance:F2}");
        Console.WriteLine($"Last Transaction: {lastTransactionType} of ₱{lastTransactionAmount:F2}");
    }
}
