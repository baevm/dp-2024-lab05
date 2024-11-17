using EshopPattern.Commands;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за проверку товара на складе
/// </summary>
class StockCheckHandler : OrderHandlerBase
{
    public StockCheckHandler() : base(new ProcessStockCommand())
    {
    }
}