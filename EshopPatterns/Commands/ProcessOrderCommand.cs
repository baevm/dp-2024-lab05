using EshopPattern.Entities;

namespace EshopPattern.Commands;

/// <summary>
/// Команда обработки заказа
/// </summary>
class ProcessOrderCommand : ICommand
{
    public void Execute(Order order)
    {
        Console.WriteLine($"Начало обработки заказа {order.ProductName}.");
    }
}