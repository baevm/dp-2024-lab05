using EshopPattern.Commands;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за первоначальную обработку заказа
/// </summary>
public class OrderHandler : OrderHandlerBase
{
    public OrderHandler() : base(new ProcessOrderCommand())
    {
    }
}