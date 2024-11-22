namespace EshopPattern.Exceptions;

/// <summary>
/// Ошибка при проведении платежа
/// </summary>
public class PaymentProcessingException : Exception
{
    private const string TextMessage = "Ошибка при проведении платежа";

    public PaymentProcessingException() : base(TextMessage)
    {
    }

    public PaymentProcessingException(Exception innerException)
        : base(TextMessage, innerException) { }
}