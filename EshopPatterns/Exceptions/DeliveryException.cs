namespace EshopPattern.Exceptions;

/// <summary>
/// Ошибка при доставке
/// </summary>
public class DeliveryException : Exception
{
    public DeliveryException() : base("Ошибка при доставке")
    {
    }
}