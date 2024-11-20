using EshopPattern.Entities;
using EshopPattern.Exceptions;

namespace EshopPattern.Commands;

/// <summary>
/// Команда оплаты заказа
/// </summary>
public class ProcessPaymentCommand : ICommand
{
    public void Execute(Order order)
    {
        if (!ProcessPayment(order.TotalPrice))
        {
            throw new PaymentProcessingException();
        }

        order.IsPaymentProcessed = true;
        Console.WriteLine($"Заказ {order.ProductName} был успешно оплачен. Полная стоимость: {order.TotalPrice}");
    }

    private bool ProcessPayment(decimal totalAmount)
    {
        return true;
    }
}