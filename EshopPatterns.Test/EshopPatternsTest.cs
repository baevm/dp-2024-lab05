using EshopPattern.Commands;
using EshopPattern.Entities;
using EshopPattern.Exceptions;
using EshopPattern.Handlers;
using EshopPattern.Infrastructure;

namespace EshopPatterns.Test;

public class EshopPatternsTest
{
    [Fact]
    public void Success_Order_Test()
    {
        var shopStorage = new Storage();

        var userCreditCard = new CreditCard();
        userCreditCard.Deposit(999999);

        var order = new Order("iphone", 3, "random city", userCreditCard);

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


        var exception = Record.Exception(() => orderHandler.Handle(order));
        Assert.Null(exception);
    }

    [Fact]
    public void OutOfStock_Order_Test()
    {
        var shopStorage = new Storage();

        var userCreditCard = new CreditCard();
        userCreditCard.Deposit(999999);

        var order = new Order("iphone", 200, "random city", userCreditCard);

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


        Assert.Throws<OutOfStockException>(() => orderHandler.Handle(order));
    }

    [Fact]
    public void NotEnoughMoney_On_Card_Order_Test()
    {
        var shopStorage = new Storage();

        var userCreditCard = new CreditCard();
        userCreditCard.Deposit(100);

        var order = new Order("iphone", 10, "random city", userCreditCard);

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


        Assert.Throws<PaymentProcessingException>(() => orderHandler.Handle(order));
    }

    [Fact]
    public void NullAddress_Order_Test()
    {
        var shopStorage = new Storage();

        var userCreditCard = new CreditCard();
        userCreditCard.Deposit(99999);

        var order = new Order("iphone", 1, null, userCreditCard);

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


        Assert.Throws<DeliveryException>(() => orderHandler.Handle(order));
    }
}