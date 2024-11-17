namespace EshopPattern.Entities;

/// <summary>
/// Товар на складе
/// </summary>
class ShopItem
{
    public decimal Price;
    public int Count;

    public ShopItem(int count, decimal price)
    {
        Count = count;
        Price = price;
    }
}