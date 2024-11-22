namespace EshopPattern.Entities;

/// <summary>
/// Товар на складе
/// </summary>
public class ShopItem
{
    public decimal Price { get; set; }
    public int Count { get; set; }

    public ShopItem(int count, decimal price)
    {
        Count = count;
        Price = price;
    }
}