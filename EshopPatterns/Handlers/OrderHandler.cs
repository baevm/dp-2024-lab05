using EshopPattern.Commands;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за первоначальную обработку заказа
/// </summary>
class OrderHandler : OrderHandlerBase
{
    public OrderHandler() : base(new ProcessOrderCommand())
    {
    }
}