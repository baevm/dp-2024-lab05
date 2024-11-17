using EshopPattern.Entities;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за первоначальную обработку заказа
/// </summary>
class OrderHandler : OrderHandlerBase
{
    public override void Handle(Order order)
    {
        Console.WriteLine($"Начало обработки заказа {order.ProductName}.");
        base.Handle(order);
    }
}