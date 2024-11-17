using EshopPattern.Entities;

namespace EshopPattern.Services;

/// <summary>
/// Склад товаров
/// </summary>
static class Storage
{
    private static Dictionary<string, ShopItem> _inventory = new()
    {
        { "iphone", new ShopItem(10, 1500) },
        { "monitor", new ShopItem(20, 300) },
        { "keyboard", new ShopItem(5, 20) },
        { "headphones", new ShopItem(3, 50) },
    };

    private static readonly object _lock = new();

    public static ShopItem? GetItem(string name)
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