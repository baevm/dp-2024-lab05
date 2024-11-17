using EshopPattern.Entities;

namespace EshopPattern.Commands;

public interface ICommand
{
    void Execute(Order order);
}