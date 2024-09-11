namespace ExExceptions.Entities;
using ExExceptions.Entities.Exeptions;


internal class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }
    public double WithdrawLimit { get; set; }

    public Account() { }

    public Account(int number, string holder, double balance, double withdrawLimit)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withdrawLimit;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Witdraw(double amount)
    {

        if (amount > WithdrawLimit)
        {
            throw new DomainException("The amount exceeds withdraw limit");
        }
        if (amount > Balance)
        {
            throw new DomainException("No enough balance.");
        }

        if (amount < WithdrawLimit && amount > Balance)
        {
            throw new DomainException("No enough balance.");
        }

        if (amount < Balance && amount > WithdrawLimit)
        {
            throw new DomainException("The amount exceeds withdraw limit");
        }
        Balance -= amount;
    }
}

