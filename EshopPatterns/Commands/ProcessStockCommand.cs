using EshopPattern.Entities;
using EshopPattern.Exceptions;
using EshopPattern.Services;

namespace EshopPattern.Commands;

/// <summary>
/// Команда проверки товара на складе
/// </summary>
class ProcessStockCommand : ICommand
{
    public void Execute(Order order)
    {
        for (int i = 0; i < order.Quantity; i++)
        {
            var item = Storage.GetItem(order.ProductName);

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