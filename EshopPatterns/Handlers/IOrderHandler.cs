using EshopPattern.Entities;

namespace EshopPattern.Handlers;

/// <summary>
/// Интерфейс шага обработки заказа
/// </summary>
public interface IOrderHandler
{
    public IOrderHandler? SetNext(IOrderHandler next);
    public void Handle(Order order);
}