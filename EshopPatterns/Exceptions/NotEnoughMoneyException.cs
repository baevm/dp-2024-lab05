namespace EshopPattern.Exceptions;

/// <summary>
/// Ошибка Недостаточно средств на карте
/// </summary>
public class NotEnoughMoneyException : Exception
{
    public NotEnoughMoneyException() : base("Недостаточно средств")
    {
    }
}