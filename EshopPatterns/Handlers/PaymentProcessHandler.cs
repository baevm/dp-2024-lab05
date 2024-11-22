using EshopPattern.Commands;
using EshopPattern.Interfaces;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за обработку платежа
/// </summary>
public class PaymentProcessHandler : OrderHandlerBase
{
    public PaymentProcessHandler(ICommand command) : base(command)
    {
    }
}