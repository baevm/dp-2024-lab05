using EshopPattern.Entities;
using EshopPattern.Exceptions;
using EshopPattern.Handlers;

namespace EshopPatterns.Test;

public class EshopPatternsTest
{
    [Fact]
    public void Success_order_test()
    {
        var order = new Order("iphone", 3);

        var orderHandler = new OrderHandler();
        var stockHandler = new StockCheckHandler();
        var paymentHandler = new PaymentProcessHandler();
        var deliveryHandler = new DeliveryHandler();

        orderHandler
            .SetNext(stockHandler)
            ?.SetNext(paymentHandler)
            ?.SetNext(deliveryHandler);


        var exception = Record.Exception(() => orderHandler.Handle(order));
        Assert.Null(exception);
    }

    [Fact]
    public void Out_of_stock_order_test()
    {
        var order = new Order("iphone", 9999);

        var orderHandler = new OrderHandler();
        var stockHandler = new StockCheckHandler();
        var paymentHandler = new PaymentProcessHandler();
        var deliveryHandler = new DeliveryHandler();

        orderHandler
            .SetNext(stockHandler)
            ?.SetNext(paymentHandler)
            ?.SetNext(deliveryHandler);


        Assert.Throws<OutOfStockException>(() => orderHandler.Handle(order));
    }
}