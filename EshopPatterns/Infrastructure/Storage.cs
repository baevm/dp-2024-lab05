using EshopPattern.Entities;

namespace EshopPattern.Infrastructure;

/// <summary>
/// Склад товаров
/// </summary>
public class Storage
{
    private Dictionary<string, ShopItem> _inventory = new()
    {
        { "iphone", new ShopItem(100, 1500) },
        { "monitor", new ShopItem(20, 300) },
        { "keyboard", new ShopItem(5, 20) },
        { "headphones", new ShopItem(3, 50) },
    };

    private readonly object _lock = new();

    /// <summary>
    /// Получить товар со склада
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public ShopItem? GetItem(string name)
    {
        lock (_lock)
        {
            if (_inventory.TryGetValue(name, out var item) && item.Count > 0)
            {
                item.Count -= 1;
                return item;
            }

            return null;
        }
    }
}