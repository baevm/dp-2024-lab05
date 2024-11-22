using EshopPattern.Entities;

namespace EshopPattern.Interfaces;

public interface ICommand
{
    void Execute(Order order);
}