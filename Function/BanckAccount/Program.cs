using System;

class BankAccount
{
    private string accountHolder;
    private double balance;

    private static double totalBankBalance = 0;

    public BankAccount(string name, double amount)
    {
        accountHolder = name;
        balance = amount;

       totalBankBalance =  totalBankBalance + amount;
    }
         

    public void Display()
    {
        Console.WriteLine("Account Holder : " + accountHolder);
        Console.WriteLine("Balance : " + balance);
    }

    public static void ShowTotalBalance()
    {
        Console.WriteLine("Total Bank Balance : " + totalBankBalance);
    }
}

class Program
{
    static void Main()
    {
        BankAccount a1 = new BankAccount("Sanika", 5000);
        BankAccount a2 = new BankAccount("Roshan", 10000);

        a1.Display();
        a2.Display();

        BankAccount.ShowTotalBalance();
    }
}

//This example demonstrates constructor, member function, static variable, and static function together.

//Function Used
// BankAccount() → Constructor that initializes account details.
// Display() → Displays account information.
// ShowTotalBalance() → Displays the total balance of all accounts.
// Main() → Creates objects and calls the methods.