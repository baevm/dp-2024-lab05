namespace EshopPattern.Exceptions;

/// <summary>
/// Ошибка при отсутствии товара
/// </summary>
public class OutOfStockException : Exception
{
    public OutOfStockException() : base("Товар отсутствует на складе")
    {
    }
}