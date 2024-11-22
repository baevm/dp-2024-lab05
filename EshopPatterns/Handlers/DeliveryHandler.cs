using EshopPattern.Commands;
using EshopPattern.Interfaces;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за доставку товара
/// </summary>
public class DeliveryHandler : OrderHandlerBase
{
    public DeliveryHandler(ICommand deliveryCommand) : base(deliveryCommand)
    {
    }
}