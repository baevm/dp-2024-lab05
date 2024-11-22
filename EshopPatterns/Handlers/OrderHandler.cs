using EshopPattern.Commands;
using EshopPattern.Interfaces;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за первоначальную обработку заказа
/// </summary>
public class OrderHandler : OrderHandlerBase
{
    public OrderHandler(ICommand command) : base(command)
    {
    }
}