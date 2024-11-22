using EshopPattern.Exceptions;

namespace EshopPattern.Entities;

public class CreditCard
{
    public int Id { get; private set; }
    public decimal Money { get; private set; }

    public CreditCard()
    {
        var r = new Random();
        var rInt = r.Next(1, 100_000_000);
        Id = rInt;
    }

    public decimal Withdraw(decimal amount)
    {
        if (amount > Money)
        {
            throw new NotEnoughMoneyException();
        }

        Money -= amount;
        return Money;
    }

    public bool Deposit(decimal amount)
    {
        Money += amount;
        return true;
    }
}