using EshopPattern.Entities;
using EshopPattern.Exceptions;
using EshopPattern.Services;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за проверку товара на складе
/// </summary>
class StockCheckHandler : OrderHandlerBase
{
    public override void Handle(Order order)
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
        base.Handle(order);
    }
}