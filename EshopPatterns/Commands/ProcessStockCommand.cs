using EshopPattern.Entities;
using EshopPattern.Handlers;

namespace EshopPattern.Commands;

/// <summary>
/// Команда проверки товара на складе
/// </summary>
class ProcessStockCommand : ICommand
{
    private readonly IOrderHandler _orderHandler;
    private readonly Order _order;

    public ProcessStockCommand(IOrderHandler orderHandler, Order order)
    {
        _orderHandler = orderHandler;
        _order = order;
    }

    public void Execute()
    {
        _orderHandler.Handle(_order);
    }
}