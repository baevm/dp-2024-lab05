using EshopPattern.Entities;
using EshopPattern.Exceptions;
using EshopPattern.Infrastructure;
using EshopPattern.Interfaces;

namespace EshopPattern.Commands;

/// <summary>
/// Команда проверки товара на складе
/// </summary>
public class ProcessStockCommand : ICommand
{
    private readonly Storage _storage;

    public ProcessStockCommand(Storage storage)
    {
        _storage = storage;
    }

    public void Execute(Order order)
    {
        for (int i = 0; i < order.Quantity; i++)
        {
            var item = _storage.GetItem(order.ProductName);

            if (item == null)
            {
                throw new OutOfStockException();
            }

            order.TotalPrice += item.Price;
        }

        order.IsStockChecked = true;
        Console.WriteLine(
            $"Проверка наличия товара {order.ProductName} пройдена. Количество: {order.Quantity}. Полная стоимость: {order.TotalPrice}");
    }
}