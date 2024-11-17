using EshopPattern.Entities;
using EshopPattern.Handlers;

namespace EshopPattern.Commands;

/// <summary>
/// Команда оплаты заказа
/// </summary>
public class ProcessPaymentCommand
{
    private readonly IOrderHandler _orderHandler;
    private readonly Order _order;

    public ProcessPaymentCommand(IOrderHandler orderHandler, Order order)
    {
        _orderHandler = orderHandler;
        _order = order;
    }

    public void Execute()
    {
        _orderHandler.Handle(_order);
    }
}