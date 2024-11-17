using EshopPattern.Entities;
using EshopPattern.Exceptions;

namespace EshopPattern.Commands;

/// <summary>
/// Команда доставки заказа
/// </summary>
public class ProcessDeliveryCommand : ICommand
{
    public void Execute(Order order)
    {
        var isDelivered = Deliver(order);

        if (!isDelivered)
        {
            throw new DeliveryException();
        }

        order.IsDelivered = true;
        Console.WriteLine($"Заказ {order.ProductName} был доставлен");
    }

    private bool Deliver(Order order)
    {
        // todo: добавить ранд
        return true;
    }
}