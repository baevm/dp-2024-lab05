using EshopPattern.Commands;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за обработку платежа
/// </summary>
public class PaymentProcessHandler : OrderHandlerBase
{
    public PaymentProcessHandler() : base(new ProcessPaymentCommand())
    {
    }
}