using EshopPattern.Commands;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за доставку товара
/// </summary>
class DeliveryHandler : OrderHandlerBase
{
    public DeliveryHandler() : base(new ProcessDeliveryCommand())
    {
    }
}