using EshopPattern.Entities;
using EshopPattern.Exceptions;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за обработку платежа
/// </summary>
class PaymentProcessHandler : OrderHandlerBase
{
    public override void Handle(Order order)
    {
        if (!ProcessPayment(order.TotalPrice))
        {
            throw new PaymentProcessingException();
        }

        order.IsPaymentProcessed = true;
        Console.WriteLine($"Заказ {order.ProductName} был успешно оплачен. Полная стоимость: {order.TotalPrice}");
        base.Handle(order);
    }

    private bool ProcessPayment(decimal totalAmount)
    {
        // todo: добавить рандом
        return true;
    }
}