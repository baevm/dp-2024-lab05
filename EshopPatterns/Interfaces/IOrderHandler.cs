using EshopPattern.Entities;

namespace EshopPattern.Interfaces;

/// <summary>
/// Интерфейс шага обработки заказа
/// </summary>
public interface IOrderHandler
{
    /// <summary>
    /// Устанавливает следующий обрабочтик в цепочке
    /// </summary>
    /// <param name="next"></param>
    /// <returns></returns>
    public IOrderHandler? SetNext(IOrderHandler next);
    /// <summary>
    /// Вызов обработчика
    /// </summary>
    /// <param name="order"></param>
    public void Handle(Order order);
}