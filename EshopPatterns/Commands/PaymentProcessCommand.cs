using EshopPattern.Entities;
using EshopPattern.Exceptions;
using EshopPattern.Interfaces;

namespace EshopPattern.Commands;

/// <summary>
/// Команда оплаты заказа
/// </summary>
public class PaymentProcessCommand : ICommand
{
    public void Execute(Order order)
    {
        try
        {
            ProcessPayment(order);
            order.IsPaymentProcessed = true;
            Console.WriteLine($"Заказ {order.ProductName} был успешно оплачен. Полная стоимость: {order.TotalPrice}");
        }
        catch (Exception e)
        {
            throw new PaymentProcessingException(e);
        }
    }

    private void ProcessPayment(Order order)
    {
        order.UserCreditCard?.Withdraw(order.TotalPrice);
    }
}