﻿using EshopPattern.Entities;
using EshopPattern.Handlers;

namespace EshopPattern;

internal class Program
{
    public static void Main()
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