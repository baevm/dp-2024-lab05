using EshopPattern.Entities;
using EshopPattern.Interfaces;

namespace EshopPattern.Commands;

/// <summary>
/// Команда обработки заказа
/// </summary>
public class ProcessOrderCommand : ICommand
{
    public void Execute(Order order)
    {
        Console.WriteLine($"Начало обработки заказа {order.ProductName}.");
    }
}