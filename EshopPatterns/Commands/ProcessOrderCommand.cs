using EshopPattern.Entities;
using EshopPattern.Handlers;

namespace EshopPattern.Commands;

/// <summary>
/// Команда обработки заказа
/// </summary>
class ProcessOrderCommand : ICommand
{
    private readonly IOrderHandler _orderHandler;
    private readonly Order _order;

    public ProcessOrderCommand(IOrderHandler orderHandler, Order order)
    {
        _orderHandler = orderHandler;
        _order = order;
    }

    public void Execute()
    {
        _orderHandler.Handle(_order);
    }
}