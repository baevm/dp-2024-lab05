using EshopPattern.Commands;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за доставку товара
/// </summary>
public class DeliveryHandler : OrderHandlerBase
{
    public DeliveryHandler() : base(new ProcessDeliveryCommand())
    {
    }
}