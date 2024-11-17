namespace EshopPattern.Entities;

/// <summary>
/// Заказ пользователя
/// </summary>
public class Order
{
    /// <summary>
    /// Название продукта в заказе
    /// </summary>
    public string ProductName { get; set; }

    /// <summary>
    /// Количество
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Полная стоимость заказа
    /// </summary>
    public decimal TotalPrice { get; set; } = 0;

    /// <summary>
    /// Шаг обработки заказа на складе пройден
    /// </summary>
    public bool IsStockChecked { get; set; } = false;

    /// <summary>
    /// Шаг оплаты заказа пройден
    /// </summary>
    public bool IsPaymentProcessed { get; set; } = false;

    /// <summary>
    /// Шаг доставки пройден
    /// </summary>
    public bool IsDelivered { get; set; } = false;

    public Order(string productName, int quantity)
    {
        ProductName = productName;
        Quantity = quantity;
    }
}