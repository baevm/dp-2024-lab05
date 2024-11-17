namespace EshopPattern.Exceptions;

/// <summary>
/// Ошибка при проведении платежа
/// </summary>
public class PaymentProcessingException : Exception
{
    public PaymentProcessingException() : base("Ошибка при проведении платежа")
    {
    }
}