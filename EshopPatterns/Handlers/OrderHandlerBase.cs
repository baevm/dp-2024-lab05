using EshopPattern.Entities;

namespace EshopPattern.Handlers;

public abstract class OrderHandlerBase : IOrderHandler
{
    private IOrderHandler? _nextHandler;

    public IOrderHandler? SetNext(IOrderHandler next)
    {
        _nextHandler = next;
        return next;
    }

    public virtual void Handle(Order order)
    {
        _nextHandler?.Handle(order);
    }
}