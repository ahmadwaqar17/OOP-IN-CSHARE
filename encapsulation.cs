using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accNumber)
    {
        accountNumber = accNumber;
        balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance");
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }

    // Example of encapsulation: the account number is not directly accessible
    // to the outside code
    public string GetAccountNumber()
    {
        return accountNumber;
    }
}

namespace OOP_in_Csharpe.com.organize
{
    class encapsulation
    {
    }
}
