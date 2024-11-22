using EshopPattern.Commands;
using EshopPattern.Entities;
using EshopPattern.Handlers;
using EshopPattern.Infrastructure;

namespace EshopPattern;

internal class Program
{
    public static void Main()
    {
        var shopStorage = new Storage();

        var userCreditCard = new CreditCard();
        userCreditCard.Deposit(2000);

        var order = new Order("iphone", 3, "ufa", userCreditCard);

        var processOrderCommand = new ProcessOrderCommand();
        var processStockCommand = new ProcessStockCommand(shopStorage);
        var paymentProcessCommand = new PaymentProcessCommand();
        var deliveryCommand = new ProcessDeliveryCommand();

        var orderHandler = new OrderHandler(processOrderCommand);
        var stockHandler = new StockCheckHandler(processStockCommand);
        var paymentHandler = new PaymentProcessHandler(paymentProcessCommand);
        var deliveryHandler = new DeliveryHandler(deliveryCommand);

        orderHandler
            .SetNext(stockHandler)
            ?.SetNext(paymentHandler)
            ?.SetNext(deliveryHandler);

        try
        {
            orderHandler.Handle(order);
            Console.WriteLine(order);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}