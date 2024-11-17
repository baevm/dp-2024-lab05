using EshopPattern.Commands;
using EshopPattern.Entities;

namespace EshopPattern.Handlers;

public abstract class OrderHandlerBase : IOrderHandler
{
    private IOrderHandler? _nextHandler;
    private readonly ICommand _command;

    protected OrderHandlerBase(ICommand command)
    {
        _command = command;
    }

    public IOrderHandler? SetNext(IOrderHandler next)
    {
        _nextHandler = next;
        return next;
    }

    public virtual void Handle(Order order)
    {
        _command.Execute(order);
        _nextHandler?.Handle(order);
    }
}