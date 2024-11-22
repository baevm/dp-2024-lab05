using EshopPattern.Commands;
using EshopPattern.Interfaces;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за проверку товара на складе
/// </summary>
public class StockCheckHandler : OrderHandlerBase
{
    public StockCheckHandler(ICommand command) : base(command)
    {
    }
}