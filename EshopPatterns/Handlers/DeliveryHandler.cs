using EshopPattern.Entities;
using EshopPattern.Exceptions;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за доставку товара
/// </summary>
class DeliveryHandler : OrderHandlerBase
{
    public override void Handle(Order order)
    {
        var isDelivered = Deliver(order);

        if (!isDelivered)
        {
            throw new DeliveryException();
        }

        order.IsDelivered = true;
        Console.WriteLine($"Заказ {order.ProductName} был доставлен");
        base.Handle(order);
    }

    private bool Deliver(Order order)
    {
        // todo: добавить ранд
        return true;
    }
}